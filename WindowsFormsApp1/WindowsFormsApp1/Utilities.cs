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
    }
}
