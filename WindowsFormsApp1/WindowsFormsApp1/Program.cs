using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
      {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {

                string directory = @"C:\my\";
                string filedir = directory + "shop.db";
                if (Directory.Exists(directory))
                {

                }
                else
                {
                    Directory.CreateDirectory(directory);
                    File.Copy("shop.db", filedir);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("error"+ e.Message);
            }
            Application.Run(new Main_Menu());
        }
    }
}
