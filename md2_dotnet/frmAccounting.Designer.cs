namespace md2_dotnet
{
    partial class frmAccounting
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
            this.dtpFilterSalesDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateFrom = new System.Windows.Forms.Label();
            this.dtpFilterSalesDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateTo = new System.Windows.Forms.Label();
            this.txtTotalDayRevenue = new System.Windows.Forms.TextBox();
            this.lblTotalDayRevenue = new System.Windows.Forms.Label();
            this.btnFilterAccounting = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPVN = new System.Windows.Forms.Label();
            this.txtTotalPVN = new System.Windows.Forms.TextBox();
            this.lblPriceOfItems = new System.Windows.Forms.Label();
            this.txtTotalPriceOfItems = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgdAccountingTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAccountingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFilterSalesDateFrom
            // 
            this.dtpFilterSalesDateFrom.Location = new System.Drawing.Point(11, 25);
            this.dtpFilterSalesDateFrom.Name = "dtpFilterSalesDateFrom";
            this.dtpFilterSalesDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterSalesDateFrom.TabIndex = 2;
            // 
            // lblFilterSalesDateFrom
            // 
            this.lblFilterSalesDateFrom.AutoSize = true;
            this.lblFilterSalesDateFrom.Location = new System.Drawing.Point(8, 9);
            this.lblFilterSalesDateFrom.Name = "lblFilterSalesDateFrom";
            this.lblFilterSalesDateFrom.Size = new System.Drawing.Size(54, 13);
            this.lblFilterSalesDateFrom.TabIndex = 3;
            this.lblFilterSalesDateFrom.Text = "From date";
            // 
            // dtpFilterSalesDateTo
            // 
            this.dtpFilterSalesDateTo.Location = new System.Drawing.Point(257, 25);
            this.dtpFilterSalesDateTo.Name = "dtpFilterSalesDateTo";
            this.dtpFilterSalesDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterSalesDateTo.TabIndex = 4;
            // 
            // lblFilterSalesDateTo
            // 
            this.lblFilterSalesDateTo.AutoSize = true;
            this.lblFilterSalesDateTo.Location = new System.Drawing.Point(254, 9);
            this.lblFilterSalesDateTo.Name = "lblFilterSalesDateTo";
            this.lblFilterSalesDateTo.Size = new System.Drawing.Size(44, 13);
            this.lblFilterSalesDateTo.TabIndex = 5;
            this.lblFilterSalesDateTo.Text = "To date";
            // 
            // txtTotalDayRevenue
            // 
            this.txtTotalDayRevenue.Location = new System.Drawing.Point(656, 351);
            this.txtTotalDayRevenue.Name = "txtTotalDayRevenue";
            this.txtTotalDayRevenue.ReadOnly = true;
            this.txtTotalDayRevenue.Size = new System.Drawing.Size(82, 20);
            this.txtTotalDayRevenue.TabIndex = 6;
            // 
            // lblTotalDayRevenue
            // 
            this.lblTotalDayRevenue.AutoSize = true;
            this.lblTotalDayRevenue.Location = new System.Drawing.Point(580, 355);
            this.lblTotalDayRevenue.Name = "lblTotalDayRevenue";
            this.lblTotalDayRevenue.Size = new System.Drawing.Size(75, 13);
            this.lblTotalDayRevenue.TabIndex = 7;
            this.lblTotalDayRevenue.Text = "Day\'s revenue";
            // 
            // btnFilterAccounting
            // 
            this.btnFilterAccounting.Location = new System.Drawing.Point(488, 25);
            this.btnFilterAccounting.Name = "btnFilterAccounting";
            this.btnFilterAccounting.Size = new System.Drawing.Size(70, 20);
            this.btnFilterAccounting.TabIndex = 9;
            this.btnFilterAccounting.Text = "Filter";
            this.btnFilterAccounting.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(371, 415);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPrice.TabIndex = 28;
            this.lblTotalPrice.Text = "Total price of items";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(474, 412);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPrice.TabIndex = 27;
            // 
            // lblTotalPVN
            // 
            this.lblTotalPVN.AutoSize = true;
            this.lblTotalPVN.Location = new System.Drawing.Point(382, 386);
            this.lblTotalPVN.Name = "lblTotalPVN";
            this.lblTotalPVN.Size = new System.Drawing.Size(85, 13);
            this.lblTotalPVN.TabIndex = 26;
            this.lblTotalPVN.Text = "Total PVN value";
            // 
            // txtTotalPVN
            // 
            this.txtTotalPVN.Location = new System.Drawing.Point(474, 383);
            this.txtTotalPVN.Name = "txtTotalPVN";
            this.txtTotalPVN.ReadOnly = true;
            this.txtTotalPVN.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPVN.TabIndex = 25;
            // 
            // lblPriceOfItems
            // 
            this.lblPriceOfItems.AutoSize = true;
            this.lblPriceOfItems.Location = new System.Drawing.Point(350, 355);
            this.lblPriceOfItems.Name = "lblPriceOfItems";
            this.lblPriceOfItems.Size = new System.Drawing.Size(117, 13);
            this.lblPriceOfItems.TabIndex = 30;
            this.lblPriceOfItems.Text = "Price of items w/o PVN";
            // 
            // txtTotalPriceOfItems
            // 
            this.txtTotalPriceOfItems.Location = new System.Drawing.Point(474, 351);
            this.txtTotalPriceOfItems.Name = "txtTotalPriceOfItems";
            this.txtTotalPriceOfItems.ReadOnly = true;
            this.txtTotalPriceOfItems.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceOfItems.TabIndex = 29;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(12, 357);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(110, 43);
            this.btnAddOrder.TabIndex = 31;
            this.btnAddOrder.Text = "Add new order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgdAccountingTable
            // 
            this.dgdAccountingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAccountingTable.Location = new System.Drawing.Point(11, 61);
            this.dgdAccountingTable.Name = "dgdAccountingTable";
            this.dgdAccountingTable.Size = new System.Drawing.Size(727, 264);
            this.dgdAccountingTable.TabIndex = 1;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblPriceOfItems);
            this.Controls.Add(this.txtTotalPriceOfItems);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPVN);
            this.Controls.Add(this.txtTotalPVN);
            this.Controls.Add(this.btnFilterAccounting);
            this.Controls.Add(this.lblTotalDayRevenue);
            this.Controls.Add(this.txtTotalDayRevenue);
            this.Controls.Add(this.lblFilterSalesDateTo);
            this.Controls.Add(this.dtpFilterSalesDateTo);
            this.Controls.Add(this.lblFilterSalesDateFrom);
            this.Controls.Add(this.dtpFilterSalesDateFrom);
            this.Controls.Add(this.dgdAccountingTable);
            this.Name = "frmAccounting";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.frmAccounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdAccountingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFilterSalesDateFrom;
        private System.Windows.Forms.Label lblFilterSalesDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterSalesDateTo;
        private System.Windows.Forms.Label lblFilterSalesDateTo;
        private System.Windows.Forms.TextBox txtTotalDayRevenue;
        private System.Windows.Forms.Label lblTotalDayRevenue;
        private System.Windows.Forms.Button btnFilterAccounting;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPVN;
        private System.Windows.Forms.TextBox txtTotalPVN;
        private System.Windows.Forms.Label lblPriceOfItems;
        private System.Windows.Forms.TextBox txtTotalPriceOfItems;
        private System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.DataGridView dgdAccountingTable;
    }
}

