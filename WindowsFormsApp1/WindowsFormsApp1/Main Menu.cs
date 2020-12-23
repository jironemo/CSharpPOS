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
                MessageBox.Show("Hello");
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
    }
}
