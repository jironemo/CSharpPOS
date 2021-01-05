using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            getDueOrders();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            new MainShop().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Savings().Show();
        }

        private void Main_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btn_add_sale_Click(sender,e);
            } else if (e.Shift && e.KeyCode == Keys.N)
            {
                btn_add_buyin_Click(sender, e);
            } else if (e.Control && e.KeyCode == Keys.S)
            {
                btn_stock_Click(sender, e);
            } else if (e.Shift && e.KeyCode == Keys.S)
            {
                button2_Click(sender,e);
            }
        }

        private void btn_add_sale_Click(object sender, EventArgs e)
        {
            NewSale newSale = new NewSale();
            newSale.Show();
        }

        private void btn_add_buyin_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.Show();
        }

        private void getDueOrders()
        {
            String query = "select id,DueDate from [Order];";
            DateTime today = DateTime.Today;
            SqliteCommand c = Utilities.makeCommand(query);
            SqliteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                DateTime dueTime = reader.GetDateTime(1);
                
                if((dueTime - today).Days <= 7)
                {
                    listBox1.Items.Add("Order Number " + reader.GetInt32(0) + " is due on " + dueTime.DayOfWeek.ToString() + " " + dueTime.ToString("MMMM ") + dueTime.Day.ToString());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                try
                {
                    String s = listBox1.SelectedItem.ToString();

                    String[] str = s.Split('i');
                    String num = "";
                    foreach (char c in str[0])
                    {
                        if (Char.IsDigit(c))
                        {
                            num += c;
                        }
                    }
                    int id = Convert.ToInt32(num);
                showOrderInfo(id);
                }
                catch (Exception) { };
        }


        public void showOrderInfo(int id)
        {
            InfoViewer f = new InfoViewer();
            f.Text = "Order Information";
            f.Controls.Add(new OrderInfo(id.ToString()));
            f.Show();
        }
    }
}
