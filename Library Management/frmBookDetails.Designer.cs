namespace Library_Management
{
    partial class frmBookDetails
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
            this.pcbBook = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDateOfAddition = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstbxAuthors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbxCategories = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBook
            // 
            this.pcbBook.Location = new System.Drawing.Point(12, 59);
            this.pcbBook.Name = "pcbBook";
            this.pcbBook.Size = new System.Drawing.Size(350, 280);
            this.pcbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBook.TabIndex = 0;
            this.pcbBook.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.Gold;
            this.lblBookName.Location = new System.Drawing.Point(12, 36);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(94, 18);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Book name";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageCount.ForeColor = System.Drawing.Color.Gold;
            this.lblPageCount.Location = new System.Drawing.Point(143, 363);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(95, 16);
            this.lblPageCount.TabIndex = 2;
            this.lblPageCount.Text = "Page Count: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.Color.Gold;
            this.lblStock.Location = new System.Drawing.Point(143, 413);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 16);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock: ";
            // 
            // lblDateOfAddition
            // 
            this.lblDateOfAddition.AutoSize = true;
            this.lblDateOfAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfAddition.ForeColor = System.Drawing.Color.Gold;
            this.lblDateOfAddition.Location = new System.Drawing.Point(143, 513);
            this.lblDateOfAddition.Name = "lblDateOfAddition";
            this.lblDateOfAddition.Size = new System.Drawing.Size(126, 16);
            this.lblDateOfAddition.TabIndex = 6;
            this.lblDateOfAddition.Text = "Date of Addition: ";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Gold;
            this.lblReleaseDate.Location = new System.Drawing.Point(143, 463);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(111, 16);
            this.lblReleaseDate.TabIndex = 5;
            this.lblReleaseDate.Text = "Release Date: ";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(602, 2);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 11;
            this.pcbCloseForm.TabStop = false;
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date of Addition: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Release Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Page Count: ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(11, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 1);
            this.label9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(11, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 1);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(11, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 1);
            this.label11.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(11, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(350, 1);
            this.label12.TabIndex = 23;
            // 
            // lstbxAuthors
            // 
            this.lstbxAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.lstbxAuthors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxAuthors.ForeColor = System.Drawing.Color.White;
            this.lstbxAuthors.FormattingEnabled = true;
            this.lstbxAuthors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstbxAuthors.ItemHeight = 18;
            this.lstbxAuthors.Location = new System.Drawing.Point(386, 57);
            this.lstbxAuthors.Name = "lstbxAuthors";
            this.lstbxAuthors.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbxAuthors.Size = new System.Drawing.Size(248, 110);
            this.lstbxAuthors.Sorted = true;
            this.lstbxAuthors.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(386, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(386, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Categories";
            // 
            // lstbxCategories
            // 
            this.lstbxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.lstbxCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxCategories.ForeColor = System.Drawing.Color.White;
            this.lstbxCategories.FormattingEnabled = true;
            this.lstbxCategories.ItemHeight = 18;
            this.lstbxCategories.Location = new System.Drawing.Point(386, 227);
            this.lstbxCategories.Name = "lstbxCategories";
            this.lstbxCategories.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbxCategories.Size = new System.Drawing.Size(248, 110);
            this.lstbxCategories.Sorted = true;
            this.lstbxCategories.TabIndex = 26;
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(644, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbxCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxAuthors);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.lblDateOfAddition);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pcbBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmBookDetails_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBookDetails_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookDetails_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbBook;
        private Label lblBookName;
        private Label lblPageCount;
        private Label lblStock;
        private Label lblDateOfAddition;
        private Label lblReleaseDate;
        private PictureBox pcbCloseForm;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox lstbxAuthors;
        private Label label1;
        private Label label2;
        private ListBox lstbxCategories;
    }
}