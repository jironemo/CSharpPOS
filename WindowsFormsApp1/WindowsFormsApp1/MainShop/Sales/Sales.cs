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
    //
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            setDataGridViewStyle();
            getSales();
        }
        private void getSales()
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
            sales_table.DataSource = sales;
        }
        private void setDataGridViewStyle()
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font("Myanmar Text", 16);
            cellStyle.ForeColor = Color.White;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = Color.FromArgb(255, 20, 39, 78);
            sales_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales_table.ColumnHeadersDefaultCellStyle = cellStyle;
            sales_table.DefaultCellStyle = cellStyle;
            sales_table.RowTemplate.Height = 40;
        }

        private void sales_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] textBoxes = { txt_vouch_num,txt_item_name,txt_cus_name};
            DataGridViewRow row = sales_table.SelectedRows[0];
            DataGridViewCellCollection cells = row.Cells;
            txt_vouch_num.Text = Convert.ToInt32(cells[0].Value).ToString();

            txt_item_name.Text = cells[1].Value.ToString();
            txt_cus_name.Text = cells[2].Value.ToString();
            dt_saledate.Value = Convert.ToDateTime(cells[3].Value);
            pictureBox1.Image = (Image)cells[4].Value;
        }

        private void clearAllBoxes()
        {
            foreach(Control c in this.panel1.Controls)
            {
                if (c is TextBox )
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if(c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String query = "Select item_id from Sale where ID = " + txt_vouch_num.Text;
            InfoViewer g = new InfoViewer();
            SqliteCommand cmd = Utilities.makeCommand(query);
            Int32 id = Convert.ToInt32(cmd.ExecuteScalar());
            g.Controls.Clear();
            g.Controls.Add(new ItemInfo(id));
            g.Show();

        }
    }
}
