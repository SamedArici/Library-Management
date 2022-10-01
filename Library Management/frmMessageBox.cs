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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }
        Books books = new Books();

        public int book_id { get; set; } = 0;
        public int user_id { get; set; } = 0;

        public int author_id { get; set; } = 0;

        public Form previous_frm { get; set; } = new Form();

        string bookName = "";
        public string operation { get; set; } = "";
        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            if (book_id != 0)
                bookName = GlobalMethods.getStringValueFromTable("select name from tblBooks where b_id = '" + book_id + "'");

            if (operation == "borrow_book")
                setValues("Borrow", "Details", "Close", "Borrow or Show Details:\n" + bookName);

            else if (operation == "return_book")
                setValues("Return", "Details", "Close", "Return or Show Details:\n" + bookName);

            else if (operation == "edit_book")
                setValues("Edit", "Delete", "Details", "Edit, Delete or Show Details:\n"+bookName);

            else if (operation == "edit_author")
            {
                string author_name = GlobalMethods.getStringValueFromTable("select fullname from tblAuthors where a_id ='" + author_id + "'");
                setValues("Edit", "Delete", "Details", "Edit, Delete or Show Author's Informations:\n" + author_name);
            }

            else if (operation == "edit_user")
                setValues("Upgrade", "Delete", "Close", "1. Upgrade user's level to Admin\n2. Delete the User");

            else if (operation == "exit")
                setValues("Exit", "Logout", "Close", "1. Exit the Application\n2. Logout");
        }

        private void setValues(string op1,string op2,string op3,string header)
        {
            btnOp1.Text = op1;
            btnOp2.Text = op2;
            btnOp3.Text = op3;
            lblHeader.Text = header;
        }

        // 1. OPERATIONS 
        private void btnOp1_Click(object sender, EventArgs e)
        {
            if (operation == "borrow_book") // borrow button
                borrowBook();

            else if (operation == "return_book")
                returnBook();

            else if (operation == "edit_book")
                editBook();

            else if (operation == "edit_author")
                editAuthor();

            else if (operation == "edit_user")
                editUser();

            else if (operation == "exit")
                Application.Exit();
        }

        private void borrowBook() // borrowing a book operation
        {
            bool bookCheck = GlobalMethods.isIntValueExist("select * from tblBooksUsers where user_id = '" + user_id + "' and book_id = '" + book_id + "'");
            int capacity = GlobalMethods.getIntValueFromTable("select * from tblBooksUsers where user_id = '" + user_id + "'");
            int stock = GlobalMethods.getIntValueFromTable("select stock from tblBooks where b_id = '" + book_id + "'");

            // The maximum capacity of the user
            int maxCapacity = GlobalMethods.getIntValueFromTable("select numberOfBorrowingBooks from tblSettings");

            // check if is user has the selected book
            if (bookCheck)
                MessageBox.Show("You already have the selected book", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // check if is the user's capacity to borrow books full? 
            else if (capacity >= maxCapacity)
                MessageBox.Show("You have reached the book borrowing limit! To borrow books, return the books you have already borrowed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // check if the selected book is not out of stock
            else if (stock == 0)
                MessageBox.Show("You can't borrow the selected book because it is out of stock!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // borrow the book
            else
            {
                books.borrowBook(book_id, user_id);
                MessageBox.Show("The Book Borrowed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void returnBook() // returning a book operation
        {
            books.returnBook(book_id, user_id);
            MessageBox.Show("The Book Returned Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void editAuthor()
        {
            frmEditAuthor frm = new frmEditAuthor();
            frm.author_id = author_id;
            frm.ShowDialog();
        }

        private void editBook() // show edit book form
        {
            frmEditBook frm = new frmEditBook();
            frm.book_id = book_id;
            frm.ShowDialog();
        }

        private void editUser()
        {
            DialogResult dialog = MessageBox.Show("Are you sure do you want to upgrade the user's level to Admin?", "Upgrade Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                string command = "update tblUsers set u_level = '"+ 1 + "' where u_id ='" + user_id + "'";
                GlobalMethods.updateTable(command);
                MessageBox.Show("User's Level Updated Successfully!", "User's Level Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 2. OPERATIONS 
        private void btnOp2_Click(object sender, EventArgs e)
        {
            if (operation == "borrow_book" || operation == "return_book") //show details button
                showBookDetails();

            else if (operation == "edit_book")
                deleteBook();

            else if (operation == "edit_author")
                deleteAuthor();

            else if (operation == "edit_user")
                deleteUser();

            else if (operation == "exit")
                logout();

        }

        private void showBookDetails()
        {
            frmBookDetails frm = new frmBookDetails();
            frm.book_id = book_id;
            frm.ShowDialog();
        }

        private void deleteBook()
        {
            int bookCount = GlobalMethods.getIntValueFromTable("select count(book_id) from tblBooksUsers where book_id='" + book_id + "'");
            string message = "Are you sure do you want to delete the book?";
            if (bookCount != 0) message = "This book is used by <"+bookCount+"> users. Are you sure you want to delete it anyway?";

            DialogResult dialog = MessageBox.Show(message, "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                GlobalMethods.removeFromTableById("delete from tblBooks where b_id = @id", book_id);
                GlobalMethods.removeFromTableById("delete from tblBooksUsers where book_id = @id", book_id);
                GlobalMethods.removeFromTableById("delete from tblBooksAuthors where book_id = @id", book_id);
                GlobalMethods.removeFromTableById("delete from tblBooksCategories where book_id = @id", book_id);
                
                MessageBox.Show("Books Removed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void deleteAuthor()
        {
            int bookCount = GlobalMethods.getIntValueFromTable("select count(book_id) from tblBooksAuthors where author_id='" + author_id + "'");
            if (bookCount == 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to delete the author?", "Delete Author", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    GlobalMethods.removeFromTableById("delete from tblAuthors where a_id = @id", author_id);
                    GlobalMethods.removeFromTableById("delete from tblBooksAuthors where author_id = @id", author_id);
                    MessageBox.Show("Author Removed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else MessageBox.Show("To delete the author, you first need to delete all the author's books!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteUser()
        {
            int userBookCount = GlobalMethods.getIntValueFromTable("select count(user_id) from tblBooksUsers where user_id='" + user_id + "'");
            if (userBookCount == 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure do you want to delete the user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    GlobalMethods.removeFromTableById("delete from tblUsers where u_id = @id", user_id);
                    MessageBox.Show("User Removed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else MessageBox.Show("To delete the user, the user must return all the books that user borrowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void logout()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
            previous_frm.Close();
        }

        // 3. OPERATIONS 
        private void btnOp3_Click(object sender, EventArgs e)
        {
            if (operation == "borrow_book" || operation == "return_book" || operation == "exit" || operation == "edit_user") //close button
                this.Close();

            else if (operation == "edit_book")
                showBookDetails();

            else if (operation == "edit_author")
                showAuthorInfos();
        }

        private void showAuthorInfos()
        {
            frmAuthorInfos frm = new frmAuthorInfos();
            frm.author_id = author_id;
            frm.ShowDialog();
        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
