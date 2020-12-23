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
    public partial class ItemInfo : UserControl
    {
        int id;
        int vouchid;
        int cusid;
        public ItemInfo(int id,int vouchid,int cusid)
        {
            InitializeComponent();
            this.id = id;
            this.vouchid = vouchid;
            this.cusid = cusid;
            displayData();
            
        }
        public void displayData()
        {
            String query = "select * from Stock where id = " + id;
            SqliteCommand g = Utilities.makeCommand(query);
            SqliteDataReader reader = g.ExecuteReader();
            reader.Read();
            txt_id.Text = reader.GetValue(0).ToString();
            txt_name.Text = reader.GetValue(1).ToString();
            String[] weight = reader.GetValue(2).ToString().Split(',');
            txt_kyat.Text = weight[0];
            txt_pel.Text = weight[1];
            txt_yway.Text = weight[2];
            txt_price.Text = reader.GetValue(3).ToString();
            SqliteBlob img = new SqliteBlob(Utilities.getConnection(), "Stock", "Image", Convert.ToInt32(reader.GetValue(0)));
            pictureBox1.Image = Image.FromStream(img);
            img.Close();
            reader.Close();
            Utilities.closeConnection();
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Utilities.deleteData("Sale", vouchid);
            Utilities.deleteData("Stock", id);
            Utilities.deleteData("Customer", cusid);
            ((Form)this.Parent).Close();
        }

        
    }
}
