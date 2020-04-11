using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices_GUI
{
    class Invoice
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public Date date { get; set; }

        public Invoice(int id, int customerId, int m, int d, int y)
        {
            ID = id;
            CustomerID = customerId;
            date = new Date(m, d, y);
        }
    }
}
