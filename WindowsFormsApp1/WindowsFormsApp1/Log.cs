using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp1
{
    class Log
    {
        
        public static void write(String f)
        {
            StreamWriter sw = new StreamWriter(@"log.txt");
            sw.WriteLine(f);
            sw.Close();
        }
    }
}
