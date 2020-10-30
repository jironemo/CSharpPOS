
using System;
using System.ComponentModel;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace WindowsFormsApp1
{

    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            setDataGridViewStyle();
            loadStock();
        }

        /// <summary>
        /// setting the style of the datagirdview
        /// </summary>
        private void setDataGridViewStyle()
        {
            DataGridViewCellStyle n = new DataGridViewCellStyle();
            n.Font = new Font("Myanmar Paoh Rosemarry", 16);
            n.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersDefaultCellStyle = n;
            dataGridView1.DefaultCellStyle = n;
            dataGridView1.RowTemplate.Height = 40;
        }


        /// <summary>
        /// loading the data 
        /// </summary>
        /// 
        string con_str = "Data Source=shop.db;Cache=Shared;Mode=ReadWrite;";
        private void loadStock()
        {

            string command = "select * from Stock";
            SqliteConnection con = new SqliteConnection(con_str);
            con.Open();
            try
            {
                SqliteCommand c = new SqliteCommand(command, con);
                SqliteDataReader read = c.ExecuteReader();
                BindingList<Item> g = new BindingList<Item>();
                Int32 v = 0;
                while (read.Read())
                {
                    try
                    {
                        v = read.GetInt32(0);
                        var outputstream = new SqliteBlob(con, "Stock", "Image", v);
                        Item k = new Item(v, read.GetString(1), read.GetString(2), read.GetFloat(3), Image.FromStream(outputstream));
                        g.Add(k);
                        dataGridView1.DataSource = g;
                        String[] headers = { "ပစ္စည်းအမှတ်", "ပစ္စည်းအမည်", "အလေးချိန်", "စျေးနှုန်း", "နမူနာ" };
                        Utilities.setHeaders(dataGridView1, headers);
                        outputstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ex: " + ex.GetType().FullName + "" + ex.Message);
                        MessageBox.Show("exStack:" + ex.StackTrace);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("e:" + e.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        /// <summary>
        /// used to fill the BindingList with Data from SQLite Database Table
        /// </summary>
        /// <param name="read"> SQLite Data Reader </param>
        /// <returns></returns>

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Item g = new Item(row);
            txt_id.Text = Convert.ToString(g.id);
            txt_name.Text = g.name;
            string[] kpy = g.weight.Split(',') ;
            TextBox[] textboxes = { txt_kyat, txt_pel, txt_yway };
            int j = 0;
            foreach(TextBox b in textboxes)
            {
                b.Text = kpy[j];
                j++;
            }
            txt_price.Text = Convert.ToString(g.price);
            pictureBox1.Image = g.img;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqliteConnection con2 = new SqliteConnection(con_str);
            con2.Open();
            Image k = pictureBox1.Image;
            ImageConverter g = new ImageConverter();
            try
            {
                String name = txt_name.Text;
                String weight = txt_kyat.Text + ","+txt_pel.Text+","+txt_yway.Text;
                float price =(float) Convert.ToDouble(txt_price.Text);
                ImageConverter cg = new ImageConverter();
                Bitmap tmp = new Bitmap(k);
                byte[] byteImg = (byte[])cg.ConvertTo(tmp.Clone(), typeof(byte[]));
                string command =String.Format("Update stock set name = '{0}',weight ='{1}',price ='{2}',image = @pic where id = {3}", name, weight,(price), Convert.ToInt32(txt_id.Text));
                SqliteCommand c = new SqliteCommand(command, con2);
                c.Parameters.AddWithValue("@pic", byteImg);
                c.ExecuteNonQuery();
                MessageBox.Show("Data Successfully updated");
            }
            catch (Exception z)
            {
                MessageBox.Show("gMsg:"+z.Message);
                MessageBox.Show("gStack:"+z.StackTrace);
            }
            finally
            {
                con2.Close();
                con2.Dispose();
                loadStock();
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
            }
        }
    }
}
