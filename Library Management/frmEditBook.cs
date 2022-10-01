using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmEditBook : Form
    {
        public frmEditBook()
        {
            InitializeComponent();
        }

        public int book_id { get; set; } = 0;

        Books books = new Books();


        private void frmEditBook_Load(object sender, EventArgs e)
        {
            addBookInfos();

            addUserInfos();
        }

        private void addUserInfos()
        {
            // listbox users
            string command = "select tblUsers.name from  tblBooksUsers " +
                "inner join tblBooks on tblBooks.b_id = tblBooksUsers.book_id " +
                "inner join tblUsers on tblUsers.u_id = tblBooksUsers.user_id " +
                "where tblBooks.b_id = '" + book_id + "'";
            GlobalMethods.addValuesToListbox(lstbxUsers, command);
        }

        private void addBookInfos()
        {
            // Combobox Authors
            GlobalMethods.addValuesToCombobox(cmbAuthors, "select fullname from tblAuthors");
            cmbAuthors.Text = "";

            // Combobox Categories
            GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories where not name = 'Unknown'");
            cmbCategories.Text = "";

            // Listbox Authors
            string command = "select tblAuthors.fullname from tblBooksAuthors " +
                "inner join tblAuthors on tblAuthors.a_id = tblBooksAuthors.author_id " +
                "inner join tblBooks on tblBooks.b_id = tblBooksAuthors.book_id " +
                "where tblBooks.b_id = '" + book_id + "'";
            GlobalMethods.addValuesToListbox(lstbxAuthors, command);

            // Listbox Categories
            command = "select tblCategories.name from tblBooksCategories " +
                "inner join tblCategories on tblCategories.c_id = tblBooksCategories.category_id " +
                "inner join tblBooks on tblBooks.b_id = tblBooksCategories.book_id " +
                "where tblBooks.b_id = '" + book_id + "'";
            GlobalMethods.addValuesToListbox(lstbxCategories, command);

            // textboxes and book Picture
            command = "select  * from tblBooks where b_id = '" + book_id + "'";

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand(command, GlobalMethods.connection); //yazar adı ve kategori adı almam lazım
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtBookname.Text = reader["name"].ToString();
                txtPageCount.Text = reader["pageCount"].ToString();
                txtStock.Text = reader["stock"].ToString();
                mtxtDateOfAddition.Text =reader["dateOfAddition"].ToString();
                mtxtReleaseDate.Text = reader["releaseDate"].ToString();
                pcbBookImage.ImageLocation = reader["image"].ToString();
            }
            reader.Close();
            GlobalMethods.connection.Close();
        }


        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthors.SelectedIndex != -1 & lstbxAuthors.Items.Contains(cmbAuthors.SelectedItem) == false)
            {
                int id = GlobalMethods.getIntValueFromTable("select a_id from tblAuthors where fullname = '" + cmbAuthors.SelectedItem + "'");

                List<int> newSelectedAuthor = new List<int>();
                newSelectedAuthor.Add(id);
                books.addBooksAuthorsTable(book_id, newSelectedAuthor);
                newSelectedAuthor.Clear();

                lstbxAuthors.Items.Add(cmbAuthors.SelectedItem);
                cmbAuthors.Text = "";
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1 & lstbxCategories.Items.Contains(cmbCategories.SelectedItem) == false)
            {
                int id = GlobalMethods.getIntValueFromTable("select c_id from tblCategories where name = '" + cmbCategories.SelectedItem + "'");

                List<int> newSelectedCategory = new List<int>();
                newSelectedCategory.Add(id);
                books.addBooksCategoriesTable(book_id, newSelectedCategory);
                newSelectedCategory.Clear();

                lstbxCategories.Items.Add(cmbCategories.SelectedItem);
                cmbCategories.Text = "";
            }
        }


        private void pcbClearGbxUser_Click(object sender, EventArgs e)
        {
            clearUsersInfos();
        }

        // clear groupbox user infos 
        private void clearUsersInfos()
        {
            mtxtBorrowDate.Enabled = false;
            mtxtBorrowDate.Text = "";

            mtxtReturnDate.Enabled = false;
            mtxtReturnDate.Text = "";

            btnUpdateUserDates.Enabled = false;

            lstbxUsers.SelectedIndex = -1;
            selectedUserId = 0;

            txtSearchUser.Text = "";
            addUserInfos();
        }

        // refresh groupbox book infos 
        private void pcbRefreshGbxBook_Click(object sender, EventArgs e)
        {
            if (lstbxAuthors.Items.Count != 0 & lstbxCategories.Items.Count != 0) addBookInfos();


            else MessageBox.Show("The selected book must have at least 1 author and category!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // refresh groupbox users infos
        private void pcbRefreshGcbUsers_Click(object sender, EventArgs e)
        {
            addUserInfos();
        }

        private void txtStockPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            pcbBookImage.ImageLocation = GlobalMethods.selectImageFromComputer(pcbBookImage);
        }

        Point lastPoint;
        private void frmEditBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmEditBook_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        // update book infos
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to update the book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                string format = "yyyy-MM-dd";
                string releaseDate = Convert.ToDateTime(mtxtReleaseDate.Text.Trim()).ToString(format);
                string dateOfAddition = Convert.ToDateTime(mtxtDateOfAddition.Text.Trim()).ToString(format);

                // update book infos
                string command = "update tblBooks set name ='" + txtBookname.Text.Trim() + "' , pageCount ='" + Convert.ToInt32(txtPageCount.Text.Trim()) + "' , releaseDate ='" + releaseDate + "' , " +
                    "dateOfAddition ='" + dateOfAddition + "' , stock ='" + Convert.ToInt32(txtStock.Text.Trim()) + "' , image ='" + pcbBookImage.ImageLocation + "' " +
                    "where b_id = '" + book_id + "'";
                GlobalMethods.updateTable(command);

                    MessageBox.Show("The Book Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addBookInfos();
                }
            }
        }

        private bool check()
        {
            if (!areInfosEmpty()) return false;

            else if (!books.checkPageStockSize(Convert.ToInt32(txtPageCount.Text.Trim()), Convert.ToInt32(txtStock.Text.Trim()))) return false;

            else if (!GlobalMethods.checkDate(mtxtReleaseDate.Text)) return false;

            else if (!GlobalMethods.checkDate(mtxtDateOfAddition.Text)) return false;

            else if(!compareDates(mtxtReleaseDate.Text.Trim(),mtxtDateOfAddition.Text.Trim(),"Release date must not bigger than Date of Addition!")) return false;

            return true;
        }

        private bool areInfosEmpty()
        {
            bool result = true;

            // textboxes control
            if (txtBookname.Text == "" || txtPageCount.Text == "" || txtStock.Text == "" || mtxtDateOfAddition.Text.Length != 10 || mtxtDateOfAddition.Text.Length != 10)
                result = false;

            // listboxes control
            if (lstbxAuthors.Items.Count == 0 || lstbxCategories.Items.Count == 0)
                result = false;

            if (!result) MessageBox.Show("Please fill all the informations!", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        private bool compareDates(string date1, string date2, string errorMessage) // compare entered 2 dates
        {
            DateTime releaseDate = DateTime.Parse(date1).Date;
            DateTime dateOfAddition = DateTime.Parse(date2).Date;

            int result = DateTime.Compare(releaseDate, dateOfAddition);

            if (result > 0)
            {
                MessageBox.Show(errorMessage, "DATE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;

         }



        // delete selected author,category and user
        private void Listboxes_DoubleClick(object sender, EventArgs e)
        {
            ListBox lstbx = (ListBox)sender;

            if (lstbx == lstbxAuthors)
                removeItem(lstbxAuthors, "select a_id from tblAuthors where fullname = '" + lstbxAuthors.SelectedItem + "'", "delete from tblBooksAuthors where book_id = @bookid and author_id = @id");

            else if (lstbx == lstbxCategories)
                removeItem(lstbxCategories, "select c_id from tblCategories where name = '" + lstbxCategories.SelectedItem + "'", "delete from tblBooksCategories where book_id = @bookid and category_id = @id");

            else if (lstbx == lstbxUsers)
                removeItem(lstbxUsers, "select u_id from tblUsers where name = '" + lstbxUsers.SelectedItem + "'", "delete from tblBooksUsers where book_id = @bookid and user_id = @id");
        }

        private void removeItem(ListBox lstbx,string idCommand,string deleteCommand)
        {
            if (lstbx.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to remove:\n<" + lstbx.SelectedItem + "> ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int id = GlobalMethods.getIntValueFromTable(idCommand);
                    books.deleteFromTable(deleteCommand, book_id, id);

                    MessageBox.Show("<" + lstbx.SelectedItem + "> Removed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lstbx.Items.RemoveAt(lstbx.SelectedIndex);

                    if (lstbx == lstbxUsers) clearUsersInfos();
                }
            }
        }


        // listbox users click
        int selectedUserId = 0;
        private void lstbxUsers_Click(object sender, EventArgs e)
        {
            if (lstbxUsers.SelectedIndex != -1)
            {
                selectedUserId = GlobalMethods.getIntValueFromTable("select u_id from tblUsers where username = '" + lstbxUsers.SelectedItem + "'");

                mtxtBorrowDate.Text = GlobalMethods.getDatetimeValueFromTable("select borrowDate from tblBooksUsers where user_id='" + selectedUserId + "'").ToString("dd/MM/yyyy");
                mtxtReturnDate.Text = GlobalMethods.getDatetimeValueFromTable("select returnDate from tblBooksUsers where user_id='" + selectedUserId + "'").ToString("dd/MM/yyyy");

                mtxtBorrowDate.Enabled = true;
                mtxtReturnDate.Enabled = true;
                btnUpdateUserDates.Enabled = true;
            }
        }


        // update user dates (borrow date / return date)
        private void btnUpdateUserDates_Click(object sender, EventArgs e)
        {
            if (mtxtBorrowDate.Text.Length != 10 | mtxtReturnDate.Text.Length != 10) 
                MessageBox.Show("Please fill all the dates!", "DATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (GlobalMethods.checkDate(mtxtBorrowDate.Text.Trim()) & GlobalMethods.checkDate(mtxtReturnDate.Text.Trim()) & 
                compareDates(mtxtBorrowDate.Text.Trim(),mtxtReturnDate.Text.Trim(),"Borrow Date must not bigger than Return Date!"))
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to update selected user's dates?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    User user = new User();
                    string borrowDate = Convert.ToDateTime(mtxtBorrowDate.Text.Trim()).ToString("yyyy-MM-dd");
                    string returnDate = Convert.ToDateTime(mtxtReturnDate.Text.Trim()).ToString("yyyy-MM-dd");
                    string cmd = "update tblBooksUsers set borrowDate ='" + borrowDate + "' , returnDate ='" + returnDate + "' " +
                                 "where book_id = '" + book_id + "' and user_id ='" + selectedUserId + "'";
                    user.updateUser(cmd);
                    MessageBox.Show("User Dates Updated!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clearUsersInfos();
                }
                    
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != "")
            {
                // search users
                string command = "select tblUsers.name from  tblBooksUsers " +
                    "inner join tblBooks on tblBooks.b_id = tblBooksUsers.book_id " +
                    "inner join tblUsers on tblUsers.u_id = tblBooksUsers.user_id " +
                    "where tblBooks.b_id = '" + book_id + "' and tblUsers.username like '%"+txtSearchUser.Text.Trim()+"%'";
                GlobalMethods.addValuesToListbox(lstbxUsers, command);
            }
            else addUserInfos();
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
