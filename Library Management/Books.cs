using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management
{
    public class Books
    {

        // Add a book to the tblBooks table
        public void addBookToTable(string bookName,int pageCount,DateTime releaseDate,int stock, string image, List<int> author_id,List<int> category_id)
        {
            DateTime dateOfAddition = DateTime.Now.Date;
            int book_id = GlobalMethods.getNewID("tblBooks", "b_id");

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblBooks (b_id,name,pageCount,releaseDate,dateOfAddition,stock,image) values " +
                "(@id,@name,@page,@release_date,@date_of_addition,@stock,@image)", GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@id", book_id);
            cmd.Parameters.AddWithValue("@name", bookName);
            cmd.Parameters.AddWithValue("@page", pageCount);
            cmd.Parameters.AddWithValue("@release_date", releaseDate);
            cmd.Parameters.AddWithValue("@date_of_addition", dateOfAddition);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@image", image);

            cmd.ExecuteNonQuery();
            GlobalMethods.connection.Close();

            addBooksAuthorsTable(book_id, author_id);
            addBooksCategoriesTable(book_id, category_id);
        }

        public void addBooksAuthorsTable(int book_id, List<int> author_id)
        {
            string command = "insert into tblBooksAuthors (book_id,author_id) values ";
            string sep = "";

            for(int i = 0; i < author_id.Count; i++)   
            {
                command += sep + $@"(@b_id{i},@a_id{i})";
                sep = ",";
            }

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand(command,GlobalMethods.connection);

            for(int i = 0; i<author_id.Count; ++i)
            {
                cmd.Parameters.AddWithValue("@b_id"+i.ToString(), book_id);
                cmd.Parameters.AddWithValue("@a_id"+i.ToString(), author_id[i]);
            }


            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }

        public void addBooksCategoriesTable(int book_id, List<int> category_id)
        {
            string command = "insert into tblBooksCategories (book_id,category_id) values ";
            string sep = "";

            for (int i = 0; i < category_id.Count; i++)
            {
                command += sep + $@"(@b_id{i},@c_id{i})";
                sep = ",";
            }

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand(command, GlobalMethods.connection);

            for (int i = 0; i < category_id.Count; ++i)
            {
                cmd.Parameters.AddWithValue("@b_id" + i.ToString(), book_id);
                cmd.Parameters.AddWithValue("@c_id" + i.ToString(), category_id[i]);
            }

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }

        public void borrowBook(int book_id,int user_id)
        {
            DateTime borrowDate = DateTime.Now.Date;

            int days = GlobalMethods.getIntValueFromTable("select returnBookDays from tblSettings");

            DateTime returnDate = borrowDate.AddDays(days);

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblBooksUsers (book_id,user_id,borrowDate,returnDate) values (@b_id,@u_id,@b_date,@r_date)", GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@b_id", book_id);
            cmd.Parameters.AddWithValue("@u_id", user_id);
            cmd.Parameters.AddWithValue("@b_date", borrowDate);
            cmd.Parameters.AddWithValue("@r_date", returnDate);

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();

            // update stock
            int stock = GlobalMethods.getIntValueFromTable("select stock from tblBooks where b_id = '" + book_id + "'") - 1;
            GlobalMethods.updateTable("update tblBooks set stock = '" + stock + "' where b_id = " + book_id);
        }

        public void returnBook(int book_id,int user_id)
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("delete from tblBooksUsers where book_id = @b_id and user_id = @u_id", GlobalMethods.connection);
            
            cmd.Parameters.AddWithValue("@b_id", book_id);
            cmd.Parameters.AddWithValue("@u_id", user_id);

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();

            // update stock
            int stock = GlobalMethods.getIntValueFromTable("select stock from tblBooks where b_id = '" + book_id + "'") + 1;
            GlobalMethods.updateTable("update tblBooks set stock = '" + stock + "' where b_id = " + book_id);
        }

        public bool checkPageStockSize(int pageCount, int stock) // check page,stock size
        {
            bool result = true;

            if (pageCount <= 20)
            {
                MessageBox.Show("Page Count is too low", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (stock == 0)
            {
                MessageBox.Show("Stock size cannot be 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            // if page count bigger than small int
            if (pageCount > Int16.MaxValue)
            {
                MessageBox.Show("Page Count is too High", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            // if page count bigger than small int
            if (stock > int.MaxValue)
            {
                MessageBox.Show("Stock Size is too High", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        public void deleteFromTable(string command, int bookid,int id)  // delete from tblBooksAuthors / tblBooksCategories / tblBooksUsers
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand(command, GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@bookid", bookid); //bookid
            cmd.Parameters.AddWithValue("@id", id); // author_id or category_id or user_id

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }
    }
}
