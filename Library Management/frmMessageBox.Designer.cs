namespace Library_Management
{
    partial class frmMessageBox
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
            this.btnOp1 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pcbCloseForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOp1
            // 
            this.btnOp1.BackColor = System.Drawing.Color.White;
            this.btnOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOp1.ForeColor = System.Drawing.Color.Black;
            this.btnOp1.Location = new System.Drawing.Point(11, 81);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(140, 25);
            this.btnOp1.TabIndex = 54;
            this.btnOp1.Text = "Operation 1";
            this.btnOp1.UseVisualStyleBackColor = false;
            this.btnOp1.Click += new System.EventHandler(this.btnOp1_Click);
            // 
            // btnOp2
            // 
            this.btnOp2.BackColor = System.Drawing.Color.White;
            this.btnOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOp2.ForeColor = System.Drawing.Color.Black;
            this.btnOp2.Location = new System.Drawing.Point(160, 81);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(140, 25);
            this.btnOp2.TabIndex = 55;
            this.btnOp2.Text = "Operation 2";
            this.btnOp2.UseVisualStyleBackColor = false;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnOp3
            // 
            this.btnOp3.BackColor = System.Drawing.Color.White;
            this.btnOp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOp3.ForeColor = System.Drawing.Color.Black;
            this.btnOp3.Location = new System.Drawing.Point(306, 81);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(140, 25);
            this.btnOp3.TabIndex = 56;
            this.btnOp3.Text = "Operation 3";
            this.btnOp3.UseVisualStyleBackColor = false;
            this.btnOp3.Click += new System.EventHandler(this.btnOp3_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(12, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(62, 20);
            this.lblHeader.TabIndex = 57;
            this.lblHeader.Text = "Header";
            // 
            // pcbCloseForm
            // 
            this.pcbCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCloseForm.ImageLocation = "https://www.makasiimports.co.uk/images/popup-close-button.png";
            this.pcbCloseForm.Location = new System.Drawing.Point(415, 3);
            this.pcbCloseForm.Name = "pcbCloseForm";
            this.pcbCloseForm.Size = new System.Drawing.Size(32, 27);
            this.pcbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCloseForm.TabIndex = 58;
            this.pcbCloseForm.TabStop = false;
            this.pcbCloseForm.Click += new System.EventHandler(this.pcbCloseForm_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 129);
            this.Controls.Add(this.pcbCloseForm);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnOp1;
        private Button btnOp2;
        private Button btnOp3;
        private Label lblHeader;
        private PictureBox pcbCloseForm;
    }
}