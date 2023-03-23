namespace Cosmos_Playground
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
            this.Import = new System.Windows.Forms.Button();
            this.Cheaper = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.Button();
            this.ByName = new System.Windows.Forms.Button();
            this.TxtCheaper = new System.Windows.Forms.TextBox();
            this.TxtOrderID = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Import.Location = new System.Drawing.Point(67, 42);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(320, 29);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import Products From Northwind";
            this.Import.UseVisualStyleBackColor = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Cheaper
            // 
            this.Cheaper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cheaper.Location = new System.Drawing.Point(67, 104);
            this.Cheaper.Name = "Cheaper";
            this.Cheaper.Size = new System.Drawing.Size(234, 29);
            this.Cheaper.TabIndex = 1;
            this.Cheaper.Text = "Select Products That Cheaper Then";
            this.Cheaper.UseVisualStyleBackColor = false;
            this.Cheaper.Click += new System.EventHandler(this.Cheaper_Click);
            // 
            // OrderID
            // 
            this.OrderID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OrderID.Location = new System.Drawing.Point(67, 167);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(234, 29);
            this.OrderID.TabIndex = 2;
            this.OrderID.Text = "Select Products For Supplier ID";
            this.OrderID.UseVisualStyleBackColor = false;
            this.OrderID.Click += new System.EventHandler(this.OrderID_Click);
            // 
            // ByName
            // 
            this.ByName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ByName.Location = new System.Drawing.Point(67, 231);
            this.ByName.Name = "ByName";
            this.ByName.Size = new System.Drawing.Size(234, 29);
            this.ByName.TabIndex = 3;
            this.ByName.Text = "Select Products Whos Name Starts With";
            this.ByName.UseVisualStyleBackColor = false;
            // 
            // TxtCheaper
            // 
            this.TxtCheaper.Location = new System.Drawing.Point(341, 107);
            this.TxtCheaper.Name = "TxtCheaper";
            this.TxtCheaper.Size = new System.Drawing.Size(80, 22);
            this.TxtCheaper.TabIndex = 4;
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Location = new System.Drawing.Point(341, 170);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(80, 22);
            this.TxtOrderID.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(341, 234);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(80, 22);
            this.TxtName.TabIndex = 6;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(445, 69);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(282, 326);
            this.TxtResult.TabIndex = 7;
            this.TxtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtOrderID);
            this.Controls.Add(this.TxtCheaper);
            this.Controls.Add(this.ByName);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.Cheaper);
            this.Controls.Add(this.Import);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Cheaper;
        private System.Windows.Forms.Button OrderID;
        private System.Windows.Forms.Button ByName;
        private System.Windows.Forms.TextBox TxtCheaper;
        private System.Windows.Forms.TextBox TxtOrderID;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.RichTextBox TxtResult;
    }
}

