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
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            new Tables().Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
