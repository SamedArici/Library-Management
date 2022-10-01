using System.Reflection.Metadata.Ecma335;

namespace Library_Management
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        User user = new User();


        // show / hide password
        string hide_password_img_loc = "https://icon-library.com/images/698902-icon-21-eye-hidden-512.png";
        string show_password_img_loc = "https://cdn1.iconfinder.com/data/icons/hawcons/32/698903-icon-22-eye-512.png";
        private void show_hide_password(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            char p = '*';

            if (pcb.ImageLocation == hide_password_img_loc)
            {
                pcb.ImageLocation = show_password_img_loc;
                p = '\0';
            }
            else if(pcb.ImageLocation == show_password_img_loc)
                pcb.ImageLocation = hide_password_img_loc;
            

            if (pcb == pcbPsw)
                txtPsw.PasswordChar = p;

            else if (pcb == pcbPswR)
                txtPswR.PasswordChar = p;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalMethods.exitApplication();
        }

        private void pcbClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll() //Clear All the texts
        {
            txtName.Clear();
            txtSurname.Clear();
            mtxtPhone.Clear();
            mtxtBirthdate.Clear();
            txtMail.Clear();
            txtUsername.Clear();
            txtPsw.Clear();
            txtPswR.Clear();
        }

        // clicking the register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                string name = GlobalMethods.toTitleCase(txtName.Text.Trim());
                string surname = GlobalMethods.toTitleCase(txtSurname.Text.Trim());
                string phone = mtxtPhone.Text;
                string birthdate = mtxtBirthdate.Text;

                int gender = 0;
                if (rbtnFemale.Checked == true)
                    gender = 1;

                string mail = txtMail.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPsw.Text.Trim();

                user.addUser(name, surname, phone, birthdate, gender, mail, username, password);

                MessageBox.Show("Registered Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();

                btnShowLoginForm.Focus();
            }
        }

        private bool checkValues()
        {
            if (emptyValueCheck() == false)
                return false;

            else if (user.valueLengthCheck(txtName.Text.Trim(),txtSurname.Text.Trim(),txtMail.Text.Trim(),txtPsw.Text.Trim()) == false)
                return false;

            else if (user.checkInvalidCharacters(txtName.Text.Trim(),txtSurname.Text.Trim(),txtUsername.Text.Trim()) == false)
                return false;

            else if (user.checkPasswords(txtPsw.Text.Trim(),txtPswR.Text.Trim()) == false)
                return false;

            else if (user.checkBirthdate(mtxtBirthdate.Text.Trim()) == false)
                return false;

            else if (user.checkMainValuesAreExist(mtxtPhone.Text.Trim(),txtMail.Text.Trim(),txtUsername.Text.Trim(),"") == true)
                return false;

            return true;
        }

        private bool emptyValueCheck() // Are Entered Values Empty
        {
            if(txtName.Text == "" || txtSurname.Text == "" || txtMail.Text == "" || txtUsername.Text == "" || txtPsw.Text == "" || txtPswR.Text == ""
                || mtxtBirthdate.Text.Length !=10 || mtxtPhone.Text.Length != 14)
            {
                MessageBox.Show("Fill all the texts!", "Empty Information(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        // moving the form
        Point lastPoint;
        private void frmRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        // show login form
        private void btnShowLoginForm_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        // minimize the form
        private void pcbMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // changing buttons color
        private void Buttons_Mouse_Move(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            changeButonColorEnterMove(btn);
        }
        private void Buttons_Mouse_leave(object sender, EventArgs e)
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
            if (btn == btnShowLoginForm)
                btn.ForeColor = Color.Cyan;

            else if (btn == btnRegister)
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

        private void btnShowRegisterForm_Paint(object sender, PaintEventArgs e)
        {
            GlobalMethods.enableButtonPaint(e, btnShowRegisterForm, "Register Form");
        }
    }
}