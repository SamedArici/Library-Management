namespace Library_Management
{
    partial class frmEditBook
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
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDateOfAddition = new System.Windows.Forms.MaskedTextBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pcbBookImage = new System.Windows.Forms.PictureBox();
            this.lstbxUsers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnUpdateUserDates = new System.Windows.Forms.Button();
            this.pcbRefreshGcbUsers = new System.Windows.Forms.PictureBox();
            this.pcbClearGbxUser = new System.Windows.Forms.PictureBox();
            this.mtxtReturnDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBorrowDate = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxBookInfos = new System.Windows.Forms.GroupBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.pcbRefreshGbxBook = new System.Windows.Forms.PictureBox();
            this.lstbxCategories = new System.Windows.Forms.ListBox();
            this.lstbxAuthors = new System.Windows.Forms.ListBox();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxAuthorsCategories = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBookImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefreshGcbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearGbxUser)).BeginInit();
            this.gbxBookInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefreshGbxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.gbxAuthorsCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Page Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Addition:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categories:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Image:";
            // 
            // txtBookname
            // 
            this.txtBookname.BackColor = System.Drawing.Color.White;
            this.txtBookname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBookname.ForeColor = System.Drawing.Color.Black;
            this.txtBookname.Location = new System.Drawing.Point(133, 50);
            this.txtBookname.MaxLength = 50;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(166, 21);
            this.txtBookname.TabIndex = 1;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuthors.BackColor = System.Drawing.Color.White;
            this.cmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthors.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(107, 40);
            this.cmbAuthors.MaxLength = 50;
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(166, 21);
            this.cmbAuthors.TabIndex = 2;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategories.BackColor = System.Drawing.Color.White;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.ForeColor = System.Drawing.Color.Black;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(107, 193);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 21);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // txtPageCount
            // 
            this.txtPageCount.BackColor = System.Drawing.Color.White;
            this.txtPageCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPageCount.ForeColor = System.Drawing.Color.Black;
            this.txtPageCount.Location = new System.Drawing.Point(133, 103);
            this.txtPageCount.MaxLength = 5;
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(166, 21);
            this.txtPageCount.TabIndex = 4;
            this.txtPageCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockPage_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(133, 153);
            this.txtStock.MaxLength = 9;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(166, 21);
            this.txtStock.TabIndex = 5;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockPage_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(77, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Stock:";
            // 
            // mtxtReleaseDate
            // 
            this.mtxtReleaseDate.BackColor = System.Drawing.Color.White;
            this.mtxtReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.mtxtReleaseDate.Location = new System.Drawing.Point(133, 203);
            this.mtxtReleaseDate.Mask = "00/00/0000";
            this.mtxtReleaseDate.Name = "mtxtReleaseDate";
            this.mtxtReleaseDate.Size = new System.Drawing.Size(166, 21);
            this.mtxtReleaseDate.TabIndex = 6;
            // 
            // mtxtDateOfAddition
            // 
            this.mtxtDateOfAddition.BackColor = System.Drawing.Color.White;
            this.mtxtDateOfAddition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtDateOfAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtDateOfAddition.ForeColor = System.Drawing.Color.Black;
            this.mtxtDateOfAddition.Location = new System.Drawing.Point(133, 253);
            this.mtxtDateOfAddition.Mask = "00/00/0000";
            this.mtxtDateOfAddition.Name = "mtxtDateOfAddition";
            this.mtxtDateOfAddition.Size = new System.Drawing.Size(166, 21);
            this.mtxtDateOfAddition.TabIndex = 7;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(133, 306);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(166, 29);
            this.btnChooseImage.TabIndex = 8;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pcbBookImage
            // 
            this.pcbBookImage.BackColor = System.Drawing.Color.White;
            this.pcbBookImage.ImageLocation = "https://i.pinimg.com/originals/dd/eb/23/ddeb23e067d822d84d50cca6fa04044f.png";
            this.pcbBookImage.Location = new System.Drawing.Point(133, 343);
            this.pcbBookImage.Name = "pcbBookImage";
            this.pcbBookImage.Size = new System.Drawing.Size(166, 106);
            this.pcbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBookImage.TabIndex = 57;
            this.pcbBookImage.TabStop = false;
            // 
            // lstbxUsers
            // 
            this.lstbxUsers.BackColor = System.Drawing.Color.White;
            this.lstbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxUsers.ForeColor = System.Drawing.Color.Black;
            this.lstbxUsers.FormattingEnabled = true;
            this.lstbxUsers.ItemHeight = 16;
            this.lstbxUsers.Location = new System.Drawing.Point(26, 55);
            this.lstbxUsers.Name = "lstbxUsers";
            this.lstbxUsers.ScrollAlwaysVisible = true;
            this.lstbxUsers.Size = new System.Drawing.Size(312, 212);
            this.lstbxUsers.Sorted = true;
            this.lstbxUsers.TabIndex = 58;
            this.toolTip1.SetToolTip(this.lstbxUsers, "Click to Select User \r\nDouble Click to Delete  User\r\n");
            this.lstbxUsers.Click += new System.EventHandler(this.lstbxUsers_Click);
            this.lstbxUsers.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchUser);
            this.groupBox1.Controls.Add(this.btnUpdateUserDates);
            this.groupBox1.Controls.Add(this.pcbRefreshGcbUsers);
            this.groupBox1.Controls.Add(this.pcbClearGbxUser);
            this.groupBox1.Controls.Add(this.mtxtReturnDate);
            this.groupBox1.Controls.Add(this.mtxtBorrowDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lstbxUsers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(716, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 532);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users who borrowed the selected book";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.Color.White;
            this.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchUser.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUser.Location = new System.Drawing.Point(26, 28);
            this.txtSearchUser.MaxLength = 50;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.PlaceholderText = "Search User by Username";
            this.txtSearchUser.Size = new System.Drawing.Size(204, 21);
            this.txtSearchUser.TabIndex = 68;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // btnUpdateUserDates
            // 
            this.btnUpdateUserDates.BackColor = System.Drawing.Color.White;
            this.btnUpdateUserDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUserDates.Enabled = false;
            this.btnUpdateUserDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUserDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUserDates.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUserDates.Location = new System.Drawing.Point(125, 409);
            this.btnUpdateUserDates.Name = "btnUpdateUserDates";
            this.btnUpdateUserDates.Size = new System.Drawing.Size(166, 36);
            this.btnUpdateUserDates.TabIndex = 66;
            this.btnUpdateUserDates.Text = "Update User Dates";
            this.btnUpdateUserDates.UseVisualStyleBackColor = false;
            this.btnUpdateUserDates.Click += new System.EventHandler(this.btnUpdateUserDates_Click);
            this.btnUpdateUserDates.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnUpdateUserDates.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // pcbRefreshGcbUsers
            // 
            this.pcbRefreshGcbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRefreshGcbUsers.ImageLocation = "https://icons.veryicon.com/png/o/miscellaneous/simple-icon/exchange-14.png";
            this.pcbRefreshGcbUsers.Location = new System.Drawing.Point(292, 10);
            this.pcbRefreshGcbUsers.Name = "pcbRefreshGcbUsers";
            this.pcbRefreshGcbUsers.Size = new System.Drawing.Size(30, 27);
            this.pcbRefreshGcbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefreshGcbUsers.TabIndex = 65;
            this.pcbRefreshGcbUsers.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbRefreshGcbUsers, "Refresh Users Infos");
            this.pcbRefreshGcbUsers.Click += new System.EventHandler(this.pcbRefreshGcbUsers_Click);
            // 
            // pcbClearGbxUser
            // 
            this.pcbClearGbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClearGbxUser.ImageLocation = "https://icon-library.com/images/0e2609429e.png";
            this.pcbClearGbxUser.Location = new System.Drawing.Point(328, 10);
            this.pcbClearGbxUser.Name = "pcbClearGbxUser";
            this.pcbClearGbxUser.Size = new System.Drawing.Size(30, 27);
            this.pcbClearGbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClearGbxUser.TabIndex = 65;
            this.pcbClearGbxUser.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClearGbxUser, "Clear User Infos");
            this.pcbClearGbxUser.Click += new System.EventHandler(this.pcbClearGbxUser_Click);
            // 
            // mtxtReturnDate
            // 
            this.mtxtReturnDate.BackColor = System.Drawing.Color.White;
            this.mtxtReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtReturnDate.Enabled = false;
            this.mtxtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtReturnDate.ForeColor = System.Drawing.Color.Black;
            this.mtxtReturnDate.Location = new System.Drawing.Point(125, 353);
            this.mtxtReturnDate.Mask = "00/00/0000";
            this.mtxtReturnDate.Name = "mtxtReturnDate";
            this.mtxtReturnDate.Size = new System.Drawing.Size(166, 21);
            this.mtxtReturnDate.TabIndex = 10;
            this.mtxtReturnDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtBorrowDate
            // 
            this.mtxtBorrowDate.BackColor = System.Drawing.Color.White;
            this.mtxtBorrowDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBorrowDate.Enabled = false;
            this.mtxtBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtBorrowDate.ForeColor = System.Drawing.Color.Black;
            this.mtxtBorrowDate.Location = new System.Drawing.Point(125, 303);
            this.mtxtBorrowDate.Mask = "00/00/0000";
            this.mtxtBorrowDate.Name = "mtxtBorrowDate";
            this.mtxtBorrowDate.Size = new System.Drawing.Size(166, 21);
            this.mtxtBorrowDate.TabIndex = 9;
            this.mtxtBorrowDate.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(23, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Borrow Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(26, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Return Date:";
            // 
            // gbxBookInfos
            // 
            this.gbxBookInfos.Controls.Add(this.btnUpdateBook);
            this.gbxBookInfos.Controls.Add(this.pcbRefreshGbxBook);
            this.gbxBookInfos.Controls.Add(this.label1);
            this.gbxBookInfos.Controls.Add(this.label3);
            this.gbxBookInfos.Controls.Add(this.label4);
            this.gbxBookInfos.Controls.Add(this.pcbBookImage);
            this.gbxBookInfos.Controls.Add(this.label5);
            this.gbxBookInfos.Controls.Add(this.btnChooseImage);
            this.gbxBookInfos.Controls.Add(this.mtxtDateOfAddition);
            this.gbxBookInfos.Controls.Add(this.label7);
            this.gbxBookInfos.Controls.Add(this.mtxtReleaseDate);
            this.gbxBookInfos.Controls.Add(this.txtBookname);
            this.gbxBookInfos.Controls.Add(this.label8);
            this.gbxBookInfos.Controls.Add(this.txtStock);
            this.gbxBookInfos.Controls.Add(this.txtPageCount);
            this.gbxBookInfos.Location = new System.Drawing.Point(26, 36);
            this.gbxBookInfos.Name = "gbxBookInfos";
            this.gbxBookInfos.Size = new System.Drawing.Size(317, 532);
            this.gbxBookInfos.TabIndex = 61;
            this.gbxBookInfos.TabStop = false;
            this.gbxBookInfos.Text = "Book Infos";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBook.Location = new System.Drawing.Point(133, 474);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(166, 36);
            this.btnUpdateBook.TabIndex = 63;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            this.btnUpdateBook.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnUpdateBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // pcbRefreshGbxBook
            // 
            this.pcbRefreshGbxBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRefreshGbxBook.ImageLocation = "https://icons.veryicon.com/png/o/miscellaneous/simple-icon/exchange-14.png";
            this.pcbRefreshGbxBook.Location = new System.Drawing.Point(97, 483);
            this.pcbRefreshGbxBook.Name = "pcbRefreshGbxBook";
            this.pcbRefreshGbxBook.Size = new System.Drawing.Size(30, 27);
            this.pcbRefreshGbxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefreshGbxBook.TabIndex = 64;
            this.pcbRefreshGbxBook.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbRefreshGbxBook, "Refresh Book Infos");
            this.pcbRefreshGbxBook.Click += new System.EventHandler(this.pcbRefreshGbxBook_Click);
            // 
            // lstbxCategories
            // 
            this.lstbxCategories.BackColor = System.Drawing.Color.White;
            this.lstbxCategories.ForeColor = System.Drawing.Color.Black;
            this.lstbxCategories.FormattingEnabled = true;
            this.lstbxCategories.ItemHeight = 15;
            this.lstbxCategories.Location = new System.Drawing.Point(107, 220);
            this.lstbxCategories.Name = "lstbxCategories";
            this.lstbxCategories.Size = new System.Drawing.Size(166, 94);
            this.lstbxCategories.TabIndex = 66;
            this.toolTip1.SetToolTip(this.lstbxCategories, "Double Click to Remove Selected Category\r\n");
            this.lstbxCategories.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // lstbxAuthors
            // 
            this.lstbxAuthors.BackColor = System.Drawing.Color.White;
            this.lstbxAuthors.ForeColor = System.Drawing.Color.Black;
            this.lstbxAuthors.FormattingEnabled = true;
            this.lstbxAuthors.ItemHeight = 15;
            this.lstbxAuthors.Location = new System.Drawing.Point(107, 67);
            this.lstbxAuthors.Name = "lstbxAuthors";
            this.lstbxAuthors.Size = new System.Drawing.Size(166, 94);
            this.lstbxAuthors.TabIndex = 65;
            this.toolTip1.SetToolTip(this.lstbxAuthors, "Double Click to Remove Selected Author\r\n");
            this.lstbxAuthors.DoubleClick += new System.EventHandler(this.Listboxes_DoubleClick);
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(1042, 3);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 62;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close the Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // gbxAuthorsCategories
            // 
            this.gbxAuthorsCategories.Controls.Add(this.lstbxAuthors);
            this.gbxAuthorsCategories.Controls.Add(this.label2);
            this.gbxAuthorsCategories.Controls.Add(this.lstbxCategories);
            this.gbxAuthorsCategories.Controls.Add(this.cmbAuthors);
            this.gbxAuthorsCategories.Controls.Add(this.label6);
            this.gbxAuthorsCategories.Controls.Add(this.cmbCategories);
            this.gbxAuthorsCategories.Location = new System.Drawing.Point(369, 36);
            this.gbxAuthorsCategories.Name = "gbxAuthorsCategories";
            this.gbxAuthorsCategories.Size = new System.Drawing.Size(311, 335);
            this.gbxAuthorsCategories.TabIndex = 67;
            this.gbxAuthorsCategories.TabStop = false;
            this.gbxAuthorsCategories.Text = "Add or Delete, Authors or Categories";
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 593);
            this.Controls.Add(this.gbxAuthorsCategories);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.gbxBookInfos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditBook";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEditBook_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEditBook_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBookImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefreshGcbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClearGbxUser)).EndInit();
            this.gbxBookInfos.ResumeLayout(false);
            this.gbxBookInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefreshGbxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.gbxAuthorsCategories.ResumeLayout(false);
            this.gbxAuthorsCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBookname;
        private ComboBox cmbAuthors;
        private ComboBox cmbCategories;
        private TextBox txtPageCount;
        private TextBox txtStock;
        private Label label8;
        private MaskedTextBox mtxtReleaseDate;
        private MaskedTextBox mtxtDateOfAddition;
        private Button btnChooseImage;
        private PictureBox pcbBookImage;
        private ListBox lstbxUsers;
        private GroupBox groupBox1;
        private MaskedTextBox mtxtReturnDate;
        private MaskedTextBox mtxtBorrowDate;
        private Label label11;
        private Label label10;
        private GroupBox gbxBookInfos;
        private PictureBox pcbCloseForm;
        private PictureBox pcbRefreshGbxBook;
        private Button btnUpdateBook;
        private PictureBox pcbClearGbxUser;
        private ToolTip toolTip1;
        private ListBox lstbxCategories;
        private ListBox lstbxAuthors;
        private PictureBox pcbRefreshGcbUsers;
        private Button btnUpdateUserDates;
        private GroupBox gbxAuthorsCategories;
        private TextBox txtSearchUser;
    }
}