namespace Program4
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
            this.origZipLbl = new System.Windows.Forms.Label();
            this.destZipLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.origZipBox = new System.Windows.Forms.TextBox();
            this.destZipBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.addPackageBtn = new System.Windows.Forms.Button();
            this.detailBtn = new System.Windows.Forms.Button();
            this.toLouisBtn = new System.Windows.Forms.Button();
            this.fromLouisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // origZipLbl
            // 
            this.origZipLbl.AutoSize = true;
            this.origZipLbl.Location = new System.Drawing.Point(12, 9);
            this.origZipLbl.Name = "origZipLbl";
            this.origZipLbl.Size = new System.Drawing.Size(47, 13);
            this.origZipLbl.TabIndex = 0;
            this.origZipLbl.Text = "Orig Zip:";
            // 
            // destZipLbl
            // 
            this.destZipLbl.AutoSize = true;
            this.destZipLbl.Location = new System.Drawing.Point(9, 35);
            this.destZipLbl.Name = "destZipLbl";
            this.destZipLbl.Size = new System.Drawing.Size(50, 13);
            this.destZipLbl.TabIndex = 1;
            this.destZipLbl.Text = "Dest Zip:";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(16, 61);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(43, 13);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Length:";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(21, 87);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(38, 13);
            this.widthLbl.TabIndex = 3;
            this.widthLbl.Text = "Width:";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(18, 113);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(41, 13);
            this.heightLbl.TabIndex = 4;
            this.heightLbl.Text = "Height:";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(15, 139);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(44, 13);
            this.weightLbl.TabIndex = 5;
            this.weightLbl.Text = "Weight:";
            // 
            // origZipBox
            // 
            this.origZipBox.Location = new System.Drawing.Point(65, 9);
            this.origZipBox.Name = "origZipBox";
            this.origZipBox.Size = new System.Drawing.Size(100, 20);
            this.origZipBox.TabIndex = 6;
            // 
            // destZipBox
            // 
            this.destZipBox.Location = new System.Drawing.Point(65, 35);
            this.destZipBox.Name = "destZipBox";
            this.destZipBox.Size = new System.Drawing.Size(100, 20);
            this.destZipBox.TabIndex = 7;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(65, 61);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 8;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(65, 87);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 9;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(65, 113);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 10;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(65, 139);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 11;
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(181, 5);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(169, 160);
            this.packageListBox.TabIndex = 12;
            // 
            // addPackageBtn
            // 
            this.addPackageBtn.Location = new System.Drawing.Point(19, 188);
            this.addPackageBtn.Name = "addPackageBtn";
            this.addPackageBtn.Size = new System.Drawing.Size(162, 23);
            this.addPackageBtn.TabIndex = 13;
            this.addPackageBtn.Text = "Add Ground Package";
            this.addPackageBtn.UseVisualStyleBackColor = true;
            this.addPackageBtn.Click += new System.EventHandler(this.addPackageBtn_Click);
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(390, 12);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(86, 36);
            this.detailBtn.TabIndex = 14;
            this.detailBtn.Text = "Details";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // toLouisBtn
            // 
            this.toLouisBtn.Location = new System.Drawing.Point(390, 61);
            this.toLouisBtn.Name = "toLouisBtn";
            this.toLouisBtn.Size = new System.Drawing.Size(86, 46);
            this.toLouisBtn.TabIndex = 15;
            this.toLouisBtn.Text = "Send to UofL";
            this.toLouisBtn.UseVisualStyleBackColor = true;
            this.toLouisBtn.Click += new System.EventHandler(this.toLouisBtn_Click);
            // 
            // fromLouisBtn
            // 
            this.fromLouisBtn.Location = new System.Drawing.Point(390, 124);
            this.fromLouisBtn.Name = "fromLouisBtn";
            this.fromLouisBtn.Size = new System.Drawing.Size(86, 48);
            this.fromLouisBtn.TabIndex = 16;
            this.fromLouisBtn.Text = "Send from UofL";
            this.fromLouisBtn.UseVisualStyleBackColor = true;
            this.fromLouisBtn.Click += new System.EventHandler(this.fromLouisBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addPackageBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 235);
            this.Controls.Add(this.fromLouisBtn);
            this.Controls.Add(this.toLouisBtn);
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.addPackageBtn);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.destZipBox);
            this.Controls.Add(this.origZipBox);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.destZipLbl);
            this.Controls.Add(this.origZipLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origZipLbl;
        private System.Windows.Forms.Label destZipLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox origZipBox;
        private System.Windows.Forms.TextBox destZipBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button addPackageBtn;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.Button toLouisBtn;
        private System.Windows.Forms.Button fromLouisBtn;
    }
}

