namespace Library_Management
{
    partial class frmAuthors
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
            this.dtgvAuthors = new System.Windows.Forms.DataGridView();
            this.gbxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthors)).BeginInit();
            this.gbxSearchAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAuthors
            // 
            this.dtgvAuthors.AllowUserToAddRows = false;
            this.dtgvAuthors.AllowUserToDeleteRows = false;
            this.dtgvAuthors.AllowUserToResizeColumns = false;
            this.dtgvAuthors.AllowUserToResizeRows = false;
            this.dtgvAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuthors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvAuthors.Location = new System.Drawing.Point(0, 176);
            this.dtgvAuthors.MultiSelect = false;
            this.dtgvAuthors.Name = "dtgvAuthors";
            this.dtgvAuthors.ReadOnly = true;
            this.dtgvAuthors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvAuthors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAuthors.RowTemplate.Height = 25;
            this.dtgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAuthors.Size = new System.Drawing.Size(752, 319);
            this.dtgvAuthors.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtgvAuthors, "Double Click to Make Operations");
            this.dtgvAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAuthors_CellDoubleClick);
            // 
            // gbxSearchAuthor
            // 
            this.gbxSearchAuthor.Controls.Add(this.txtCountry);
            this.gbxSearchAuthor.Controls.Add(this.label3);
            this.gbxSearchAuthor.Controls.Add(this.label1);
            this.gbxSearchAuthor.Controls.Add(this.mtxtBirthdate);
            this.gbxSearchAuthor.Controls.Add(this.cmbAuthors);
            this.gbxSearchAuthor.Controls.Add(this.label2);
            this.gbxSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxSearchAuthor.ForeColor = System.Drawing.Color.Gold;
            this.gbxSearchAuthor.Location = new System.Drawing.Point(31, 21);
            this.gbxSearchAuthor.Name = "gbxSearchAuthor";
            this.gbxSearchAuthor.Size = new System.Drawing.Size(690, 138);
            this.gbxSearchAuthor.TabIndex = 2;
            this.gbxSearchAuthor.TabStop = false;
            this.gbxSearchAuthor.Text = "Search Authors";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(505, 69);
            this.txtCountry.MaxLength = 50;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(159, 24);
            this.txtCountry.TabIndex = 70;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Birthdate:";
            // 
            // mtxtBirthdate
            // 
            this.mtxtBirthdate.BackColor = System.Drawing.Color.White;
            this.mtxtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtBirthdate.ForeColor = System.Drawing.Color.Black;
            this.mtxtBirthdate.Location = new System.Drawing.Point(260, 69);
            this.mtxtBirthdate.Mask = "00/00/0000";
            this.mtxtBirthdate.Name = "mtxtBirthdate";
            this.mtxtBirthdate.Size = new System.Drawing.Size(159, 24);
            this.mtxtBirthdate.TabIndex = 67;
            this.mtxtBirthdate.ValidatingType = typeof(System.DateTime);
            this.mtxtBirthdate.TextChanged += new System.EventHandler(this.mtxtBirthdate_TextChanged);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuthors.BackColor = System.Drawing.Color.White;
            this.cmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthors.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(24, 70);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(159, 24);
            this.cmbAuthors.TabIndex = 66;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            this.cmbAuthors.TextChanged += new System.EventHandler(this.cmbAuthors_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Authors:";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(717, 0);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 64;
            this.pcbCloseForm.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCloseForm, "Close This Form");
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(752, 495);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.gbxSearchAuthor);
            this.Controls.Add(this.dtgvAuthors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAuthors";
            this.Activated += new System.EventHandler(this.frmAuthors_Activated);
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAuthors_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAuthors_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthors)).EndInit();
            this.gbxSearchAuthor.ResumeLayout(false);
            this.gbxSearchAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvAuthors;
        private GroupBox gbxSearchAuthor;
        private ComboBox cmbAuthors;
        private Label label2;
        private MaskedTextBox mtxtBirthdate;
        private Label label1;
        private TextBox txtCountry;
        private Label label3;
        private PictureBox pcbCloseForm;
        private ToolTip toolTip1;
    }
}