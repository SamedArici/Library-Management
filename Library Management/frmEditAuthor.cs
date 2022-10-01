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
    public partial class frmEditAuthor : Form
    {
        public frmEditAuthor()
        {
            InitializeComponent();
        }

        public int author_id { get; set; } = 0;

        string defaultPicLocation = "https://secure.webtoolhub.com/static/resources/icons/set112/261419af.png";
        string selectedImageLocation = "";


        Authors authors = new Authors();

        private void frmAddAuthor_Load(object sender, EventArgs e)
        {
            if (author_id != 0)
            {
                fillAuthorInfos();
                btnEditAuthor.Text = "Update Author";

                // refresh icon
                pcbClear.ImageLocation = "https://icons.veryicon.com/png/o/miscellaneous/simple-icon/exchange-14.png";
            }
            else btnEditAuthor.Text = "Add Author";

        }


        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (author_id == 0)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to add the author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        authors.addAuthor(txtFullname.Text.Trim(), Convert.ToDateTime(mtxtBirthdate.Text).Date, txtCountry.Text.Trim(), selectedImageLocation);
                        MessageBox.Show("Author Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInfos();
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to update the author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string command = "update tblAuthors set fullname ='" + txtFullname.Text.Trim() + "' , birthdate ='" + Convert.ToDateTime(mtxtBirthdate.Text.ToString()).ToString("yyyy-MM-dd") + "' , " +
                            "country ='" + txtCountry.Text.Trim() + "' , image ='" + selectedImageLocation + "' where a_id ='" + author_id + "'";
                        GlobalMethods.updateTable(command);
                        MessageBox.Show("Author Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillAuthorInfos();
                    }
                }

            }
        }


        // check all the entered infos
        private bool check()
        {
            if (!areTextsFilled()) return false;

            else if (!isAuthorAlreadyExist()) return false;

            else if (!checkBirthdate()) return false;

            return true;
        }

        // are texts filled and select an image
        private bool areTextsFilled()
        {
            if(txtFullname.Text == "" || mtxtBirthdate.Text.Length != 10 || txtCountry.Text == "" || selectedImageLocation == "")
            {
                MessageBox.Show("Fill all the texts!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // is written author already exist or not
        private bool isAuthorAlreadyExist()
        {
            string command =  "select lower(fullname) from tblAuthors where fullname = '" + txtFullname.Text.Trim().ToLower() + "'";
            if (author_id != 0)
                command += " and a_id != '" + author_id + "'";

            bool result = GlobalMethods.isStringValueExist(command,txtFullname.Text.Trim().ToLower());

            if (result) MessageBox.Show("Entered Author Already Exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return !result;
        }

        // check author birthdate and age
        private bool checkBirthdate()
        {
            try
            {
                DateTime dt = DateTime.Parse(mtxtBirthdate.Text).Date;
                if (dt.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Invalid Date!", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if(dt.Year > DateTime.Now.Year - 4)
                {
                    MessageBox.Show("Author age is too small!", "Age Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Date!", "Date Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // choose image click. Select an image from the computer
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            selectedImageLocation = GlobalMethods.selectImageFromComputer(pcbImage);
        }

        // close form 
        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // clear all infos button
        private void pcbClear_Click(object sender, EventArgs e)
        {
            if (author_id == 0)
                clearInfos();
            else if (author_id != 0)
                fillAuthorInfos();
        }

        // clear all infos
        private void clearInfos()
        {
            pcbImage.ImageLocation = defaultPicLocation;
            selectedImageLocation = "";
            txtFullname.Clear();
            txtCountry.Clear();
            mtxtBirthdate.Clear();
        }


        // for moving the form
        Point lastPoint;
        private void frmAddAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmAddAuthor_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void fillAuthorInfos()
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("select * from tblAuthors where a_id ='"+author_id+"'",GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtFullname.Text = reader["fullname"].ToString();
                mtxtBirthdate.Text = Convert.ToDateTime(reader["birthdate"].ToString()).ToString("dd.MM.yyyy");
                txtCountry.Text = reader["country"].ToString();
                selectedImageLocation =  reader["image"].ToString();
                pcbImage.ImageLocation = selectedImageLocation;
            }
            reader.Close();
            GlobalMethods.connection.Close();
        }

        private void btnEditAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditAuthor.ForeColor = Color.Blue;
        }

        private void btnEditAuthor_MouseLeave(object sender, EventArgs e)
        {
            btnEditAuthor.ForeColor = Color.Black;
        }
    }
}
