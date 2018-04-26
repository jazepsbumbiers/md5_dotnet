namespace md2_dotnet
{
    partial class frmInventory
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
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblFilterSalesDateTo = new System.Windows.Forms.Label();
            this.dtpFilterInventoryDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateFrom = new System.Windows.Forms.Label();
            this.dtpFilterInventoryDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dgdInventoryTable = new System.Windows.Forms.DataGridView();
            this.lblPriceOfItemsInventory = new System.Windows.Forms.Label();
            this.txtTotalPriceOfItemsInventory = new System.Windows.Forms.TextBox();
            this.btnFilterInventory = new System.Windows.Forms.Button();
            this.lblTotalPVNInventory = new System.Windows.Forms.Label();
            this.txtTotalPVNInventory = new System.Windows.Forms.TextBox();
            this.lblTotalPriceInventory = new System.Windows.Forms.Label();
            this.txtTotalPriceInventory = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountingBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryTable)).BeginInit();
            this.mnuMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(678, 403);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(115, 13);
            this.lblTotalItems.TabIndex = 16;
            this.lblTotalItems.Text = "Total items in inventory";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(799, 400);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(84, 20);
            this.txtTotalItems.TabIndex = 15;
            // 
            // lblFilterSalesDateTo
            // 
            this.lblFilterSalesDateTo.AutoSize = true;
            this.lblFilterSalesDateTo.Location = new System.Drawing.Point(255, 33);
            this.lblFilterSalesDateTo.Name = "lblFilterSalesDateTo";
            this.lblFilterSalesDateTo.Size = new System.Drawing.Size(44, 13);
            this.lblFilterSalesDateTo.TabIndex = 14;
            this.lblFilterSalesDateTo.Text = "To date";
            // 
            // dtpFilterInventoryDateTo
            // 
            this.dtpFilterInventoryDateTo.Location = new System.Drawing.Point(258, 49);
            this.dtpFilterInventoryDateTo.Name = "dtpFilterInventoryDateTo";
            this.dtpFilterInventoryDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterInventoryDateTo.TabIndex = 13;
            // 
            // lblFilterSalesDateFrom
            // 
            this.lblFilterSalesDateFrom.AutoSize = true;
            this.lblFilterSalesDateFrom.Location = new System.Drawing.Point(9, 33);
            this.lblFilterSalesDateFrom.Name = "lblFilterSalesDateFrom";
            this.lblFilterSalesDateFrom.Size = new System.Drawing.Size(54, 13);
            this.lblFilterSalesDateFrom.TabIndex = 12;
            this.lblFilterSalesDateFrom.Text = "From date";
            // 
            // dtpFilterInventoryDateFrom
            // 
            this.dtpFilterInventoryDateFrom.Location = new System.Drawing.Point(12, 49);
            this.dtpFilterInventoryDateFrom.Name = "dtpFilterInventoryDateFrom";
            this.dtpFilterInventoryDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterInventoryDateFrom.TabIndex = 11;
            // 
            // dgdInventoryTable
            // 
            this.dgdInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryTable.Location = new System.Drawing.Point(12, 87);
            this.dgdInventoryTable.Name = "dgdInventoryTable";
            this.dgdInventoryTable.Size = new System.Drawing.Size(873, 290);
            this.dgdInventoryTable.TabIndex = 10;
            // 
            // lblPriceOfItemsInventory
            // 
            this.lblPriceOfItemsInventory.AutoSize = true;
            this.lblPriceOfItemsInventory.Location = new System.Drawing.Point(449, 403);
            this.lblPriceOfItemsInventory.Name = "lblPriceOfItemsInventory";
            this.lblPriceOfItemsInventory.Size = new System.Drawing.Size(117, 13);
            this.lblPriceOfItemsInventory.TabIndex = 19;
            this.lblPriceOfItemsInventory.Text = "Price of items w/o PVN";
            // 
            // txtTotalPriceOfItemsInventory
            // 
            this.txtTotalPriceOfItemsInventory.Location = new System.Drawing.Point(572, 400);
            this.txtTotalPriceOfItemsInventory.Name = "txtTotalPriceOfItemsInventory";
            this.txtTotalPriceOfItemsInventory.ReadOnly = true;
            this.txtTotalPriceOfItemsInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceOfItemsInventory.TabIndex = 18;
            // 
            // btnFilterInventory
            // 
            this.btnFilterInventory.Location = new System.Drawing.Point(491, 49);
            this.btnFilterInventory.Name = "btnFilterInventory";
            this.btnFilterInventory.Size = new System.Drawing.Size(75, 20);
            this.btnFilterInventory.TabIndex = 20;
            this.btnFilterInventory.Text = "Filter";
            this.btnFilterInventory.UseVisualStyleBackColor = true;
            // 
            // lblTotalPVNInventory
            // 
            this.lblTotalPVNInventory.AutoSize = true;
            this.lblTotalPVNInventory.Location = new System.Drawing.Point(469, 433);
            this.lblTotalPVNInventory.Name = "lblTotalPVNInventory";
            this.lblTotalPVNInventory.Size = new System.Drawing.Size(85, 13);
            this.lblTotalPVNInventory.TabIndex = 22;
            this.lblTotalPVNInventory.Text = "Total PVN value";
            // 
            // txtTotalPVNInventory
            // 
            this.txtTotalPVNInventory.Location = new System.Drawing.Point(572, 430);
            this.txtTotalPVNInventory.Name = "txtTotalPVNInventory";
            this.txtTotalPVNInventory.ReadOnly = true;
            this.txtTotalPVNInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPVNInventory.TabIndex = 21;
            // 
            // lblTotalPriceInventory
            // 
            this.lblTotalPriceInventory.AutoSize = true;
            this.lblTotalPriceInventory.Location = new System.Drawing.Point(469, 462);
            this.lblTotalPriceInventory.Name = "lblTotalPriceInventory";
            this.lblTotalPriceInventory.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPriceInventory.TabIndex = 24;
            this.lblTotalPriceInventory.Text = "Total price of items";
            // 
            // txtTotalPriceInventory
            // 
            this.txtTotalPriceInventory.Location = new System.Drawing.Point(572, 459);
            this.txtTotalPriceInventory.Name = "txtTotalPriceInventory";
            this.txtTotalPriceInventory.ReadOnly = true;
            this.txtTotalPriceInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceInventory.TabIndex = 23;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 403);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(91, 36);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAccounting,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(897, 24);
            this.mnuMainMenuStrip.TabIndex = 26;
            this.mnuMainMenuStrip.Text = "mnuMainMenu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuAccounting
            // 
            this.mnuAccounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccountingBrowse});
            this.mnuAccounting.Name = "mnuAccounting";
            this.mnuAccounting.Size = new System.Drawing.Size(81, 20);
            this.mnuAccounting.Text = "Accounting";
            // 
            // mnuAccountingBrowse
            // 
            this.mnuAccountingBrowse.Name = "mnuAccountingBrowse";
            this.mnuAccountingBrowse.Size = new System.Drawing.Size(180, 22);
            this.mnuAccountingBrowse.Text = "Browse";
            this.mnuAccountingBrowse.Click += new System.EventHandler(this.mnuAccountingBrowse_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 494);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblTotalPriceInventory);
            this.Controls.Add(this.txtTotalPriceInventory);
            this.Controls.Add(this.lblTotalPVNInventory);
            this.Controls.Add(this.txtTotalPVNInventory);
            this.Controls.Add(this.btnFilterInventory);
            this.Controls.Add(this.lblPriceOfItemsInventory);
            this.Controls.Add(this.txtTotalPriceOfItemsInventory);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblFilterSalesDateTo);
            this.Controls.Add(this.dtpFilterInventoryDateTo);
            this.Controls.Add(this.lblFilterSalesDateFrom);
            this.Controls.Add(this.dtpFilterInventoryDateFrom);
            this.Controls.Add(this.dgdInventoryTable);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryTable)).EndInit();
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label lblFilterSalesDateTo;
        private System.Windows.Forms.DateTimePicker dtpFilterInventoryDateTo;
        private System.Windows.Forms.Label lblFilterSalesDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterInventoryDateFrom;
        private System.Windows.Forms.DataGridView dgdInventoryTable;
        private System.Windows.Forms.Label lblPriceOfItemsInventory;
        private System.Windows.Forms.TextBox txtTotalPriceOfItemsInventory;
        private System.Windows.Forms.Button btnFilterInventory;
        private System.Windows.Forms.Label lblTotalPVNInventory;
        private System.Windows.Forms.TextBox txtTotalPVNInventory;
        private System.Windows.Forms.Label lblTotalPriceInventory;
        private System.Windows.Forms.TextBox txtTotalPriceInventory;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAccounting;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountingBrowse;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}