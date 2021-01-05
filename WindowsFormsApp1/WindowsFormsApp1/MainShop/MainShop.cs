using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public partial class MainShop : Form

    {
        StockTable stock = new StockTable();
        OrderTable orders = new OrderTable();
        Sales sales = new Sales();
        public MainShop()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(stock);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(stock);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(orders);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(sales);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }       
}
