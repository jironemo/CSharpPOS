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
        public OrderTable()
        {
            InitializeComponent();
            loadOrder();
            Utilities.setDataGridViewStyle(view_table);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        public void loadOrder()
        {
            String query = "select [Order].ID, Stock.Name,Customer.Cus_Name,[Order].DueDate from [" +
                "Order],Stock,Customer where Stock.ID = [Order].Item_ID AND Customer.ID " +
                "= [Order].Customer_ID";
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
    }
}
