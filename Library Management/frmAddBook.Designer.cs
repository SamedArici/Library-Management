namespace Library_Management
{
    partial class frmAddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.mtxtReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbAddNewAuthor = new System.Windows.Forms.PictureBox();
            this.pcbAddNewCategory = new System.Windows.Forms.PictureBox();
            this.pcbClear = new System.Windows.Forms.PictureBox();
            this.lstbxAuthors = new System.Windows.Forms.ListBox();
            this.lstbxCategories = new System.Windows.Forms.ListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(478, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(414, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Release Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(474, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Image:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Categories:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(54, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Authors:";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(709, 2);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 12;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close This Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // txtBook
            // 
            this.txtBook.BackColor = System.Drawing.Color.White;
            this.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBook.ForeColor = System.Drawing.Color.Black;
            this.txtBook.Location = new System.Drawing.Point(137, 65);
            this.txtBook.MaxLength = 50;
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(166, 22);
            this.txtBook.TabIndex = 1;
            // 
            // mtxtReleaseDate
            // 
            this.mtxtReleaseDate.BackColor = System.Drawing.Color.White;
            this.mtxtReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.mtxtReleaseDate.Location = new System.Drawing.Point(544, 118);
            this.mtxtReleaseDate.Mask = "00/00/0000";
            this.mtxtReleaseDate.Name = "mtxtReleaseDate";
            this.mtxtReleaseDate.Size = new System.Drawing.Size(166, 22);
            this.mtxtReleaseDate.TabIndex = 5;
            this.mtxtReleaseDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategories.BackColor = System.Drawing.Color.White;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.ForeColor = System.Drawing.Color.Black;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(137, 263);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 24);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged_1);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuthors.BackColor = System.Drawing.Color.White;
            this.cmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthors.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(137, 113);
            this.cmbAuthors.MaxLength = 50;
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(166, 24);
            this.cmbAuthors.TabIndex = 2;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(544, 219);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(166, 30);
            this.btnChooseImage.TabIndex = 7;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.White;
            this.pcbImage.ImageLocation = "https://i.pinimg.com/originals/dd/eb/23/ddeb23e067d822d84d50cca6fa04044f.png";
            this.pcbImage.Location = new System.Drawing.Point(544, 263);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(167, 124);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 56;
            this.pcbImage.TabStop = false;
            // 
            // pcbAddNewAuthor
            // 
            this.pcbAddNewAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAddNewAuthor.ImageLocation = "https://icons-for-free.com/iconfiles/png/512/user+add+new+plus+icon-1320196240269" +
    "097543.png";
            this.pcbAddNewAuthor.Location = new System.Drawing.Point(309, 113);
            this.pcbAddNewAuthor.Name = "pcbAddNewAuthor";
            this.pcbAddNewAuthor.Size = new System.Drawing.Size(28, 24);
            this.pcbAddNewAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAddNewAuthor.TabIndex = 59;
            this.pcbAddNewAuthor.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbAddNewAuthor, "Add a New Author");
            this.pcbAddNewAuthor.Click += new System.EventHandler(this.pcbAddNewAuthor_Click);
            // 
            // pcbAddNewCategory
            // 
            this.pcbAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAddNewCategory.ImageLocation = "https://cdn2.iconfinder.com/data/icons/multimedia-sound-8/48/Add_category-_playli" +
    "st-512.png";
            this.pcbAddNewCategory.Location = new System.Drawing.Point(309, 263);
            this.pcbAddNewCategory.Name = "pcbAddNewCategory";
            this.pcbAddNewCategory.Size = new System.Drawing.Size(28, 24);
            this.pcbAddNewCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAddNewCategory.TabIndex = 60;
            this.pcbAddNewCategory.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbAddNewCategory, "Add a New Category");
            this.pcbAddNewCategory.Click += new System.EventHandler(this.pcbAddNewCategory_Click);
            // 
            // pcbClear
            // 
            this.pcbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClear.ImageLocation = "https://icon-library.com/images/0e2609429e.png";
            this.pcbClear.Location = new System.Drawing.Point(513, 432);
            this.pcbClear.Name = "pcbClear";
            this.pcbClear.Size = new System.Drawing.Size(30, 27);
            this.pcbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClear.TabIndex = 61;
            this.pcbClear.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClear, "Clear All Texts");
            this.pcbClear.Click += new System.EventHandler(this.pcbClear_Click);
            // 
            // lstbxAuthors
            // 
            this.lstbxAuthors.BackColor = System.Drawing.Color.White;
            this.lstbxAuthors.ForeColor = System.Drawing.Color.Black;
            this.lstbxAuthors.FormattingEnabled = true;
            this.lstbxAuthors.ItemHeight = 15;
            this.lstbxAuthors.Location = new System.Drawing.Point(137, 143);
            this.lstbxAuthors.Name = "lstbxAuthors";
            this.lstbxAuthors.Size = new System.Drawing.Size(166, 94);
            this.lstbxAuthors.TabIndex = 62;
            this.toolTip1.SetToolTip(this.lstbxAuthors, "Double Click to Remove Value");
            this.lstbxAuthors.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // lstbxCategories
            // 
            this.lstbxCategories.BackColor = System.Drawing.Color.White;
            this.lstbxCategories.ForeColor = System.Drawing.Color.Black;
            this.lstbxCategories.FormattingEnabled = true;
            this.lstbxCategories.ItemHeight = 15;
            this.lstbxCategories.Location = new System.Drawing.Point(137, 293);
            this.lstbxCategories.Name = "lstbxCategories";
            this.lstbxCategories.Size = new System.Drawing.Size(166, 94);
            this.lstbxCategories.TabIndex = 63;
            this.toolTip1.SetToolTip(this.lstbxCategories, "Double Click to Remove Value");
            this.lstbxCategories.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddBook.Location = new System.Drawing.Point(309, 419);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(198, 40);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            this.btnAddBook.MouseLeave += new System.EventHandler(this.btnAddBook_MouseLeave);
            this.btnAddBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddBook_MouseMove);
            // 
            // txtPageCount
            // 
            this.txtPageCount.BackColor = System.Drawing.Color.White;
            this.txtPageCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPageCount.ForeColor = System.Drawing.Color.Black;
            this.txtPageCount.Location = new System.Drawing.Point(544, 68);
            this.txtPageCount.MaxLength = 5;
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(166, 22);
            this.txtPageCount.TabIndex = 4;
            this.txtPageCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockPageTextboxes_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(544, 172);
            this.txtStock.MaxLength = 9;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(166, 22);
            this.txtStock.TabIndex = 6;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockPageTextboxes_KeyPress);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 523);
            this.Controls.Add(this.lstbxCategories);
            this.Controls.Add(this.lstbxAuthors);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.pcbClear);
            this.Controls.Add(this.pcbAddNewCategory);
            this.Controls.Add(this.pcbAddNewAuthor);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.mtxtReleaseDate);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBooks";
            this.Activated += new System.EventHandler(this.frmAddBook_Activated);
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBooks_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBooks_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pcbCloseForm;
        private TextBox txtBook;
        private MaskedTextBox mtxtReleaseDate;
        private ComboBox cmbCategories;
        private ComboBox cmbAuthors;
        private Button btnChooseImage;
        private PictureBox pcbImage;
        private ToolTip toolTip1;
        private Button btnAddBook;
        private PictureBox pcbAddNewAuthor;
        private PictureBox pcbAddNewCategory;
        private PictureBox pcbClear;
        private TextBox txtPageCount;
        private TextBox txtStock;
        private ListBox lstbxAuthors;
        private ListBox lstbxCategories;
    }
}