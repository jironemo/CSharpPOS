using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp1
{
    //
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            Utilities.setDataGridViewStyle(sales_table);
            getSales();
        }
        public void getSales()
        {

            BindingList<Object> sales = new BindingList<Object>();
            String query  = "select Sale.id,Stock.Name,Customer.Cus_name,Sale.DateOfSale,Stock.id from Sale,Stock,Customer where Sale.Item_ID = Stock.ID and Sale.Cus_ID = customer.id";
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                SqliteBlob blob = new SqliteBlob(Utilities.getConnection(), "Stock", "Image", read.GetInt32(4)); 
                var v = new { saleid = read.GetInt32(0), stockname = read.GetString(1), cusname = read.GetString(2), datetime = read.GetDateTime(3), img = Image.FromStream(blob)};
                sales.Add(v);
                blob.Close();
            }
            read.Close();
            Utilities.closeConnection();
            sales_table.DataSource = sales;
        }




        private void sales_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = sales_table.SelectedRows[0];
            DataGridViewCellCollection cells = row.Cells;
            txt_vouch_num.Text = Convert.ToInt32(cells[0].Value).ToString();

            txt_item_name.Text = cells[1].Value.ToString();
            txt_cus_name.Text = cells[2].Value.ToString();
            txt_dueDate.Text = Convert.ToDateTime(cells[3].Value).ToString();
            pictureBox1.Image = (Image)cells[4].Value;
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                String query = "Select item_id,cus_id from Sale where ID = " + txt_vouch_num.Text;
                InfoViewer g = new InfoViewer();
                SqliteCommand cmd = Utilities.makeCommand(query);
                SqliteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Int32 id = Convert.ToInt32(reader.GetInt32(0));
                Int32 cusid = Convert.ToInt32(reader.GetInt32(1));
                g.Controls.Clear();
                g.Controls.Add(new ItemInfo(id, Convert.ToInt32(txt_vouch_num.Text), cusid));
                g.Show();
                reader.Close();
                Utilities.closeConnection();
            }
            catch (Exception)
            {
                PopupNotifier g = new PopupNotifier
                {
                    TitleText = "Error",
                    ContentText = "Error Showing Result"
                };
                g.Popup();
                
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            NewSale newSale = new NewSale();
            newSale.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Sales(Form v)
        {
            throw new NotImplementedException();
        }
    }
}
