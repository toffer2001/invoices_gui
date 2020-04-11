using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices_GUI
{
    class Customer
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Customer(int id, string fName, string lName)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
        }
    }
}
