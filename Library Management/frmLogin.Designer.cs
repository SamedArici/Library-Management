namespace Library_Management
{
    partial class frmLogin
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowLoginForm = new System.Windows.Forms.Button();
            this.btnShowRegisterForm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbClear = new System.Windows.Forms.PictureBox();
            this.pcbShowPsw = new System.Windows.Forms.PictureBox();
            this.pcbMinimizeBox = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowPsw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(318, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 37);
            this.label10.TabIndex = 27;
            this.label10.Text = "/";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(578, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Enter += new System.EventHandler(this.Buttons_Enter);
            this.btnExit.Leave += new System.EventHandler(this.Buttons_Leave);
            this.btnExit.MouseLeave += new System.EventHandler(this.Buttons_Mouse_Leave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Butons_Mouse_Move);
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLoginForm.Enabled = false;
            this.btnShowLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowLoginForm.ForeColor = System.Drawing.Color.Cyan;
            this.btnShowLoginForm.Location = new System.Drawing.Point(190, 35);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(123, 35);
            this.btnShowLoginForm.TabIndex = 24;
            this.btnShowLoginForm.Text = "Login Form";
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Paint += new System.Windows.Forms.PaintEventHandler(this.btnShowLoginForm_Paint);
            // 
            // btnShowRegisterForm
            // 
            this.btnShowRegisterForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowRegisterForm.ForeColor = System.Drawing.Color.White;
            this.btnShowRegisterForm.Location = new System.Drawing.Point(351, 35);
            this.btnShowRegisterForm.Name = "btnShowRegisterForm";
            this.btnShowRegisterForm.Size = new System.Drawing.Size(123, 35);
            this.btnShowRegisterForm.TabIndex = 3;
            this.btnShowRegisterForm.Text = "Register Form";
            this.toolTip1.SetToolTip(this.btnShowRegisterForm, "Go to the Register Form");
            this.btnShowRegisterForm.UseVisualStyleBackColor = true;
            this.btnShowRegisterForm.Click += new System.EventHandler(this.btnShowRegisterForm_Click);
            this.btnShowRegisterForm.Enter += new System.EventHandler(this.Buttons_Enter);
            this.btnShowRegisterForm.Leave += new System.EventHandler(this.Buttons_Leave);
            this.btnShowRegisterForm.MouseLeave += new System.EventHandler(this.Buttons_Mouse_Leave);
            this.btnShowRegisterForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Butons_Mouse_Move);
            // 
            // pcbClear
            // 
            this.pcbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClear.ImageLocation = "https://img.icons8.com/color/480/broom.png";
            this.pcbClear.Location = new System.Drawing.Point(457, 227);
            this.pcbClear.Name = "pcbClear";
            this.pcbClear.Size = new System.Drawing.Size(40, 35);
            this.pcbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClear.TabIndex = 41;
            this.pcbClear.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClear, "Clear All Texts");
            this.pcbClear.Click += new System.EventHandler(this.pcbClear_Click);
            // 
            // pcbShowPsw
            // 
            this.pcbShowPsw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbShowPsw.ImageLocation = "https://icon-library.com/images/698902-icon-21-eye-hidden-512.png";
            this.pcbShowPsw.Location = new System.Drawing.Point(566, 142);
            this.pcbShowPsw.Name = "pcbShowPsw";
            this.pcbShowPsw.Size = new System.Drawing.Size(25, 21);
            this.pcbShowPsw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbShowPsw.TabIndex = 44;
            this.pcbShowPsw.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbShowPsw, "Show / Hide Password");
            this.pcbShowPsw.Click += new System.EventHandler(this.pcbShowPsw_Click);
            // 
            // pcbMinimizeBox
            // 
            this.pcbMinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizeBox.ImageLocation = "https://cdn-icons-png.flaticon.com/512/6276/6276659.png";
            this.pcbMinimizeBox.Location = new System.Drawing.Point(544, 12);
            this.pcbMinimizeBox.Name = "pcbMinimizeBox";
            this.pcbMinimizeBox.Size = new System.Drawing.Size(28, 28);
            this.pcbMinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizeBox.TabIndex = 46;
            this.pcbMinimizeBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbMinimizeBox, "Minimize the Form");
            this.pcbMinimizeBox.Click += new System.EventHandler(this.pcbMinimizeBox_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Gold;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(65, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 1);
            this.label17.TabIndex = 39;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(153, 142);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(65, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(204, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(247, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.Buttons_Enter);
            this.btnLogin.Leave += new System.EventHandler(this.Buttons_Leave);
            this.btnLogin.MouseLeave += new System.EventHandler(this.Buttons_Mouse_Leave);
            this.btnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Butons_Mouse_Move);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Gold;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(335, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(225, 1);
            this.label18.TabIndex = 45;
            // 
            // txtPsw
            // 
            this.txtPsw.BackColor = System.Drawing.Color.White;
            this.txtPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPsw.ForeColor = System.Drawing.Color.Black;
            this.txtPsw.Location = new System.Drawing.Point(420, 142);
            this.txtPsw.MaxLength = 22;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(140, 21);
            this.txtPsw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Password:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(655, 438);
            this.Controls.Add(this.pcbMinimizeBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pcbShowPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowLoginForm);
            this.Controls.Add(this.btnShowRegisterForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowPsw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Button btnExit;
        private Button btnShowLoginForm;
        private Button btnShowRegisterForm;
        private ToolTip toolTip1;
        private Label label17;
        private TextBox txtUsername;
        private Label label9;
        private PictureBox pcbClear;
        private Button btnLogin;
        private Label label18;
        private PictureBox pcbShowPsw;
        private TextBox txtPsw;
        private Label label1;
        private PictureBox pcbMinimizeBox;
    }
}