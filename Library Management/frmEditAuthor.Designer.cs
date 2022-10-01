namespace Library_Management
{
    partial class frmEditAuthor
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
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbClear = new System.Windows.Forms.PictureBox();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.White;
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFullname.ForeColor = System.Drawing.Color.Black;
            this.txtFullname.Location = new System.Drawing.Point(105, 47);
            this.txtFullname.MaxLength = 50;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(166, 22);
            this.txtFullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fullname:";
            // 
            // mtxtBirthdate
            // 
            this.mtxtBirthdate.BackColor = System.Drawing.Color.White;
            this.mtxtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtBirthdate.ForeColor = System.Drawing.Color.Black;
            this.mtxtBirthdate.Location = new System.Drawing.Point(105, 97);
            this.mtxtBirthdate.Mask = "00/00/0000";
            this.mtxtBirthdate.Name = "mtxtBirthdate";
            this.mtxtBirthdate.Size = new System.Drawing.Size(166, 22);
            this.mtxtBirthdate.TabIndex = 2;
            this.mtxtBirthdate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Birthdate:";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(105, 147);
            this.txtCountry.MaxLength = 50;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(166, 22);
            this.txtCountry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Country:";
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.ImageLocation = "https://secure.webtoolhub.com/static/resources/icons/set112/261419af.png";
            this.pcbImage.Location = new System.Drawing.Point(12, 249);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(259, 198);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 60;
            this.pcbImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(105, 192);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(166, 30);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Image:";
            // 
            // pcbClear
            // 
            this.pcbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbClear.ImageLocation = "https://icon-library.com/images/0e2609429e.png";
            this.pcbClear.Location = new System.Drawing.Point(227, 480);
            this.pcbClear.Name = "pcbClear";
            this.pcbClear.Size = new System.Drawing.Size(30, 27);
            this.pcbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClear.TabIndex = 63;
            this.pcbClear.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbClear, "Clear All Texts");
            this.pcbClear.Click += new System.EventHandler(this.pcbClear_Click);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackColor = System.Drawing.Color.White;
            this.btnEditAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditAuthor.ForeColor = System.Drawing.Color.Black;
            this.btnEditAuthor.Location = new System.Drawing.Point(23, 467);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(198, 40);
            this.btnEditAuthor.TabIndex = 6;
            this.btnEditAuthor.Text = "Add Author";
            this.btnEditAuthor.UseVisualStyleBackColor = false;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            this.btnEditAuthor.MouseLeave += new System.EventHandler(this.btnEditAuthor_MouseLeave);
            this.btnEditAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEditAuthor_MouseMove);
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(248, 2);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 64;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close This Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // frmEditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 532);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.pcbClear);
            this.Controls.Add(this.btnEditAuthor);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtBirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddAuthor";
            this.Load += new System.EventHandler(this.frmAddAuthor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddAuthor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAddAuthor_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFullname;
        private Label label1;
        private MaskedTextBox mtxtBirthdate;
        private Label label4;
        private TextBox txtCountry;
        private Label label2;
        private PictureBox pcbImage;
        private Button btnChooseImage;
        private Label label5;
        private PictureBox pcbClear;
        private Button btnEditAuthor;
        private ToolTip toolTip1;
        private PictureBox pcbCloseForm;
    }
}