using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Utilities
    {
        public static void setHeaders(DataGridView dView, String[] headers)
        {
            foreach (DataGridViewColumn col in dView.Columns)
            {
                col.HeaderText = headers[col.Index];
            }
        }
    }
}
