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
    public partial class AddStock : UserControl 
    {
        public AddStock()
        {
            InitializeComponent();
            txt_id.Text = Utilities.getLatestId("Stock").ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Control k = this.Parent;
            (this.Parent).Controls.Remove(this);
            foreach(Control g in k.Controls)
            {
                g.Visible = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String weight = String.Format("{0},{1},{2}", txt_kyat.Text, txt_pel.Text, txt_yway.Text);
            Item k = new Item(Utilities.getLatestId("Stock"), txt_name.Text, weight, float.Parse(txt_price.Text), pictureBox1.Image);
            k.AddToDB();
            ((StockTable)this.Parent.Parent).loadStock();
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
            }
        }
    }
}
