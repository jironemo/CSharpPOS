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
        public String weight{ get; set; }      //   |
        public double price { get; set; }       //---/
        public Image img { get; set; }
        public Item(){
        } //empty constructor
        
        public Item(Int32 id, String name, String weight, float price,Image img)
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

        public void msgItem() {
            MessageBox.Show(this.id + "\n" + this.name + "\n"/*+this.weight**/ + "\n" + this.price + "\n");
        }
    }
}
