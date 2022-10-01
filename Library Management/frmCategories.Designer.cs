namespace Library_Management
{
    partial class frmCategories
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
            this.gbxAddNewCat = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewCategoryName = new System.Windows.Forms.TextBox();
            this.gbxEditCategories = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            this.gbxAddNewCat.SuspendLayout();
            this.gbxEditCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddNewCat
            // 
            this.gbxAddNewCat.Controls.Add(this.btnAddCategory);
            this.gbxAddNewCat.Controls.Add(this.label1);
            this.gbxAddNewCat.Controls.Add(this.txtNewCategoryName);
            this.gbxAddNewCat.ForeColor = System.Drawing.Color.Black;
            this.gbxAddNewCat.Location = new System.Drawing.Point(12, 37);
            this.gbxAddNewCat.Name = "gbxAddNewCat";
            this.gbxAddNewCat.Size = new System.Drawing.Size(327, 154);
            this.gbxAddNewCat.TabIndex = 0;
            this.gbxAddNewCat.TabStop = false;
            this.gbxAddNewCat.Text = "Add a New Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.Location = new System.Drawing.Point(131, 72);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(166, 29);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            this.btnAddCategory.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnAddCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddCategory_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Name:";
            // 
            // txtNewCategoryName
            // 
            this.txtNewCategoryName.BackColor = System.Drawing.Color.White;
            this.txtNewCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNewCategoryName.ForeColor = System.Drawing.Color.Black;
            this.txtNewCategoryName.Location = new System.Drawing.Point(131, 33);
            this.txtNewCategoryName.MaxLength = 20;
            this.txtNewCategoryName.Name = "txtNewCategoryName";
            this.txtNewCategoryName.Size = new System.Drawing.Size(166, 22);
            this.txtNewCategoryName.TabIndex = 1;
            // 
            // gbxEditCategories
            // 
            this.gbxEditCategories.Controls.Add(this.btnDelete);
            this.gbxEditCategories.Controls.Add(this.label3);
            this.gbxEditCategories.Controls.Add(this.cmbCategories);
            this.gbxEditCategories.Controls.Add(this.btnUpdate);
            this.gbxEditCategories.Controls.Add(this.label2);
            this.gbxEditCategories.Controls.Add(this.txtRename);
            this.gbxEditCategories.ForeColor = System.Drawing.Color.Black;
            this.gbxEditCategories.Location = new System.Drawing.Point(12, 211);
            this.gbxEditCategories.Name = "gbxEditCategories";
            this.gbxEditCategories.Size = new System.Drawing.Size(327, 154);
            this.gbxEditCategories.TabIndex = 1;
            this.gbxEditCategories.TabStop = false;
            this.gbxEditCategories.Text = "Edit Categories";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(181, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDelete_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
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
            this.cmbCategories.Location = new System.Drawing.Point(131, 28);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 24);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(38, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rename:";
            // 
            // txtRename
            // 
            this.txtRename.BackColor = System.Drawing.Color.White;
            this.txtRename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRename.Enabled = false;
            this.txtRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRename.ForeColor = System.Drawing.Color.Black;
            this.txtRename.Location = new System.Drawing.Point(131, 69);
            this.txtRename.MaxLength = 20;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(166, 22);
            this.txtRename.TabIndex = 4;
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(318, 4);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 13;
            this.pcbCloseForm.TabStop = false;
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 384);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.gbxEditCategories);
            this.Controls.Add(this.gbxAddNewCat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCategories_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCategories_MouseMove);
            this.gbxAddNewCat.ResumeLayout(false);
            this.gbxAddNewCat.PerformLayout();
            this.gbxEditCategories.ResumeLayout(false);
            this.gbxEditCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxAddNewCat;
        private Label label1;
        private TextBox txtNewCategoryName;
        private Button btnAddCategory;
        private GroupBox gbxEditCategories;
        private Button btnUpdate;
        private Label label2;
        private TextBox txtRename;
        private Label label3;
        private ComboBox cmbCategories;
        private PictureBox pcbCloseForm;
        private Button btnDelete;
    }
}