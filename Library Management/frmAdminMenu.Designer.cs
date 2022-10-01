namespace Library_Management
{
    partial class frmAdminMenu
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
            this.pcbMinimizeBox = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowUserMenu = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMinimizeBox
            // 
            this.pcbMinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizeBox.ImageLocation = "https://cdn-icons-png.flaticon.com/512/6276/6276659.png";
            this.pcbMinimizeBox.Location = new System.Drawing.Point(482, 1);
            this.pcbMinimizeBox.Name = "pcbMinimizeBox";
            this.pcbMinimizeBox.Size = new System.Drawing.Size(30, 30);
            this.pcbMinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizeBox.TabIndex = 49;
            this.pcbMinimizeBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbMinimizeBox, "Minimize the Form");
            this.pcbMinimizeBox.Click += new System.EventHandler(this.pcbMinimizeBox_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(517, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the Application");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnAddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(212, 201);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(170, 40);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Add a New Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            this.btnAddAuthor.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnAddAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.btnShowMenu.Enabled = false;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowMenu.ForeColor = System.Drawing.Color.Cyan;
            this.btnShowMenu.Location = new System.Drawing.Point(12, 41);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(170, 40);
            this.btnShowMenu.TabIndex = 1;
            this.btnShowMenu.Text = "Home";
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.btnShowMenu_Paint);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnAddNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 201);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(170, 40);
            this.btnAddNewBook.TabIndex = 6;
            this.btnAddNewBook.Text = "Add a New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            this.btnAddNewBook.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnAddNewBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnShowUserMenu
            // 
            this.btnShowUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnShowUserMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUserMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowUserMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowUserMenu.Location = new System.Drawing.Point(482, 37);
            this.btnShowUserMenu.Name = "btnShowUserMenu";
            this.btnShowUserMenu.Size = new System.Drawing.Size(111, 33);
            this.btnShowUserMenu.TabIndex = 9;
            this.btnShowUserMenu.Text = "User Menu";
            this.toolTip1.SetToolTip(this.btnShowUserMenu, "Go to the User Menu");
            this.btnShowUserMenu.UseVisualStyleBackColor = false;
            this.btnShowUserMenu.Click += new System.EventHandler(this.btnShowUserMenu_Click);
            this.btnShowUserMenu.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnShowUserMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(412, 201);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(170, 40);
            this.btnCategories.TabIndex = 8;
            this.btnCategories.Text = "Edit Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            this.btnCategories.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnCategories.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnShowBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowBooks.ForeColor = System.Drawing.Color.White;
            this.btnShowBooks.Location = new System.Drawing.Point(12, 121);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(170, 40);
            this.btnShowBooks.TabIndex = 3;
            this.btnShowBooks.Text = "Books";
            this.btnShowBooks.UseVisualStyleBackColor = false;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            this.btnShowBooks.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnShowBooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAuthors.Location = new System.Drawing.Point(212, 121);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(170, 40);
            this.btnAuthors.TabIndex = 4;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            this.btnAuthors.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnAuthors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(212, 41);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 40);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(411, 121);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(170, 40);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnUsers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnShowUserMenu);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnShowMenu);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.pcbMinimizeBox);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMenu";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdminMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdminMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pcbMinimizeBox;
        private Button btnExit;
        private Button btnAddAuthor;
        private Button btnShowMenu;
        private Button btnAddNewBook;
        private ToolTip toolTip1;
        private Button btnCategories;
        private Button btnShowBooks;
        private Button btnShowUserMenu;
        private Button btnAuthors;
        private Button btnSettings;
        private Button btnUsers;
    }
}