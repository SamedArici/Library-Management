using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        User user = new User();

        string cpu_id = "";
        int wrong_attempt = 0;

        int max_attempt = 0;
        int reset_wrong_attempts = 0;
        // show / hide password 
        string hide_password_img_loc = "https://icon-library.com/images/698902-icon-21-eye-hidden-512.png";
        string show_password_img_loc = "https://cdn1.iconfinder.com/data/icons/hawcons/32/698903-icon-22-eye-512.png";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cpu_id = getCPUId();
            if (!GlobalMethods.isStringValueExist("select CPUid from tblTryToLogin where CPUid ='" + cpu_id + "'", cpu_id))
                addCPUidToTable();

            max_attempt = GlobalMethods.getIntValueFromTable("select maxWrongAttempts from tblSettings");
            reset_wrong_attempts = GlobalMethods.getIntValueFromTable("select resetWrongAttempts from tblSettings");
        }

        private void addCPUidToTable()
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblTryToLogin (CPUid,dateOfTry,waitingTimeByHours) values (@id,@date,@time)",GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@id", cpu_id);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime("01.01.1900").ToString());
            cmd.Parameters.AddWithValue("@time", 0);
            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }

        private void updateLastTryToLogin(string lastLogin) 
        {
            string command = "update tblTryToLogin set dateOfTry ='" + lastLogin + "' where CPUid ='" + cpu_id + "'";
            GlobalMethods.updateTable(command);
        }

        private string getCPUId()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = (string) mo.Properties["processorID"].Value;
                    break;
                }
            }
            return cpuInfo;
        }

        private bool isWaitingTimePassed()
        {
            DateTime lastTryToLogin = GlobalMethods.getDatetimeValueFromTable("select dateOfTry from tblTryToLogin where CPUid ='" + cpu_id + "'");
            int waitingTime = GlobalMethods.getIntValueFromTable("select waitingTimeByHours from tblTryToLogin where CPUid = '"+cpu_id + "'");

            lastTryToLogin = lastTryToLogin.AddHours(waitingTime);
            int result = DateTime.Compare(DateTime.Now,lastTryToLogin);
            if (result < 0)
            {
                MessageBox.Show("You've tried too many times to try login!\nYou'll have to wait until time is " + lastTryToLogin, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void updateAttempt()
        {
            DateTime lastTryToLogin = GlobalMethods.getDatetimeValueFromTable("select dateOfTry from tblTryToLogin where CPUid ='" + cpu_id + "'");
            lastTryToLogin = lastTryToLogin.AddMinutes(reset_wrong_attempts);
            int result = DateTime.Compare(DateTime.Now, lastTryToLogin);
            if (result > 0) wrong_attempt = 0;
        }

        private void blockThisPcTemporary() //if you login incorrectly 4 times in a row, you cannot log in for 24 hours
        {
            int hours = GlobalMethods.getIntValueFromTable("select waitingTime from tblSettings");
            string command = "update tblTryToLogin set waitingTimeByHours ='" + hours + "' where CPUid ='" + cpu_id + "'";
            GlobalMethods.updateTable(command);

            MessageBox.Show("You've tried too many times to try login!\nYou'll have to wait until time is " + DateTime.Now.AddHours(hours), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // click login button
        private void btnLogin_Click(object sender, EventArgs e) 
        {
            if (isWaitingTimePassed())
            {
                bool checkUser = user.areUsernameAndPasswordExist(txtUsername.Text.Trim(), txtPsw.Text.Trim());
                if (checkUser == false)
                {
                    updateAttempt();

                    MessageBox.Show("Username or Password are not correct!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ++wrong_attempt;

                    if (wrong_attempt == max_attempt) blockThisPcTemporary();

                    updateLastTryToLogin(DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                }


                else
                {
                    updateLastTryToLogin(Convert.ToDateTime("01.01.1900").ToString());
                    GlobalMethods.updateTable("update tblTryToLogin set  waitingTimeByHours ='0' where CPUid = '"+cpu_id+"'");

                    int userLevel = GlobalMethods.getIntValueFromTable("select u_level from tblUsers where username = '" + txtUsername.Text.Trim() + "'");

                    // if userlevel == 0, go to the userMenu form
                    if (userLevel == 0)
                    {
                        frmUserMenu frm = new frmUserMenu();
                        frm.username = txtUsername.Text.Trim();
                        frm.Show();
                        this.Hide();
                    }

                    // if the userLevel == 1, go to the Admin Form
                    else if (userLevel == 1)
                    {
                        frmAdminMenu frm = new frmAdminMenu();
                        frm.username = txtUsername.Text.Trim();
                        frm.Show();
                        this.Hide();
                    }
                }

            }
        }


        // showing the register form
        private void btnShowRegisterForm_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Location = new Point(lastPoint.X, lastPoint.Y);
            frm.Show();
            this.Hide();
        }

        // exit button 
        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalMethods.exitApplication();
        }

        // moving the form
        Point lastPoint;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pcbShowPsw_Click(object sender, EventArgs e)
        {
            char p = '*';

            if (pcbShowPsw.ImageLocation == hide_password_img_loc)
            {
                pcbShowPsw.ImageLocation = show_password_img_loc;
                p = '\0';
            }
            else pcbShowPsw.ImageLocation = hide_password_img_loc;

            txtPsw.PasswordChar = p;

        }

        // clear texts
        private void pcbClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPsw.Clear();
        }

        // changing buttons colors
        private void Butons_Mouse_Move(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            changeButonColorEnterMove(btn);
        }

        private void Buttons_Mouse_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            changeButtonColorLeave(btn);
        }

        private void Buttons_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            changeButonColorEnterMove(btn);
        }
        private void Buttons_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            changeButtonColorLeave(btn);
        }

        private void changeButonColorEnterMove(Button btn)
        {
            if (btn == btnShowRegisterForm)
                btn.ForeColor = Color.Cyan;

            else if (btn == btnLogin)
                btn.ForeColor = Color.Gold;

            else if (btn == btnExit)
                btn.ForeColor = Color.Red;
        }

        private void changeButtonColorLeave(Button btn)
        {
            if (btn == btnExit)
                btn.ForeColor = Color.IndianRed;

            else btn.ForeColor = Color.White;
        }


        // minimize the form
        private void pcbMinimizeBox_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowLoginForm_Paint(object sender, PaintEventArgs e)
        {
            GlobalMethods.enableButtonPaint(e, btnShowLoginForm, "Login Form");
        }


    }
}
