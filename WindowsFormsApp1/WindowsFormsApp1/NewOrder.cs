using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            this.txt_order_id.Text = (Utilities.getLatestId("[Order]")).ToString();
            this.txt_item_id.Text = (Utilities.getLatestId("[Stock]")).ToString();
            
        }

        public void addOrder()
        {
            Item g = new Item(Utilities.getLatestId("Stock"),txt_item_name.Text,(txt_item_kyat.Text+ ","+txt_item_pel.Text + "," + txt_item_yway.Text),float.Parse(txt_item_price.Text),new PictureBox().ErrorImage);
            String itemquer = "INSERT INTO Stock(id,name,weight,price,stock_status)" +
                  "VALUES('{0}','{1}','{2}','{3}','ordered'); ";
            itemquer = String.Format(itemquer,g.id,g.name,g.weight,g.price);
            SqliteCommand itemcmd = Utilities.makeCommand(itemquer);
            itemcmd.ExecuteNonQuery();
            var k = new {id= Utilities.getLatestId("Customer"), name= txt_cus_name.Text,addr = txt_cus_addr.Text,phone = txt_cus_phone.Text};
            String query = String.Format("insert into Customer values ({0},'{1}','{2}','{3}');",k.id,k.name,k.addr,k.phone);
            SqliteCommand cmd = Utilities.makeCommand(query);
            cmd.ExecuteNonQuery();
            Utilities.closeConnection();
            
            String query2 = String.Format("insert into [Order] values ({0},'{1}','{2}',DATE(),'{3}','{4}','{5}');",txt_order_id.Text,k.id, txt_item_id.Text, dateTimePicker1.Value, txt_item_desc.Text,(txt_depre_kyat.Text + ","+txt_depre_pel.Text + ","+txt_depre_yway.Text));
            SqliteCommand cmd2 = Utilities.makeCommand(query2);
            cmd2.ExecuteNonQuery();
            Utilities.closeConnection();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try { addOrder(); } catch (Exception)
            {
                MessageBox.Show("အချက်အလက်မပြည့်စုံပါ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
