
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

    public partial class StockTable : UserControl
    {
        AddStock ast = new AddStock();
        public StockTable()
        {
            InitializeComponent();
            
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            
            Utilities.setDataGridViewStyle(view_table);
            loadStock();
            
        }

        /// <summary>
        /// setting the style of the datagirdview
        /// </summary>
       


        /// <summary>
        /// loading the data 
        /// </summary>
        /// 
        public void loadStock()
        {

            string query = "select * from Stock where stock_status = 'stock'";

            try
            {
                SqliteCommand c = Utilities.makeCommand(query);
                SqliteDataReader read = c.ExecuteReader();
                BindingList<Item> g = new BindingList<Item>();
                Int32 v = 0;
                while (read.Read())
                {
                    try
                    {
                        v = read.GetInt32(0);
                        var outputstream = new SqliteBlob(Utilities.getConnection(), "Stock", "Image", v);
                        Item k = new Item(v, read.GetString(1), read.GetString(2), read.GetFloat(3), Image.FromStream(outputstream));
                        g.Add(k);
                        view_table.DataSource = g;
                        String[] headers = { "ပစ္စည်းအမှတ်", "ပစ္စည်းအမည်", "အလေးချိန်", "စျေးနှုန်း", "နမူနာ" };
                        Utilities.setHeaders(view_table, headers);
                        outputstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ex: " + ex.GetType().FullName + "" + ex.Message);
                        MessageBox.Show("exStack:" + ex.StackTrace);
                    }
                }

                dataGridView1_CellClick(null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show("e:" + e.Message);
            }
            finally
            {
                Utilities.closeConnection();
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
            DataGridViewRow row = view_table.SelectedRows[0];
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
            txt_name.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                String name = txt_name.Text;
                String weight = txt_kyat.Text + ","+txt_pel.Text+","+txt_yway.Text;
                float price =(float) Convert.ToDouble(txt_price.Text);
                Item i = new Item(id,name, weight, price, pictureBox1.Image);
                i.updateDB();
            }
            catch (Exception z)
            {
                MessageBox.Show("gMsg:"+z.Message);
                MessageBox.Show("gStack:"+z.StackTrace);
            }
            finally
            {
                Utilities.closeConnection();
                loadStock();
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Utilities.UploadImage(pictureBox1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Utilities.deleteData("Stock", Int32.Parse(txt_id.Text));
            loadStock();
            Utilities.clearBoxes(panel1);
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            Form s = new Form();
            s.BackColor = this.Parent.BackColor;
            s.Controls.Add(ast);
            s.Size = new Size(ast.Size.Width + 10 ,ast.Size.Height+30);
            s.Show();
        }
    }
}
