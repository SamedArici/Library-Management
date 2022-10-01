using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        public string username { get; set; } = "";
        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
        }

        // minimize the form
        private void pcbMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalMethods.exitOrLogout(this);
        }

        private void btnShowMenu_Paint(object sender, PaintEventArgs e)
        {
            GlobalMethods.enableButtonPaint(e, btnShowMenu, "Home");
        }

        // show add book form
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm.ShowDialog();
        }

        // show add author form
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            frmEditAuthor frm = new frmEditAuthor();
            frm.ShowDialog();
        }

        //show edit categories form
        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.ShowDialog();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            frmBooks frm = new frmBooks();
            frm.username = username;
            frm.operation = "edit_book";
            frm.ShowDialog();
        }

        private void btnShowUserMenu_Click(object sender, EventArgs e)
        {
            frmUserMenu frm = new frmUserMenu();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors frm = new frmAuthors();
            frm.username = username;
            frm.ShowDialog();
        }

        Point lastPoint;
        private void frmAdminMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmAdminMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }
    }
}
