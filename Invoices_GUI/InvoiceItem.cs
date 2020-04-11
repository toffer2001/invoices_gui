using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices_GUI
{
    class InvoiceItem
    {
        public int InvoiceID { get; set; }

        public int LineNumber { get; set; }

        public int InventoryID { get; set; }

        public int QtySold { get; set; }

        public InvoiceItem(int invoiceId, int lineNumber, int inventoryId, int qty)
        {
            InvoiceID = invoiceId;
            LineNumber = lineNumber;
            InventoryID = inventoryId;
            QtySold = qty;
        }
    }
}
