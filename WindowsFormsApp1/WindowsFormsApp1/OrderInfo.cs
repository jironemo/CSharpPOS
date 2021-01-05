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
    public partial class OrderInfo : UserControl
    {
        public OrderInfo(String id)
        {
            InitializeComponent();
            loadOrderInfos(id);
        }

        private void loadOrderInfos(String id)
        {
            String idstr = id;
            String query = "select Customer.Cus_Name,Stock.Name,Customer.Cus_Addr,Customer.Cus_Phone,[Order].Item_ID,[Order].DueDate,Stock.Price,Customer.ID as cus_id," +
                "[Order].item_description,[Order].Depreciation" +
                " from [Order],Stock,Customer where Stock.ID = [Order].Item_ID AND Customer.ID  = [Order].Customer_ID and " +
                "[Order].ID = " + idstr + ";";

            txt_order_id.Text = idstr;
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                txt_cus_name.Text = reader.GetString(reader.GetOrdinal("Cus_Name"));
                txt_item_name.Text = reader.GetString(reader.GetOrdinal("Name"));
                txt_cus_addr.Text = reader.GetString(reader.GetOrdinal("Cus_Addr"));
                txt_cus_phone.Text = reader.GetString(reader.GetOrdinal("Cus_Phone"));
                txt_depre.Text = reader.GetString(reader.GetOrdinal("Depreciation"));
                txt_item_desc.Text = reader.GetString(reader.GetOrdinal("item_description"));
                txt_item_id.Text = reader.GetString(reader.GetOrdinal("Item_ID"));
                DateTime dt = reader.GetDateTime(reader.GetOrdinal("DueDate"));
                txt_dueDate.Text = dt.ToString();
                if ((dt - DateTime.Now).Days <= 7)
                    txt_dueDate.ForeColor = Color.Red;
                txt_item_price.Text = reader.GetString(reader.GetOrdinal("Price"));
            }
        }
    }
}
