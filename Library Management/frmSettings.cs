using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            fillInfos();
        }

        private void fillInfos()
        {
            GlobalMethods.connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblSettings", GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtBorrowBooksNumber.Text = reader["numberOfBorrowingBooks"].ToString();
                txtFailedLoginHours.Text = reader["waitingTime"].ToString();
                txtReturnBookDays.Text = reader["returnBookDays"].ToString();
                txtWrongAttempts.Text = reader["maxWrongAttempts"].ToString();
                txtResetTime.Text = reader["resetWrongAttempts"].ToString();
            }
            reader.Close();
            GlobalMethods.connection.Close();
        }

        private void pcbRefresh_Click(object sender, EventArgs e)
        {
            fillInfos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to update the settings?", "Update Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    string command = "update tblSettings set numberOfBorrowingBooks ='" + txtBorrowBooksNumber.Text.Trim() + "' , waitingTime ='" + txtFailedLoginHours.Text.Trim() + "' , " +
                        "returnBookDays ='" + txtReturnBookDays.Text.Trim() + "' , maxWrongAttempts = '"+txtWrongAttempts.Text.Trim()+"' , resetWrongAttempts ='"+txtResetTime.Text.Trim()+"'";
                    GlobalMethods.updateTable(command);
                    MessageBox.Show("Settings Updated Successfully!", "Settings Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool check()
        {
            if(txtBorrowBooksNumber.Text == "" | txtFailedLoginHours.Text == "" | txtReturnBookDays.Text == ""| txtResetTime.Text == "" | txtWrongAttempts.Text == "")
            {
                MessageBox.Show("Fill all the infos!", "EMPTY VALUES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Textboxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        Point lastPoint;
        private void frmSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmSettings_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.ForeColor = Color.Blue;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Black;
        }
    }
}
