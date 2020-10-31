using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Order
    {
        Item item_ordered { get; set; }
        DateTime dueDate;
        DateTime OrderDate;

        public Order()
        {
            ///Empty Constructor
        }

        public Order(Item item_ordered,DateTime dueDate,DateTime OrderDate)
        {
            this.item_ordered = item_ordered;
            this.dueDate = dueDate;
            this.OrderDate = OrderDate;
        }

        public void addOrder() {
            
            String query = String.Format("Insert into Order Values ('{0}',{1},{2})",item_ordered,new SqlDateTime(dueDate),new SqlDateTime(OrderDate));
            SqliteCommand cmd = Utilities.MakeCommand(query);
            cmd.ExecuteNonQuery();

        }
    }
}
