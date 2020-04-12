using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices_GUI
{
    public partial class Form1 : Form
    {

        private long n1 = 0; // first fibonacci number
        private long n2 = 1; // second fibonacci number
        private long temp = 0;
        string resultText = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Inventory data with inventory item ID, inventory item name, and cost
        List<Inventory> inventoryList = new List<Inventory>()
        {
            new Inventory(1234, "blue ink pen", 1.19),
            new Inventory(1235, "black ink pen", 1.19),
            new Inventory(1236, "red ink pen", 1.19),
            new Inventory(2134, "blue pencil", .79),
            new Inventory(2135, "black pencil", .79),
            new Inventory(2136, "red pencil", .79),
            new Inventory(3124, "large eraser", 2.59),
            new Inventory(3125, "medium eraser", 1.59),
            new Inventory(3126, "cap eraser", .89),
            new Inventory(6233, "clear pushpins", 7.50),
            new Inventory(6234, "white pushpins", 7.50),
            new Inventory(6235, "green pushpins", 7.50),
            new Inventory(6236, "red pushpins", 7.50),
            new Inventory(6237, "blue pushpins", 7.50),
            new Inventory(6238, "yellow pushpins", 7.50),
            new Inventory(6239, "mixed pushpins", 7.50),
            new Inventory(5671, "small stapler", 4.25),
            new Inventory(5789, "stand stapler", 4.50),
            new Inventory(5312, "small staples", 1.25),
            new Inventory(5313, "large staples", 3.75)
         };


        // Customer data with customer ID, first name, and last name
        List<Customer> customers = new List<Customer>()
        {
            new Customer(876, "Mary", "Johnson"),
            new Customer(490, "Larry", "Brooks"),
            new Customer(552, "Ann", "Masters"),
            new Customer(923, "Frank", "Jones"),
            new Customer(259, "Gary", "Martin")
        };


        // Invoice data with invoice ID, customer ID, and a date(mm, dd, yyyy)
        List<Invoice> invoices = new List<Invoice>()
        {
            new Invoice(22, 876, 5, 2, 2019),
            new Invoice(25, 876, 5, 3, 2019),
            new Invoice(26, 259, 5, 4, 2019),
            new Invoice(27, 490, 2, 28, 2018),
            new Invoice(28, 923, 3, 15, 2018),
            new Invoice(30, 552, 8, 10, 2018)
         };


        // Invoice Line Items data with invoice ID, line item number, inventory item ID, and quantity sold
        List<InvoiceItem> lineItems = new List<InvoiceItem>() {
            new InvoiceItem(22, 1, 1234, 5),
            new InvoiceItem(22, 2, 1235, 5),
            new InvoiceItem(22, 3, 1236, 5),
            new InvoiceItem(22, 4, 6233, 5),
            new InvoiceItem(22, 5, 6239, 5),

            new InvoiceItem(25, 1, 5671, 1),
            new InvoiceItem(25, 2, 5312, 2),
            new InvoiceItem(25, 3, 2135, 2),
            new InvoiceItem(25, 4, 6239, 2),

            new InvoiceItem(30, 1, 2135, 10),
            new InvoiceItem(30, 2, 2136, 10),
            new InvoiceItem(30, 3, 1234, 10),
            new InvoiceItem(30, 4, 1235, 10),
            new InvoiceItem(30, 5, 6239, 10),

            new InvoiceItem(26, 1, 5789, 5),
            new InvoiceItem(26, 2, 5671, 3),
            new InvoiceItem(26, 3, 5312, 5),
            new InvoiceItem(26, 4, 5313, 2),
            new InvoiceItem(26, 5, 6239, 2),

            new InvoiceItem(27, 1, 3124, 4),
            new InvoiceItem(27, 2, 3125, 4),
            new InvoiceItem(27, 3, 2135, 4),
            new InvoiceItem(27, 4, 6239, 4),

            new InvoiceItem(28, 1, 6234, 4),
            new InvoiceItem(28, 2, 6235, 4),
            new InvoiceItem(28, 3, 6236, 4),
            new InvoiceItem(28, 4, 6237, 4),
            new InvoiceItem(28, 5, 6239, 4),
            new InvoiceItem(28, 6, 6238, 4)
            };


        // Customers by Last Name
        private void radioBtn_CustLastName_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Text = "";

            var customerListByLastName =
                from customer in customers
                orderby customer.LastName
                select customer;

            foreach (var customer in customerListByLastName)
            {
                richTextBoxLeft.Text += ($"{customer.ID}  {customer.LastName}, {customer.FirstName}\n");
            }
        }

        // Customers by ID
        private void radioBtn_CustID_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Text = "";

            var customerListByID =
            from customerId in customers
            orderby customerId.ID
            select customerId;

            foreach (var customerId in customerListByID)
            {
                richTextBoxLeft.Text += ($"{customerId.ID}  {customerId.LastName}, {customerId.FirstName}\n");
            }
        }

        // Inventory by ID
        private void radioBtn_InvID_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Text = "";

            var InventoryListByID =
            from inventory in inventoryList
            orderby inventory.ID
            select inventory;

            foreach (var inventory in InventoryListByID)
            {
                richTextBoxLeft.Text += ($"{inventory.ID}\t{inventory.ItemName}\t{inventory.Cost:C}\n");
            }
        }

        // Inventory by Cost
        private void radioBtn_InvCost_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Text = "";

            var InventoryListByCost =
            from inventoryCost in inventoryList
            orderby inventoryCost.Cost
            select inventoryCost;

            foreach (var inventoryCost in InventoryListByCost)
            {
                richTextBoxLeft.Text += ($"{inventoryCost.Cost:C}\t{inventoryCost.ID}\t{inventoryCost.ItemName}\n");
            }
        }

        // Invoices
        private void radioBtn_Invoices_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Text = "";

            var invoiceList =
                from invoice in invoices
                join customer in customers
                on invoice.CustomerID equals customer.ID
                join lineItem in lineItems
                on invoice.ID equals lineItem.InvoiceID
                join inventory in inventoryList
                on lineItem.InventoryID equals inventory.ID
                let itemCost = lineItem.QtySold * inventory.Cost
                //select new { invoice.ID, invoice.CustomerID, customer.FirstName, customer.LastName, invoice.date, lineItem.QtySold, inventory.ItemName, inventory.Cost };
                group new { invoice.ID, invoice.CustomerID, customer.FirstName, customer.LastName, invoice.date, lineItem.QtySold, inventory.ItemName, inventory.Cost, itemCost } by invoice.ID into invoiceCustomerList
                orderby invoiceCustomerList.Key
                select invoiceCustomerList;

            double customerTotal = 0;
            double grandTotal = 0;
            int lineItemRowNumber = 1;

            richTextBoxRight.Text += ($"Invoices\n");

            resultText = richTextBoxRight.Text;

            foreach (var invoice in invoiceList)
            {
                //richTextBoxRight.Text += ($"\nKey {invoice.Key}");
                var customer = invoice.Last();

                //richTextBoxRight.Text += ($"\nInvoice {customer.ID}");
                //richTextBoxRight.Text += ($"\nCustomer {customer.CustomerID}  {customer.FirstName} {customer.LastName} \t\t Date {customer.date}");
                resultText += ($"\nInvoice {customer.ID}");
                resultText += ($"\nCustomer {customer.CustomerID}  {customer.FirstName} {customer.LastName} \t\t Date {customer.date}");

                foreach (var item in invoice)
                    {
                        //richTextBoxRight.Text += ($"\n{lineItemRowNumber} {item.ItemName}           \t@ {item.Cost:C} \t qty sold {item.QtySold} \t cost {item.itemCost:C}");
                        resultText += ($"\n{lineItemRowNumber} {item.ItemName}");
                        customerTotal += item.itemCost;
                        lineItemRowNumber++;
                    }

                    //richTextBoxRight.Text += ($"\nTotal for invoice: {customerTotal:C}\n");
                    resultText += ($"\nTotal for invoice: {customerTotal:C}\n");
                    grandTotal += customerTotal;
                    customerTotal = 0; // reset customer total to 0
                    lineItemRowNumber = 1; // reset row to 1
                
            }
            //richTextBoxRight.Text += ($"\nGRAND TOTAL for ALL invoices: {grandTotal:C}\n");
            resultText += ($"\nGRAND TOTAL for ALL invoices: {grandTotal:C}\n");

            // calling asynchronous fibonacci method to show won't delay other requests
            calculateRecursiveBtn_Click(resultText);

            /*
            foreach (var thisOne in invoiceList)
            {
                richTextBoxRight.Text += ($"\nKey {thisOne.Key}");
                foreach (var invoice in thisOne)
                {
                    richTextBoxRight.Text += ($"\nInvoice {invoice.ID}");
                    richTextBoxRight.Text += ($"\nCustomer {invoice.CustomerID}  {invoice.FirstName} {invoice.LastName} \t\t Date {invoice.date}");
                    foreach (var item in thisOne)
                    {
                        richTextBoxRight.Text += ($"\n{lineItemRowNumber} {item.ItemName}         \t@ {item.Cost:C} \t qty sold {item.QtySold} \t cost {item.itemCost:C}");
                        customerTotal += item.itemCost;
                        lineItemRowNumber++;
                    }
                    richTextBoxRight.Text += ($"\nTotal for invoice: {customerTotal:C}\n");
                    lineItemRowNumber = 1; // reset row to 1
                }
            }
            */
        }

        // Inventory Sold
        private void radioBtn_InventorySold_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Text = "";

            var invList =
                from inventory in inventoryList
                join lineItem in lineItems
                on inventory.ID equals lineItem.InventoryID
                let itemCost = lineItem.QtySold * inventory.Cost
                //select new { invoice.ID, invoice.CustomerID, customer.FirstName, customer.LastName, invoice.date, lineItem.QtySold, inventory.ItemName, inventory.Cost };
                group new { lineItem.InvoiceID, lineItem.QtySold, inventory.ItemName, inventory.Cost, itemCost } by inventory.ID into inventoryChangesList
                orderby inventoryChangesList.Key
                select inventoryChangesList;

            double invSoldTotal = 0;
            double invSoldGrandTotal = 0;

            richTextBoxRight.Text += ($"Inventory Changes\n");

            resultText = richTextBoxRight.Text;



            foreach (var invItem in invList)
            {
                //richTextBoxRight.Text += ($"\nInventory Item: {invItem.Key}");
                resultText += ($"\nInventory Item: {invItem.Key}");

                foreach (var invoice in invItem)
                {
                    //richTextBoxRight.Text += ($"\n    Invoice {invoice.InvoiceID}   sold {invoice.QtySold}\t cost {invoice.itemCost:C}");
                    resultText += ($"\n    Invoice {invoice.InvoiceID}   sold {invoice.QtySold}\t cost {invoice.itemCost:C}");
                    invSoldTotal += invoice.itemCost;
                }
                invSoldGrandTotal += invSoldTotal;
                //richTextBoxRight.Text += ($"\n    Total sold: {invSoldTotal:C}\n");
                resultText += ($"\n    Total sold: {invSoldTotal:C}\n");
                invSoldTotal = 0; // reset to 0
            }
            //richTextBoxRight.Text += ($"\nGRAND TOTAL SOLD: {invSoldGrandTotal:C}");
            resultText += ($"\nGRAND TOTAL SOLD: {invSoldGrandTotal:C}");

            // calling asynchronous fibonacci method to show won't delay other requests
            calculateRecursiveBtn_Click(resultText);
        }

        // Invoices by Customer
        private void radioBtn_InvoicesByCustomer_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Text = "";

            var custList =
                from customer in customers
                join invoice in invoices
                on customer.ID equals invoice.CustomerID
                join lineItem in lineItems
                on invoice.ID equals lineItem.InvoiceID
                join inventory in inventoryList
                on lineItem.InventoryID equals inventory.ID
                let itemCost = lineItem.QtySold * inventory.Cost
                //select new { invoice.ID, invoice.CustomerID, customer.FirstName, customer.LastName, invoice.date, lineItem.QtySold, inventory.ItemName, inventory.Cost };
                group new { invoice.ID, invoice.CustomerID, customer.FirstName, customer.LastName, invoice.date, lineItem.QtySold, inventory.ItemName, inventory.Cost, itemCost } by customer.ID into customerInvoiceList
                orderby customerInvoiceList.Key
                select customerInvoiceList;

            double invoiceTotal = 0;
            double grandTotal = 0;

            richTextBoxRight.Text += ($"Invoices Sorted by Customer\n");



            resultText = richTextBoxRight.Text;

            foreach (var cust in custList)
            {
                //richTextBoxRight.Text += ($"\nCustomer {cust.Key}");
                resultText += ($"\nCustomer {cust.Key}");

                int invoiceID = 0;
                
                foreach (var invoice in cust)
                {
                   invoiceID = invoice.ID;
                   invoiceTotal += invoice.itemCost;
                }

                //richTextBoxRight.Text += ($"\n    Invoice {invoiceID}  Total {invoiceTotal:C}\n");
                resultText += ($"\n    Invoice {invoiceID}  Total {invoiceTotal:C}\n");

                grandTotal += invoiceTotal;
                invoiceTotal = 0; // reset invoice total to 0
            }
            //richTextBoxRight.Text += ($"\nTotal \t {grandTotal:C}\n");
            resultText += ($"\nTotal \t {grandTotal:C}\n");

            // calling asynchronous fibonacci method to show won't delay other requests
            calculateRecursiveBtn_Click(resultText);
        }

        // asynchronous fibonacci method with hardcoded 40th number
        private async void calculateRecursiveBtn_Click(string text)
        {
            long userNumber = 40; //long.Parse(fibInputNumbers.Text);
            long result = 0;
            DateTime startTime, endTime;
            double seconds;

            // calculate duration of time to complete method
            startTime = DateTime.Now;

            //recursiveResultBox.Text = "Calculating...";

            // syncronous flow
            //result = Fibonacci(userNumber);

            // async improvement
            Task<long> calculateTask = Task.Run(() => Fibonacci(userNumber));
            richTextBoxRight.Text += ($"\nCalculating\n");
            await calculateTask;
            richTextBoxRight.Text = ($"{text}");

            result = calculateTask.Result;

            endTime = DateTime.Now;

            seconds = (endTime - startTime).TotalSeconds;

            // display results
            //recursiveResultBox.Text = result.ToString();

            //timeResultBox.Text = seconds.ToString();
        }

        private void calcIterativelyBtn_Click(object sender, EventArgs e)
        {
            temp = n1 + n2;
            n1 = n2;
            n2 = temp;

            //nextNumberBox.Text = n2.ToString();
        }

        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
