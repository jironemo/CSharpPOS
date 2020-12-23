using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    class Utilities
    {
        static SqliteConnection con;
        static SqliteCommand cmd;

        static string con_str = "Data Source=shop.db;Cache=Shared;Mode=ReadWrite;";

        internal static Int32 getLatestId(string v)
        {
            int id = 0;
            SqliteCommand c = makeCommand("SELECT MAX(id)+1 from " + v +";");
            id = Convert.ToInt32(c.ExecuteScalar());
            return id;
        }

        public static void setHeaders(DataGridView dView, String[] headers)
        {
            foreach (DataGridViewColumn col in dView.Columns)
            {
                col.HeaderText = headers[col.Index];
            }
        }


        public static SqliteCommand makeCommand(String query)
        {
            con = new SqliteConnection(con_str);
            con.Open();
            cmd = new SqliteCommand(query, con);
            return cmd;
        }
        public static SqliteConnection getConnection()
        {
            con.Open();
            return (con);
        }
        public static void closeConnection()
        {
            con.Close();
        }

        internal static byte[] ImgToByte(Image image)
        {
            ImageConverter cg = new ImageConverter();
            Bitmap tmp = new Bitmap(image);
            byte[] byteImg = (byte[])cg.ConvertTo(tmp.Clone(), typeof(byte[]));
            return byteImg;
        }

        internal static void UploadImage(PictureBox pictureBox1)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
            }
        }

        public static void deleteData(String dbname, int id) {
            String query = "Delete from "+dbname+" where id = " + id;
            SqliteCommand cmd = makeCommand(query);
            try
            {
                if (MessageBox.Show("ဖျက်မည်", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful Deletion\n" + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.Read();
            }
            closeConnection();
            
        }
        public static void setDataGridViewStyle(DataGridView gv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font("Myanmar Paoh Rosemarry", 16);
            cellStyle.ForeColor = Color.White;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = Color.FromArgb(255, 20, 39, 78);
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.ColumnHeadersDefaultCellStyle = cellStyle;
            gv.DefaultCellStyle = cellStyle;
            gv.RowTemplate.Height = 40;
        }

        internal static void clearBoxes(Control c)
        {
            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox)
                {
                 if (ctrl.Enabled == true)
                        ctrl.Text = String.Empty;
                }
                else if (ctrl is PictureBox)
                {
                    ((PictureBox)ctrl).Image = null;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }
    }
}
