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

namespace WindowsFormsApp1
{
    public partial class OrderTable : UserControl
    {
        int cusid;
        public OrderTable()
        {
            InitializeComponent();
            loadOrder();
            Utilities.setDataGridViewStyle(view_table);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to update data?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateOrder();
                updateCus();
                updateStock();
            }    

            loadOrder();
        }

        private void loadOrder()
        {
            String query = "select [Order].ID, Stock.Name,Customer.Cus_Name,[Order].DueDate from " +
                "[Order],Stock,Customer where Stock.ID = [Order].Item_ID AND Customer.ID " +
                "= [Order].Customer_ID;";
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader reader = cmd.ExecuteReader();
            BindingList<Object> orders = new BindingList<Object>();
            while (reader.Read())
            {
                orders.Add(new { id = reader.GetInt32(0),stockname=reader.GetString(1),cusname=reader.GetString(2),duedate = reader.GetDateTime(3)});
            }
            reader.Close();
            view_table.DataSource = orders;
        }

        private void view_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dueDate.ForeColor = Color.Black;
            String idstr = view_table.SelectedRows[0].Cells[0].Value.ToString();
            String query = "select Customer.Cus_Addr,Customer.Cus_Phone,[Order].Item_ID,[Order].DueDate,Stock.Price,Customer.ID as cus_id," +
                "[Order].item_description,[Order].Depreciation" +
                " from [Order],Stock,Customer where Stock.ID = [Order].Item_ID AND Customer.ID  = [Order].Customer_ID and " +
                "[Order].ID = " + idstr+";";

            txt_order_id.Text = idstr;
            txt_cus_name.Text = view_table.SelectedRows[0].Cells[2].Value.ToString();
            txt_item_name.Text = view_table.SelectedRows[0].Cells[1].Value.ToString();
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txt_cus_addr.Text = reader.GetString(reader.GetOrdinal("Cus_Addr"));
                txt_cus_phone.Text = reader.GetString(reader.GetOrdinal("Cus_Phone"));
                txt_depre.Text = reader.GetString(reader.GetOrdinal("Depreciation"));
                txt_item_desc.Text = reader.GetString(reader.GetOrdinal("item_description")); 
                txt_item_id.Text = reader.GetString(reader.GetOrdinal("Item_ID"));
                DateTime dt = reader.GetDateTime(reader.GetOrdinal("DueDate"));
                this.cusid = reader.GetInt32(reader.GetOrdinal("cus_id"));
                txt_dueDate.Text = dt.ToString();
                if ((dt - DateTime.Now).Days <= 7)
                    txt_dueDate.ForeColor = Color.Red;
                txt_item_price.Text = reader.GetString(reader.GetOrdinal("Price"));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this data?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Utilities.deleteData("[Order]", Convert.ToInt32(txt_order_id.Text));
                Utilities.deleteData("Customer",cusid);
                Utilities.deleteData("Stock", Convert.ToInt32(txt_item_id.Text));
            }
            loadOrder();
        }


        private void updateStock() 
        {
            string query = "update stock set name = '{0}',price = '{1}' where id = '{2}';" ;
            query = String.Format(query,txt_item_name.Text,txt_item_price.Text,txt_item_id.Text);
            SqliteCommand cmd = Utilities.makeCommand(query);
            cmd.ExecuteNonQuery();
            Utilities.closeConnection();
        }

        private void updateCus()
        {
            String query2 = "update Customer set cus_name = '{0}',cus_phone ='{1}',cus_addr ='{2}' where id = '{3}';";
            query2 = String.Format(query2, txt_cus_name.Text, txt_cus_phone.Text, txt_cus_addr.Text, cusid);
            SqliteCommand cmd = Utilities.makeCommand(query2);
            cmd.ExecuteNonQuery();
            Utilities.closeConnection();
        }

        private void updateOrder() {
            String query3 = "update [order] set dueDate = '{0}',depreciation = '{1}',item_description = '{2}' where id = '{3}';";
            query3 = String.Format(query3, dateTimePicker1.Value, txt_depre.Text, txt_item_desc.Text, txt_order_id.Text);
            SqliteCommand cmd = Utilities.makeCommand(query3);
            cmd.ExecuteNonQuery();
            Utilities.closeConnection();

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_order_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_dueDate.Visible = false;
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_dueDate.Text = dateTimePicker1.Value.ToString();
            dateTimePicker1.Visible = false;
            txt_dueDate.Visible = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            NewOrder newOrder = new NewOrder();
            newOrder.Show();
        }
    }
}
