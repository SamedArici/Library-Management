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
    public partial class frmUserMenu : Form
    {
        public frmUserMenu()
        {
            InitializeComponent();
        }
        public string username { get; set; } = "";
        private void frmUserMenu_Load(object sender, EventArgs e)
        {
            fillUserInfos();
            int user_level = GlobalMethods.getIntValueFromTable("select u_level from tblUsers where username ='" + username + "'");
            if (user_level == 1) btnShowAdminMenu.Visible = true;
        }

        private void fillUserInfos()
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("select * from tblUsers where username = '" + username + "'", GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                lblName.Text = reader["name"].ToString();
                lblSurname.Text = reader["surname"].ToString();
                lblUsername.Text = username;
                lblPhone.Text = reader["phone"].ToString();
                lblEmail.Text = reader["mail"].ToString();

                lblBirthdate.Text = Convert.ToDateTime(reader["birthdate"].ToString()).ToString("dd.MM.yyyy");

                if (reader["gender"].ToString() == "False")
                    lblGender.Text = "Male";
                else lblGender.Text = "Female";
            }

            reader.Close();
            GlobalMethods.connection.Close();
        }

        private void pcbMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void frmUserMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmUserMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalMethods.exitOrLogout(this);
        }

        private void btnShowBorrowingBooks_Click(object sender, EventArgs e)
        {
            frmBooks frm = new frmBooks();
            frm.username = username;
            frm.operation = "borrow_book";
            frm.ShowDialog();
        }

        private void btnShowMenu_Paint(object sender, PaintEventArgs e)
        {
            GlobalMethods.enableButtonPaint(e, btnShowMenu, "Home");
        }

        private void frmUserMenu_Activated(object sender, EventArgs e)
        {
            fillUserInfos();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frmBooks frm = new frmBooks();
            frm.username = username;
            frm.operation = "borrow_book";
            frm.ShowDialog();
        }

        private void pcbEditInfos_Click(object sender, EventArgs e)
        {
            int user_id = GlobalMethods.getIntValueFromTable("select u_id from tblUsers where username ='" + username + "'");

            frmEditUserInfos frm = new frmEditUserInfos();
            frm.user_id = user_id;
            frm.ShowDialog();
        }

        private void btnShowAdminMenu_Click(object sender, EventArgs e)
        {
            frmAdminMenu frm = new frmAdminMenu();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void btnShowAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors frm = new frmAuthors();
            frm.username = username;
            frm.ShowDialog();
        }

        // changing buttons colors
        private void Buttons_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnExit) btn.ForeColor = Color.Red;

            else btn.ForeColor = Color.Cyan;
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnExit)
                btn.ForeColor = Color.IndianRed;

            else btn.ForeColor = Color.White;
        }
    }
}
