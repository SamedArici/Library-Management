namespace Library_Management
{
    partial class frmSettings
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
            this.txtBorrowBooksNumber = new System.Windows.Forms.TextBox();
            this.txtFailedLoginHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturnBookDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWrongAttempts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResetTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of books users can borrow:\r\n";
            // 
            // txtBorrowBooksNumber
            // 
            this.txtBorrowBooksNumber.BackColor = System.Drawing.Color.White;
            this.txtBorrowBooksNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorrowBooksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBorrowBooksNumber.ForeColor = System.Drawing.Color.Black;
            this.txtBorrowBooksNumber.Location = new System.Drawing.Point(12, 64);
            this.txtBorrowBooksNumber.MaxLength = 4;
            this.txtBorrowBooksNumber.Name = "txtBorrowBooksNumber";
            this.txtBorrowBooksNumber.Size = new System.Drawing.Size(69, 22);
            this.txtBorrowBooksNumber.TabIndex = 1;
            this.txtBorrowBooksNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textboxes_KeyPress);
            // 
            // txtFailedLoginHours
            // 
            this.txtFailedLoginHours.BackColor = System.Drawing.Color.White;
            this.txtFailedLoginHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFailedLoginHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFailedLoginHours.ForeColor = System.Drawing.Color.Black;
            this.txtFailedLoginHours.Location = new System.Drawing.Point(12, 149);
            this.txtFailedLoginHours.MaxLength = 2;
            this.txtFailedLoginHours.Name = "txtFailedLoginHours";
            this.txtFailedLoginHours.Size = new System.Drawing.Size(69, 22);
            this.txtFailedLoginHours.TabIndex = 2;
            this.txtFailedLoginHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textboxes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "The time to wait after 4 failed login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "hours.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "books.";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(588, 1);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 13;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close This Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRefresh.ImageLocation = "https://icons.veryicon.com/png/o/miscellaneous/simple-icon/exchange-14.png";
            this.pcbRefresh.Location = new System.Drawing.Point(407, 329);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(30, 27);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefresh.TabIndex = 65;
            this.pcbRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbRefresh, "Refresh Infos");
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "days.";
            // 
            // txtReturnBookDays
            // 
            this.txtReturnBookDays.BackColor = System.Drawing.Color.White;
            this.txtReturnBookDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnBookDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReturnBookDays.ForeColor = System.Drawing.Color.Black;
            this.txtReturnBookDays.Location = new System.Drawing.Point(12, 252);
            this.txtReturnBookDays.MaxLength = 2;
            this.txtReturnBookDays.Name = "txtReturnBookDays";
            this.txtReturnBookDays.Size = new System.Drawing.Size(69, 22);
            this.txtReturnBookDays.TabIndex = 3;
            this.txtReturnBookDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textboxes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "The number of days it takes to return \r\nthe book after borrowing.";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(208, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(421, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "attempts.";
            // 
            // txtWrongAttempts
            // 
            this.txtWrongAttempts.BackColor = System.Drawing.Color.White;
            this.txtWrongAttempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWrongAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWrongAttempts.ForeColor = System.Drawing.Color.Black;
            this.txtWrongAttempts.Location = new System.Drawing.Point(346, 64);
            this.txtWrongAttempts.MaxLength = 2;
            this.txtWrongAttempts.Name = "txtWrongAttempts";
            this.txtWrongAttempts.Size = new System.Drawing.Size(69, 22);
            this.txtWrongAttempts.TabIndex = 4;
            this.txtWrongAttempts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textboxes_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(346, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Maximum wrong attempts to Login:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(421, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 71;
            this.label9.Text = "minutes.";
            // 
            // txtResetTime
            // 
            this.txtResetTime.BackColor = System.Drawing.Color.White;
            this.txtResetTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResetTime.ForeColor = System.Drawing.Color.Black;
            this.txtResetTime.Location = new System.Drawing.Point(346, 149);
            this.txtResetTime.MaxLength = 2;
            this.txtResetTime.Name = "txtResetTime";
            this.txtResetTime.Size = new System.Drawing.Size(69, 22);
            this.txtResetTime.TabIndex = 5;
            this.txtResetTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textboxes_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(346, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "Reset time of wrong attempts:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 390);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResetTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWrongAttempts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcbRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReturnBookDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFailedLoginHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBorrowBooksNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSettings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSettings_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBorrowBooksNumber;
        private TextBox txtFailedLoginHours;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pcbCloseForm;
        private ToolTip toolTip1;
        private Label label5;
        private TextBox txtReturnBookDays;
        private Label label6;
        private Button btnUpdate;
        private PictureBox pcbRefresh;
        private Label label7;
        private TextBox txtWrongAttempts;
        private Label label8;
        private Label label9;
        private TextBox txtResetTime;
        private Label label10;
    }
}