using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InfoViewer : Form
    {

        Sales sales = null;
        public InfoViewer(Sales sales)
        {
            InitializeComponent();
            this.sales = sales;
        }

        private void InfoViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            sales.getSales();
        }
    }
}
