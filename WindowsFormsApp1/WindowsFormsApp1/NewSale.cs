using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public partial class NewSale : Form
    {
        public NewSale()
        {
            InitializeComponent();
        }

        private void txt_item_num_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            

        }
        private void getItem()
        {
            String query = "SELECT * FROM Stock where id = " + txt_item_num.Text;
            SqliteCommand cmd = Utilities.makeCommand(query);
            SqliteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            richTextBox1.Text = reader.GetInt32(0).ToString() + "  " + reader.GetString(1).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getItem();
        }
    }
}
