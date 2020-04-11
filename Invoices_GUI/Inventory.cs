using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices_GUI
{
    class Inventory
    {
        public int ID { get; set; }

        public string ItemName { get; set; }

        public double Cost { get; set; }

        public Inventory(int id, string name, double cost)
        {
            ID = id;
            ItemName = name;
            Cost = cost;
        }
    }
}
