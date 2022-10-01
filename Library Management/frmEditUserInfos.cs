using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmEditUserInfos : Form
    {
        public frmEditUserInfos()
        {
            InitializeComponent();
        }
        User user = new User();
        public int user_id { get; set; } = 0;

        string psw = "";
        string saltPsw = "";
        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditUserInfos_Load(object sender, EventArgs e)
        {
            getUserInfos();
        }
        private void getUserInfos()
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("select * from tblUsers where u_id ='" + user_id + "'", GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtName.Text = reader["name"].ToString();
                txtSurname.Text = reader["surname"].ToString();
                txtUsername.Text = reader["username"].ToString();
                txtMail.Text = reader["mail"].ToString();

                mtxtBirthdate.Text = Convert.ToDateTime(reader["birthdate"].ToString()).ToString("ddMMyyyy");

                mtxtPhone.Text = reader["phone"].ToString();

                if (reader["gender"].ToString() == "False") rbtnMale.Checked = true;
                else rbtnFemale.Checked = true;

                psw = (string)reader["password"];
                saltPsw = (string)reader["saltPassword"];
            }

            reader.Close();
            GlobalMethods.connection.Close();
        }

        private void pcbRefreshGcbUsers_Click(object sender, EventArgs e)
        {
            getUserInfos();
        }


        Point lastPoint;
        private void frmEditUserInfos_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmEditUserInfos_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        // update personal information
        private void btnEditInfos_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to update personal information!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string cmd = "update tblUsers set name='" + txtName.Text.Trim() + "' , surname ='" + txtSurname.Text.Trim() + "' , phone ='" + mtxtPhone.Text.Trim() + "' , " +
                    "birthDate ='" + mtxtBirthdate.Text.Trim() + "' , mail ='" + txtMail.Text.Trim() + "' , gender ='" + rbtnFemale.Checked + "' , " +
                    "username ='" + txtUsername.Text.Trim() + "' where u_id ='" + user_id + "'";

                    user.updateUser(cmd);

                    MessageBox.Show("Personal Informations are Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool check()
        {
            if (!emptyValueCheck()) return false;

            else if (!user.valueLengthCheck(txtName.Text.Trim(), txtSurname.Text.Trim(), txtMail.Text.Trim(), "1234")) return false; // for this case psw is not important

            else if (!user.checkInvalidCharacters(txtName.Text.Trim(), txtSurname.Text.Trim(), txtUsername.Text.Trim())) return false;

            else if (!user.checkBirthdate(mtxtBirthdate.Text.Trim())) return false;

            else if (user.checkMainValuesAreExist(mtxtPhone.Text.Trim(),txtMail.Text.Trim(),txtUsername.Text.Trim(), " and u_id != '" + user_id + "' ")) return false;

            return true;
        }

        private bool emptyValueCheck() // Are Entered Values Empty
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtMail.Text == "" || txtUsername.Text == "" || mtxtBirthdate.Text.Length != 10 || mtxtPhone.Text.Length != 14)
            {
                MessageBox.Show("Fill all the texts!", "Empty Information(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        // change password
        private void btnChangePsw_Click(object sender, EventArgs e)
        {
            string current_psw = user.ComputeSha256Hash(saltPsw+txtCurrentPsw.Text.Trim());

            // are passwords filled?
            if (txtCurrentPsw.Text == "" || txtNewPsw.Text == "" || txtNewPswR.Text == "")
                MessageBox.Show("Please fill all the Passwords!", "Empty Passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // is entered current password correct?
            else if(current_psw != psw)
                MessageBox.Show("Invalid Current Password!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // check new entered passwords
            else if (user.checkPasswords(txtNewPsw.Text.Trim(), txtNewPswR.Text.Trim()))
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to change password!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    string newpsw = user.ComputeSha256Hash(saltPsw + txtNewPsw.Text.Trim());
                    string command = "update tblUsers set saltPassword ='" + saltPsw + "' , password ='" + newpsw + "' where u_id ='" + user_id + "'";
                    user.updateUser(command);

                    MessageBox.Show("Password Changed Successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearPasswordTexts();
                }

            }
        }

        // clear password texts
        private void pcbClear_Click(object sender, EventArgs e)
        {
            clearPasswordTexts();
        }

        private void clearPasswordTexts()
        {
            txtCurrentPsw.Clear();
            txtNewPsw.Clear();
            txtNewPswR.Clear();
        }

        // show / hide password
        string hide_password_img_loc = "https://cdn-icons-png.flaticon.com/512/565/565655.png";
        string show_password_img_loc = "https://icons.veryicon.com/png/o/application/cloud-supervision-platform-vr10/show-password.png";

        private void show_hide_password(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            char p = '*';

            if (pcb.ImageLocation == hide_password_img_loc)
            {
                pcb.ImageLocation = show_password_img_loc;
                p = '\0';
            }
            else if (pcb.ImageLocation == show_password_img_loc)
                pcb.ImageLocation = hide_password_img_loc;


            if (pcb == pcbCurrentPsw)
                txtCurrentPsw.PasswordChar = p;

            else if (pcb == pcbNewPsw)
                txtNewPsw.PasswordChar = p;

            else if (pcb == pcbNewPswR)
                txtNewPswR.PasswordChar = p;
        }

        private void Buttons_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
        }
    }
}
