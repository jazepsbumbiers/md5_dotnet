namespace md2_dotnet
{
    partial class frmAddItem
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
            this.components = new System.ComponentModel.Container();
            this.rtfItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.errEmptyFields = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCheckQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCheckPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCheckItemNo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckItemNo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfItemDescription
            // 
            this.rtfItemDescription.Location = new System.Drawing.Point(91, 162);
            this.rtfItemDescription.Name = "rtfItemDescription";
            this.rtfItemDescription.Size = new System.Drawing.Size(190, 91);
            this.rtfItemDescription.TabIndex = 74;
            this.rtfItemDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 186);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 73;
            this.lblDescription.Text = "Description";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(161, 367);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 31);
            this.btnAddItem.TabIndex = 70;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(25, 270);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 69;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(90, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(191, 20);
            this.txtQuantity.TabIndex = 68;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(82, 71);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(199, 21);
            this.cmbCategory.TabIndex = 61;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 74);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 60;
            this.lblCategory.Text = "Category";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(82, 29);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(199, 20);
            this.txtItemNo.TabIndex = 59;
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(25, 32);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(45, 13);
            this.lblItemNo.TabIndex = 58;
            this.lblItemNo.Text = "Item no.";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(82, 114);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 20);
            this.txtTitle.TabIndex = 76;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(25, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 313);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 78;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(91, 310);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 20);
            this.txtPrice.TabIndex = 77;
            // 
            // errEmptyFields
            // 
            this.errEmptyFields.ContainerControl = this;
            // 
            // errCheckQuantity
            // 
            this.errCheckQuantity.ContainerControl = this;
            // 
            // errCheckPrice
            // 
            this.errCheckPrice.ContainerControl = this;
            // 
            // errCheckItemNo
            // 
            this.errCheckItemNo.ContainerControl = this;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 433);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtfItemDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Name = "frmAddItem";
            this.Text = "Add inventory item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckItemNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfItemDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label lblItemNo;
        public System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ErrorProvider errEmptyFields;
        private System.Windows.Forms.ErrorProvider errCheckQuantity;
        private System.Windows.Forms.ErrorProvider errCheckPrice;
        private System.Windows.Forms.ErrorProvider errCheckItemNo;
    }
}