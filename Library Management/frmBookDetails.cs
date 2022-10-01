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
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }

        public int book_id { get; set; } = 0;

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            addBookInfos();
        }

        private void addBookInfos()
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("select * from tblBooks where b_id ='"+book_id+"'",GlobalMethods.connection);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblBookName.Text = reader["name"].ToString();
                lblDateOfAddition.Text = reader["dateOfAddition"].ToString();
                lblPageCount.Text = reader["pageCount"].ToString();
                lblReleaseDate.Text = reader["releaseDate"].ToString();
                lblStock.Text = reader["stock"].ToString();
                pcbBook.ImageLocation = reader["image"].ToString();
            }
            reader.Close();
            GlobalMethods.connection.Close();

            editDates();

            // Add Authors to the listbox authors
            string command = "select tblAuthors.fullname from tblBooksAuthors inner join tblBooks on tblBooks.b_id = tblBooksAuthors.book_id " +
                             "inner join tblAuthors on tblAuthors.a_id = tblBooksAuthors.author_id where tblBooksAuthors.book_id ='" + book_id + "'";
            GlobalMethods.addValuesToListbox(lstbxAuthors, command);

            // Add Categories to the listbox categories
            command = "select tblCategories.name from tblBooksCategories inner join tblBooks on tblBooksCategories.book_id = tblBooks.b_id " +
                "inner join tblCategories on tblBooksCategories.category_id = tblCategories.c_id where tblBooksCategories.book_id ='"+book_id + "'";
            GlobalMethods.addValuesToListbox(lstbxCategories, command);
        }

        private void editDates() // convert dates shorter
        {
            Label[] dates = { lblDateOfAddition, lblReleaseDate};

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i].Text = dates[i].Text.Substring(0, dates[i].Text.Length - 9);
            }

        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void frmBookDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmBookDetails_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
