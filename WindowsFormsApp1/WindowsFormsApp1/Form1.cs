
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Stock k = new Stock();
            panel1.Controls.Add(k);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Stock k = new Stock();
            panel1.Controls.Add(k);
        }
    }       
}
