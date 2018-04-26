namespace md2_dotnet
{
    partial class frmAbout
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
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblHelAboutVersion1 = new System.Windows.Forms.Label();
            this.lblAboutTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAboutTitle.TabIndex = 0;
            this.lblAboutTitle.Text = "Title:";
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.AutoSize = true;
            this.lblAboutVersion.Location = new System.Drawing.Point(12, 37);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(45, 13);
            this.lblAboutVersion.TabIndex = 1;
            this.lblAboutVersion.Text = "Version:";
            // 
            // lblHelAboutVersion1
            // 
            this.lblHelAboutVersion1.AutoSize = true;
            this.lblHelAboutVersion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelAboutVersion1.Location = new System.Drawing.Point(63, 37);
            this.lblHelAboutVersion1.Name = "lblHelAboutVersion1";
            this.lblHelAboutVersion1.Size = new System.Drawing.Size(25, 13);
            this.lblHelAboutVersion1.TabIndex = 3;
            this.lblHelAboutVersion1.Text = "0.1";
            // 
            // lblAboutTitle2
            // 
            this.lblAboutTitle2.AutoSize = true;
            this.lblAboutTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTitle2.Location = new System.Drawing.Point(58, 9);
            this.lblAboutTitle2.Name = "lblAboutTitle2";
            this.lblAboutTitle2.Size = new System.Drawing.Size(164, 13);
            this.lblAboutTitle2.TabIndex = 4;
            this.lblAboutTitle2.Text = "Pizza accounting, inventory";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 190);
            this.Controls.Add(this.lblAboutTitle2);
            this.Controls.Add(this.lblHelAboutVersion1);
            this.Controls.Add(this.lblAboutVersion);
            this.Controls.Add(this.lblAboutTitle);
            this.Name = "frmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.Label lblHelAboutVersion1;
        private System.Windows.Forms.Label lblAboutTitle2;
    }
}