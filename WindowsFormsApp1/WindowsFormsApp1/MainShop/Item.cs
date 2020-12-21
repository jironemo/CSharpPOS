using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Item
    {

        public Int32 id { get; set; }         //---\
        public String name { get; set; }       //   |
                                               //these are class attributes with getters and setters  
        public String weight { get; set; }      //   |
        public double price { get; set; }       //---/
        public Image img { get; set; }
        public Item() {
        } //empty constructor

        public Item(Int32 id, String name, String weight, float price, Image img)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.price = price;
            this.img = img;
        }

        public Item(DataGridViewRow row)
        {
            this.id = Convert.ToInt32(row.Cells[0].Value);
            this.name = Convert.ToString(row.Cells[1].Value);
            this.weight = Convert.ToString(row.Cells[2].Value);
            this.price = Convert.ToDouble(row.Cells[3].Value);
            this.img = (Image)row.Cells[4].Value;
        }


        public void AddToDB()
        {
            string query = String.Format("INSERT INTO Stock (name,weight,price,image,stock_Status) VALUES ('{0}','{1}','{2}',@pic,'stock')", this.name, this.weight, this.price);
            SqliteCommand cmd = Utilities.makeCommand(query);
            cmd.Parameters.AddWithValue("@pic", Utilities.ImgToByte(this.img));
            MessageBox.Show(cmd.ExecuteNonQuery().ToString());
            Utilities.closeConnection();

        }

        public void updateDB()
        {
            string query = String.Format("Update stock set name = '{0}',weight ='{1}',price ='{2}',image = @pic where id = {3}", name, weight, (price), Convert.ToInt32(this.id));
            SqliteCommand c = Utilities.makeCommand(query);
            c.Parameters.AddWithValue("@pic", Utilities.ImgToByte(this.img));
            c.ExecuteNonQuery();
            MessageBox.Show("Data Successfully updated");
            Utilities.closeConnection();
        }

        public void msgItem() {
            MessageBox.Show(this.id + "\n" + this.name + "\n"/*+this.weight**/ + "\n" + this.price + "\n");
        }
    }
}
