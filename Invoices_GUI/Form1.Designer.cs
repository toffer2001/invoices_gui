namespace Invoices_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioBtn_CustLastName = new System.Windows.Forms.RadioButton();
            this.radioBtn_CustID = new System.Windows.Forms.RadioButton();
            this.radioBtn_InvID = new System.Windows.Forms.RadioButton();
            this.radioBtn_InvCost = new System.Windows.Forms.RadioButton();
            this.richTextBoxLeft = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.radioBtn_Invoices = new System.Windows.Forms.RadioButton();
            this.radioBtn_InventorySold = new System.Windows.Forms.RadioButton();
            this.radioBtn_InvoicesByCustomer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBtn_CustLastName
            // 
            this.radioBtn_CustLastName.AutoSize = true;
            this.radioBtn_CustLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_CustLastName.Location = new System.Drawing.Point(93, 64);
            this.radioBtn_CustLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_CustLastName.Name = "radioBtn_CustLastName";
            this.radioBtn_CustLastName.Size = new System.Drawing.Size(188, 23);
            this.radioBtn_CustLastName.TabIndex = 0;
            this.radioBtn_CustLastName.TabStop = true;
            this.radioBtn_CustLastName.Text = "Customers by Last Name";
            this.radioBtn_CustLastName.UseVisualStyleBackColor = true;
            this.radioBtn_CustLastName.Click += new System.EventHandler(this.radioBtn_CustLastName_Click);
            // 
            // radioBtn_CustID
            // 
            this.radioBtn_CustID.AutoSize = true;
            this.radioBtn_CustID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_CustID.Location = new System.Drawing.Point(93, 94);
            this.radioBtn_CustID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_CustID.Name = "radioBtn_CustID";
            this.radioBtn_CustID.Size = new System.Drawing.Size(133, 23);
            this.radioBtn_CustID.TabIndex = 1;
            this.radioBtn_CustID.TabStop = true;
            this.radioBtn_CustID.Text = "Customers by ID";
            this.radioBtn_CustID.UseVisualStyleBackColor = true;
            this.radioBtn_CustID.Click += new System.EventHandler(this.radioBtn_CustID_Click);
            // 
            // radioBtn_InvID
            // 
            this.radioBtn_InvID.AutoSize = true;
            this.radioBtn_InvID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_InvID.Location = new System.Drawing.Point(93, 125);
            this.radioBtn_InvID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_InvID.Name = "radioBtn_InvID";
            this.radioBtn_InvID.Size = new System.Drawing.Size(124, 23);
            this.radioBtn_InvID.TabIndex = 2;
            this.radioBtn_InvID.TabStop = true;
            this.radioBtn_InvID.Text = "Inventory by ID";
            this.radioBtn_InvID.UseVisualStyleBackColor = true;
            this.radioBtn_InvID.Click += new System.EventHandler(this.radioBtn_InvID_Click);
            // 
            // radioBtn_InvCost
            // 
            this.radioBtn_InvCost.AutoSize = true;
            this.radioBtn_InvCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_InvCost.Location = new System.Drawing.Point(93, 155);
            this.radioBtn_InvCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_InvCost.Name = "radioBtn_InvCost";
            this.radioBtn_InvCost.Size = new System.Drawing.Size(139, 23);
            this.radioBtn_InvCost.TabIndex = 3;
            this.radioBtn_InvCost.TabStop = true;
            this.radioBtn_InvCost.Text = "Inventory by Cost";
            this.radioBtn_InvCost.UseVisualStyleBackColor = true;
            this.radioBtn_InvCost.Click += new System.EventHandler(this.radioBtn_InvCost_Click);
            // 
            // richTextBoxLeft
            // 
            this.richTextBoxLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLeft.Location = new System.Drawing.Point(28, 190);
            this.richTextBoxLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxLeft.Name = "richTextBoxLeft";
            this.richTextBoxLeft.Size = new System.Drawing.Size(435, 477);
            this.richTextBoxLeft.TabIndex = 4;
            this.richTextBoxLeft.Text = "";
            // 
            // richTextBoxRight
            // 
            this.richTextBoxRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRight.Location = new System.Drawing.Point(519, 76);
            this.richTextBoxRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxRight.Name = "richTextBoxRight";
            this.richTextBoxRight.Size = new System.Drawing.Size(527, 591);
            this.richTextBoxRight.TabIndex = 5;
            this.richTextBoxRight.Text = "";
            // 
            // radioBtn_Invoices
            // 
            this.radioBtn_Invoices.AutoSize = true;
            this.radioBtn_Invoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Invoices.Location = new System.Drawing.Point(561, 33);
            this.radioBtn_Invoices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_Invoices.Name = "radioBtn_Invoices";
            this.radioBtn_Invoices.Size = new System.Drawing.Size(80, 23);
            this.radioBtn_Invoices.TabIndex = 6;
            this.radioBtn_Invoices.TabStop = true;
            this.radioBtn_Invoices.Text = "Invoices";
            this.radioBtn_Invoices.UseVisualStyleBackColor = true;
            this.radioBtn_Invoices.Click += new System.EventHandler(this.radioBtn_Invoices_Click);
            // 
            // radioBtn_InventorySold
            // 
            this.radioBtn_InventorySold.AutoSize = true;
            this.radioBtn_InventorySold.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_InventorySold.Location = new System.Drawing.Point(685, 33);
            this.radioBtn_InventorySold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_InventorySold.Name = "radioBtn_InventorySold";
            this.radioBtn_InventorySold.Size = new System.Drawing.Size(118, 23);
            this.radioBtn_InventorySold.TabIndex = 7;
            this.radioBtn_InventorySold.TabStop = true;
            this.radioBtn_InventorySold.Text = "Inventory Sold";
            this.radioBtn_InventorySold.UseVisualStyleBackColor = true;
            this.radioBtn_InventorySold.Click += new System.EventHandler(this.radioBtn_InventorySold_Click);
            // 
            // radioBtn_InvoicesByCustomer
            // 
            this.radioBtn_InvoicesByCustomer.AutoSize = true;
            this.radioBtn_InvoicesByCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_InvoicesByCustomer.Location = new System.Drawing.Point(854, 33);
            this.radioBtn_InvoicesByCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtn_InvoicesByCustomer.Name = "radioBtn_InvoicesByCustomer";
            this.radioBtn_InvoicesByCustomer.Size = new System.Drawing.Size(165, 23);
            this.radioBtn_InvoicesByCustomer.TabIndex = 8;
            this.radioBtn_InvoicesByCustomer.TabStop = true;
            this.radioBtn_InvoicesByCustomer.Text = "Invoices by Customer";
            this.radioBtn_InvoicesByCustomer.UseVisualStyleBackColor = true;
            this.radioBtn_InvoicesByCustomer.Click += new System.EventHandler(this.radioBtn_InvoicesByCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.radioBtn_InvoicesByCustomer);
            this.Controls.Add(this.radioBtn_InventorySold);
            this.Controls.Add(this.radioBtn_Invoices);
            this.Controls.Add(this.richTextBoxRight);
            this.Controls.Add(this.richTextBoxLeft);
            this.Controls.Add(this.radioBtn_InvCost);
            this.Controls.Add(this.radioBtn_InvID);
            this.Controls.Add(this.radioBtn_CustID);
            this.Controls.Add(this.radioBtn_CustLastName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Final Project by Kristoffer Keene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_CustLastName;
        private System.Windows.Forms.RadioButton radioBtn_CustID;
        private System.Windows.Forms.RadioButton radioBtn_InvID;
        private System.Windows.Forms.RadioButton radioBtn_InvCost;
        private System.Windows.Forms.RichTextBox richTextBoxLeft;
        private System.Windows.Forms.RichTextBox richTextBoxRight;
        private System.Windows.Forms.RadioButton radioBtn_Invoices;
        private System.Windows.Forms.RadioButton radioBtn_InventorySold;
        private System.Windows.Forms.RadioButton radioBtn_InvoicesByCustomer;
    }
}

