namespace Library_Management
{
    partial class frmUserMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pcbMinimizeBox = new System.Windows.Forms.PictureBox();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbEditInfos = new System.Windows.Forms.PictureBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.gbxUserInfos = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAdminMenu = new System.Windows.Forms.Button();
            this.btnShowAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditInfos)).BeginInit();
            this.gbxUserInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(73)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(673, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the Application");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // pcbMinimizeBox
            // 
            this.pcbMinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizeBox.ImageLocation = "https://cdn-icons-png.flaticon.com/512/6276/6276659.png";
            this.pcbMinimizeBox.Location = new System.Drawing.Point(637, 3);
            this.pcbMinimizeBox.Name = "pcbMinimizeBox";
            this.pcbMinimizeBox.Size = new System.Drawing.Size(30, 30);
            this.pcbMinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizeBox.TabIndex = 47;
            this.pcbMinimizeBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbMinimizeBox, "Minimize the Form");
            this.pcbMinimizeBox.Click += new System.EventHandler(this.pcbMinimizeBox_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.Enabled = false;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowMenu.ForeColor = System.Drawing.Color.Cyan;
            this.btnShowMenu.Location = new System.Drawing.Point(12, 12);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(170, 40);
            this.btnShowMenu.TabIndex = 48;
            this.btnShowMenu.Text = "Home";
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.btnShowMenu_Paint);
            // 
            // pcbEditInfos
            // 
            this.pcbEditInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEditInfos.ImageLocation = "https://cdn3.iconfinder.com/data/icons/basicolor-essentials/24/006_edit-512.png";
            this.pcbEditInfos.Location = new System.Drawing.Point(518, 12);
            this.pcbEditInfos.Name = "pcbEditInfos";
            this.pcbEditInfos.Size = new System.Drawing.Size(30, 25);
            this.pcbEditInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditInfos.TabIndex = 53;
            this.pcbEditInfos.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEditInfos, "Edit Your Informations");
            this.pcbEditInfos.Click += new System.EventHandler(this.pcbEditInfos_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(200, 12);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(170, 40);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            this.btnBooks.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnBooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // gbxUserInfos
            // 
            this.gbxUserInfos.Controls.Add(this.lblUsername);
            this.gbxUserInfos.Controls.Add(this.pcbEditInfos);
            this.gbxUserInfos.Controls.Add(this.lblGender);
            this.gbxUserInfos.Controls.Add(this.lblBirthdate);
            this.gbxUserInfos.Controls.Add(this.lblPhone);
            this.gbxUserInfos.Controls.Add(this.lblEmail);
            this.gbxUserInfos.Controls.Add(this.lblSurname);
            this.gbxUserInfos.Controls.Add(this.lblName);
            this.gbxUserInfos.Controls.Add(this.label7);
            this.gbxUserInfos.Controls.Add(this.label5);
            this.gbxUserInfos.Controls.Add(this.label6);
            this.gbxUserInfos.Controls.Add(this.label3);
            this.gbxUserInfos.Controls.Add(this.label4);
            this.gbxUserInfos.Controls.Add(this.label2);
            this.gbxUserInfos.Controls.Add(this.label1);
            this.gbxUserInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxUserInfos.ForeColor = System.Drawing.Color.White;
            this.gbxUserInfos.Location = new System.Drawing.Point(12, 81);
            this.gbxUserInfos.Name = "gbxUserInfos";
            this.gbxUserInfos.Size = new System.Drawing.Size(550, 395);
            this.gbxUserInfos.TabIndex = 52;
            this.gbxUserInfos.TabStop = false;
            this.gbxUserInfos.Text = "Personal Informations";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gold;
            this.lblUsername.Location = new System.Drawing.Point(120, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 20);
            this.lblUsername.TabIndex = 66;
            this.lblUsername.Text = "Username:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.Gold;
            this.lblGender.Location = new System.Drawing.Point(120, 347);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 20);
            this.lblGender.TabIndex = 65;
            this.lblGender.Text = "Gender:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthdate.ForeColor = System.Drawing.Color.Gold;
            this.lblBirthdate.Location = new System.Drawing.Point(120, 297);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(88, 20);
            this.lblBirthdate.TabIndex = 64;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.ForeColor = System.Drawing.Color.Gold;
            this.lblPhone.Location = new System.Drawing.Point(120, 197);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 20);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Gold;
            this.lblEmail.Location = new System.Drawing.Point(120, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 20);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.ForeColor = System.Drawing.Color.Gold;
            this.lblSurname.Location = new System.Drawing.Point(120, 97);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(86, 20);
            this.lblSurname.TabIndex = 61;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(120, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Birthdate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Name:";
            // 
            // btnShowAdminMenu
            // 
            this.btnShowAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnShowAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAdminMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowAdminMenu.Location = new System.Drawing.Point(637, 39);
            this.btnShowAdminMenu.Name = "btnShowAdminMenu";
            this.btnShowAdminMenu.Size = new System.Drawing.Size(111, 33);
            this.btnShowAdminMenu.TabIndex = 3;
            this.btnShowAdminMenu.Text = "Admin Menu";
            this.btnShowAdminMenu.UseVisualStyleBackColor = false;
            this.btnShowAdminMenu.Visible = false;
            this.btnShowAdminMenu.Click += new System.EventHandler(this.btnShowAdminMenu_Click);
            this.btnShowAdminMenu.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnShowAdminMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // btnShowAuthors
            // 
            this.btnShowAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnShowAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAuthors.ForeColor = System.Drawing.Color.White;
            this.btnShowAuthors.Location = new System.Drawing.Point(392, 12);
            this.btnShowAuthors.Name = "btnShowAuthors";
            this.btnShowAuthors.Size = new System.Drawing.Size(170, 40);
            this.btnShowAuthors.TabIndex = 2;
            this.btnShowAuthors.Text = "Authors";
            this.btnShowAuthors.UseVisualStyleBackColor = false;
            this.btnShowAuthors.Click += new System.EventHandler(this.btnShowAuthors_Click);
            this.btnShowAuthors.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnShowAuthors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // frmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(751, 488);
            this.Controls.Add(this.btnShowAuthors);
            this.Controls.Add(this.btnShowAdminMenu);
            this.Controls.Add(this.gbxUserInfos);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnShowMenu);
            this.Controls.Add(this.pcbMinimizeBox);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmUserMenu_Activated);
            this.Load += new System.EventHandler(this.frmUserMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUserMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditInfos)).EndInit();
            this.gbxUserInfos.ResumeLayout(false);
            this.gbxUserInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExit;
        private PictureBox pcbMinimizeBox;
        private Button btnShowMenu;
        private ToolTip toolTip1;
        private Button btnBooks;
        private GroupBox gbxUserInfos;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblUsername;
        private Label lblGender;
        private Label lblBirthdate;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblSurname;
        private Label lblName;
        private PictureBox pcbEditInfos;
        private Button btnShowAdminMenu;
        private Button btnShowAuthors;
    }
}