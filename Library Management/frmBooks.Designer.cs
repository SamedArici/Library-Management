namespace Library_Management
{
    partial class frmBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBooks = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.rbtnMyBooks = new System.Windows.Forms.RadioButton();
            this.pcbClearAuthors = new System.Windows.Forms.PictureBox();
            this.lstbxAuthors = new System.Windows.Forms.ListBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.pcbClearCategories = new System.Windows.Forms.PictureBox();
            this.rbtnOnlyOutOfStocks = new System.Windows.Forms.RadioButton();
            this.lstbxCategories = new System.Windows.Forms.ListBox();
            this.rbtnHideOutOfStocks = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooks)).BeginInit();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBooks
            // 
            this.dtgvBooks.AllowUserToAddRows = false;
            this.dtgvBooks.AllowUserToDeleteRows = false;
            this.dtgvBooks.AllowUserToResizeColumns = false;
            this.dtgvBooks.AllowUserToResizeRows = false;
            this.dtgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBooks.Location = new System.Drawing.Point(247, 30);
            this.dtgvBooks.MultiSelect = false;
            this.dtgvBooks.Name = "dtgvBooks";
            this.dtgvBooks.ReadOnly = true;
            this.dtgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBooks.RowTemplate.Height = 25;
            this.dtgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBooks.Size = new System.Drawing.Size(872, 579);
            this.dtgvBooks.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtgvBooks, "Double Click to Make Operations");
            this.dtgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBooks_CellDoubleClick);
            this.dtgvBooks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvBooks_CellMouseDown);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.rbtnMyBooks);
            this.gbxSearch.Controls.Add(this.pcbClearAuthors);
            this.gbxSearch.Controls.Add(this.lstbxAuthors);
            this.gbxSearch.Controls.Add(this.cmbAuthors);
            this.gbxSearch.Controls.Add(this.pcbClearCategories);
            this.gbxSearch.Controls.Add(this.rbtnOnlyOutOfStocks);
            this.gbxSearch.Controls.Add(this.lstbxCategories);
            this.gbxSearch.Controls.Add(this.rbtnHideOutOfStocks);
            this.gbxSearch.Controls.Add(this.rbtnAll);
            this.gbxSearch.Controls.Add(this.txtBookName);
            this.gbxSearch.Controls.Add(this.label3);
            this.gbxSearch.Controls.Add(this.cmbCategories);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxSearch.ForeColor = System.Drawing.Color.Gold;
            this.gbxSearch.Location = new System.Drawing.Point(12, 22);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(229, 587);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Books";
            // 
            // rbtnMyBooks
            // 
            this.rbtnMyBooks.AutoSize = true;
            this.rbtnMyBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMyBooks.Enabled = false;
            this.rbtnMyBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnMyBooks.ForeColor = System.Drawing.Color.Gold;
            this.rbtnMyBooks.Location = new System.Drawing.Point(17, 549);
            this.rbtnMyBooks.Name = "rbtnMyBooks";
            this.rbtnMyBooks.Size = new System.Drawing.Size(93, 20);
            this.rbtnMyBooks.TabIndex = 66;
            this.rbtnMyBooks.Text = "My Books";
            this.rbtnMyBooks.UseVisualStyleBackColor = true;
            this.rbtnMyBooks.CheckedChanged += new System.EventHandler(this.rbtnMyBooks_CheckedChanged);
            // 
            // pcbClearAuthors
            // 
            this.pcbClearAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClearAuthors.ImageLocation = "https://openclipart.org/image/2000px/310679";
            this.pcbClearAuthors.Location = new System.Drawing.Point(182, 170);
            this.pcbClearAuthors.Name = "pcbClearAuthors";
            this.pcbClearAuthors.Size = new System.Drawing.Size(29, 21);
            this.pcbClearAuthors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClearAuthors.TabIndex = 65;
            this.pcbClearAuthors.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClearAuthors, "Clear Selected Authors");
            this.pcbClearAuthors.Click += new System.EventHandler(this.pcbClearAuthors_Click);
            // 
            // lstbxAuthors
            // 
            this.lstbxAuthors.BackColor = System.Drawing.Color.White;
            this.lstbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxAuthors.ForeColor = System.Drawing.Color.Black;
            this.lstbxAuthors.FormattingEnabled = true;
            this.lstbxAuthors.ItemHeight = 16;
            this.lstbxAuthors.Location = new System.Drawing.Point(17, 170);
            this.lstbxAuthors.Name = "lstbxAuthors";
            this.lstbxAuthors.Size = new System.Drawing.Size(159, 100);
            this.lstbxAuthors.TabIndex = 64;
            this.toolTip1.SetToolTip(this.lstbxAuthors, "Double Click to Show Selected Author Infos");
            this.lstbxAuthors.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuthors.BackColor = System.Drawing.Color.White;
            this.cmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthors.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(17, 140);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(159, 24);
            this.cmbAuthors.TabIndex = 64;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // pcbClearCategories
            // 
            this.pcbClearCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClearCategories.ImageLocation = "https://openclipart.org/image/2000px/310679";
            this.pcbClearCategories.Location = new System.Drawing.Point(182, 353);
            this.pcbClearCategories.Name = "pcbClearCategories";
            this.pcbClearCategories.Size = new System.Drawing.Size(29, 21);
            this.pcbClearCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClearCategories.TabIndex = 7;
            this.pcbClearCategories.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClearCategories, "Clear Selected Categories");
            this.pcbClearCategories.Click += new System.EventHandler(this.pcbClearCategories_Click);
            // 
            // rbtnOnlyOutOfStocks
            // 
            this.rbtnOnlyOutOfStocks.AutoSize = true;
            this.rbtnOnlyOutOfStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnOnlyOutOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnOnlyOutOfStocks.Location = new System.Drawing.Point(17, 523);
            this.rbtnOnlyOutOfStocks.Name = "rbtnOnlyOutOfStocks";
            this.rbtnOnlyOutOfStocks.Size = new System.Drawing.Size(151, 20);
            this.rbtnOnlyOutOfStocks.TabIndex = 57;
            this.rbtnOnlyOutOfStocks.Text = "Only Out of Stocks";
            this.rbtnOnlyOutOfStocks.UseVisualStyleBackColor = true;
            this.rbtnOnlyOutOfStocks.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // lstbxCategories
            // 
            this.lstbxCategories.BackColor = System.Drawing.Color.White;
            this.lstbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxCategories.ForeColor = System.Drawing.Color.Black;
            this.lstbxCategories.FormattingEnabled = true;
            this.lstbxCategories.ItemHeight = 16;
            this.lstbxCategories.Location = new System.Drawing.Point(17, 353);
            this.lstbxCategories.Name = "lstbxCategories";
            this.lstbxCategories.Size = new System.Drawing.Size(159, 100);
            this.lstbxCategories.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lstbxCategories, "Click to Remove Selected Category");
            this.lstbxCategories.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // rbtnHideOutOfStocks
            // 
            this.rbtnHideOutOfStocks.AutoSize = true;
            this.rbtnHideOutOfStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnHideOutOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnHideOutOfStocks.Location = new System.Drawing.Point(17, 497);
            this.rbtnHideOutOfStocks.Name = "rbtnHideOutOfStocks";
            this.rbtnHideOutOfStocks.Size = new System.Drawing.Size(153, 20);
            this.rbtnHideOutOfStocks.TabIndex = 56;
            this.rbtnHideOutOfStocks.Text = "Hide Out of Stocks";
            this.rbtnHideOutOfStocks.UseVisualStyleBackColor = true;
            this.rbtnHideOutOfStocks.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnAll.Location = new System.Drawing.Point(17, 472);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(43, 20);
            this.rbtnAll.TabIndex = 55;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.White;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(17, 64);
            this.txtBookName.MaxLength = 50;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(159, 22);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categories:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategories.BackColor = System.Drawing.Color.White;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.ForeColor = System.Drawing.Color.Black;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(17, 323);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(159, 24);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book:";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(1087, 3);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 63;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close This Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1120, 610);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dtgvBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBorrowingBooks";
            this.Activated += new System.EventHandler(this.frmBorrowingBooks_Activated);
            this.Load += new System.EventHandler(this.frmBorrowingBooks_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBorrowingBooks_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBorrowingBooks_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooks)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvBooks;
        private GroupBox gbxSearch;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategories;
        private Label label3;
        private TextBox txtBookName;
        private ListBox lstbxCategories;
        private ToolTip toolTip1;
        private PictureBox pcbClearCategories;
        private RadioButton rbtnAll;
        private RadioButton rbtnHideOutOfStocks;
        private RadioButton rbtnOnlyOutOfStocks;
        private PictureBox pcbCloseForm;
        private ComboBox cmbAuthors;
        private ListBox lstbxAuthors;
        private PictureBox pcbClearAuthors;
        private RadioButton rbtnMyBooks;
    }
}