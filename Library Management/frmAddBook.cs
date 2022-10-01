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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }
        string defaultPicLocation = "https://www.iconpacks.net/icons/2/free-opened-book-icon-3163-thumb.png";
        string selectedImageLocation = "";


        Books books = new Books();
        private void frmBooks_Load(object sender, EventArgs e)
        {
            addValuesToCombobox();
        }

        private void addValuesToCombobox()
        {
            // add category names to combobox
            GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories order by name");

            // add author names to combobox
            GlobalMethods.addValuesToCombobox(cmbAuthors, "select fullname from tblAuthors order by fullname");
        }


        // for moving the form
        Point lastPoint;
        private void frmBooks_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmBooks_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // close form
        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // get selected author(s) id
        private List<int> getAuthorID()
        {
            List<int> id = new List<int>();
            foreach (var authorName in lstbxAuthors.Items)
                id.Add(GlobalMethods.getIntValueFromTable("select a_id from tblAuthors where fullname = '" + authorName + "'"));

            return id;
        }

        // get selected category(s) id
        private List<int> getCategoryID()
        {
            List<int> id = new List<int>();
            foreach (var categoryName in lstbxCategories.Items)
                id.Add(GlobalMethods.getIntValueFromTable("select c_id from tblCategories where name = '" + categoryName + "'"));

            return id;
        }

        // add book button click
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            getAuthorID();
            if (check())
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to add the book", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    List<int> author_id = getAuthorID();
                    List<int> category_id = getCategoryID();

                    // add book
                    books.addBookToTable(txtBook.Text.Trim(), Convert.ToInt32(txtPageCount.Text), Convert.ToDateTime(mtxtReleaseDate.Text), 
                        Convert.ToInt32(txtStock.Text),selectedImageLocation,author_id,category_id);

                    MessageBox.Show("The Book Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAllInfos();
                }
            }
        }

        private bool check()
        {
            if (areTextsFilled() == false)
                return false;

            else if (checkBookAuthor() == false)
                return false;

            else if (books.checkPageStockSize(Convert.ToInt32(txtPageCount.Text.Trim()),Convert.ToInt32(txtStock.Text.Trim())) == false)
                return false;

            else if (GlobalMethods.checkDate(mtxtReleaseDate.Text) == false)
                return false;

            return true;

            
        }
        
        private bool areTextsFilled() // are texts filled
        {
            if(txtBook.Text == "" || selectedImageLocation == "" || lstbxAuthors.Items.Count == 0 || lstbxCategories.Items.Count == 0
                 || mtxtReleaseDate.Text.Length != 10  || txtPageCount.Text == "" || txtStock.Text == "" )
            {
                MessageBox.Show("Fill all the Texts!", "Empty Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool checkBookAuthor()   // has the selected author(s) written the book before
        {

            string command = "select lower(tblBooks.name) from tblBooksAuthors " +
                             "inner join tblBooks on tblBooks.b_id = tblBooksAuthors.book_id " +
                             "where tblBooks.name ='" + txtBook.Text.Trim().ToLower() + "' and ( ";

            List<int> author_id = getAuthorID();
            string sep = "";
            foreach (var id in author_id)
            {
                command += sep+" tblBooksAuthors.author_id ='" + id + "'";
                sep = "or";
            }

            command += " )";

            bool result = GlobalMethods.isStringValueExist(command, txtBook.Text.Trim().ToLower());
            if (result == true)
                MessageBox.Show("The Book Already Written by the Selected Author(s)!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return !result;
        }

        private void StockPageTextboxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            selectedImageLocation =  GlobalMethods.selectImageFromComputer(pcbImage);
        }

        private void frmAddBook_Activated(object sender, EventArgs e)
        {
            addValuesToCombobox();
        }

        private void pcbAddNewAuthor_Click(object sender, EventArgs e)
        {
            frmEditAuthor frm = new frmEditAuthor();
            frm.ShowDialog();
        }

        private void pcbClear_Click(object sender, EventArgs e)
        {
            clearAllInfos();
        }

        private void clearAllInfos()
        {
            pcbImage.ImageLocation = defaultPicLocation;
            selectedImageLocation = "";

            txtBook.Clear();
            txtPageCount.Clear();
            txtStock.Clear();
            mtxtReleaseDate.Clear();

            cmbAuthors.SelectedItem = "";
            cmbAuthors.Text = "";

            cmbCategories.SelectedItem = "";
            cmbCategories.Text = "";

            lstbxAuthors.Items.Clear();
            lstbxCategories.Items.Clear();
        }

        // show categories form
        private void pcbAddNewCategory_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.ShowDialog();
        }

        private void cmbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbCategories.SelectedIndex != -1 & lstbxCategories.Items.Contains(cmbCategories.SelectedItem) == false)
            {
                lstbxCategories.Items.Add(cmbCategories.SelectedItem);
                cmbCategories.Text = "";
            }
        }

        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuthors.SelectedIndex != -1 & lstbxAuthors.Items.Contains(cmbAuthors.SelectedItem) == false)
            {
                lstbxAuthors.Items.Add(cmbAuthors.SelectedItem);
                cmbAuthors.Text = "";
            }
        }

        private void Listboxes_DoubleClick(object sender, EventArgs e)
        {
            ListBox lstbx = (ListBox)sender;

            if(lstbx.SelectedIndex != -1)
            {
                lstbx.Items.RemoveAt(lstbx.SelectedIndex);
            }
        }

        private void btnAddBook_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddBook.ForeColor = Color.Green;
        }

        private void btnAddBook_MouseLeave(object sender, EventArgs e)
        {
            btnAddBook.ForeColor = Color.Black;
        }
    }
}
