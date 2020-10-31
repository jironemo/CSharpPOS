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

namespace WindowsFormsApp1
{
    public partial class Tables : Form

    {


        StockTable stock = new StockTable();
        OrderTable orders = new OrderTable();
        public Tables()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
    }       
}
