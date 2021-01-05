using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace WindowsFormsApp1
{
    public partial class NewSale : Form
    {
        public NewSale()
        {
            InitializeComponent();
        }

        private void getItem()
        {
            String query = "SELECT * FROM Stock where id = " + txt_item_num.Text + " and stock_status = 'stock'";
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                String txt = "{0}   |   {1} |   {2}";
                richTextBox1.Text = String.Format(txt,reader.GetInt32(0).ToString(),reader.GetString(1),reader.GetString(2));
                richTextBox1.Text += "\n စျေးနှုန်း :" + reader.GetString(3);
            }catch(Exception)
            {
                showError();
            }
            Utilities.closeConnection();
        }

        private void showError()
        {

            txt_item_num.ForeColor = Color.Red;
            txt_item_num.BorderStyle = BorderStyle.FixedSingle;
            label3.Visible = true;
            richTextBox1.Text = String.Empty;
        }
        private void txt_item_num_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            txt_item_num.ForeColor = Color.Black;
            label3.Visible = false;
            if(e.KeyCode == Keys.Tab)
            {
                getItem();
            }
        }

        private void txt_item_num_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            addSale();
        }
        private void addSale()
        {
            String query1 = "insert into Customer values ('{0}','{1}','{2}','{3}')";
            int k = Utilities.getLatestId("Customer");
            query1 = String.Format(query1, k.ToString(), txt_cus_name.Text, txt_cus_ad.Text, txt_cus_phone.Text);
            SqliteCommand cmd = Utilities.makeCommand(query1);
            cmd.ExecuteNonQuery();
            String query2 = "insert into Sale values ('{0}','{1}','{2}',DATE())";
            int g = Utilities.getLatestId("Sale");
            query2 = String.Format(query2,g.ToString(),txt_item_num.Text,k.ToString());
            SqliteCommand cmd2 = Utilities.makeCommand(query2);
            cmd2.ExecuteNonQuery();
            String query3 = "update Stock set stock_status = 'sold' where id = "+ txt_item_num.Text;
            SqliteCommand cmd3 = Utilities.makeCommand(query3);
            cmd3.ExecuteNonQuery();
            Log.write(DateTime.Now.ToString() + " Added a new Sale | " + " id = " + g.ToString());
            this.Close();
            
        }
    }
}
