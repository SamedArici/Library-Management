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
using System.Xml.Linq;

namespace Library_Management
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }
        public string username { get; set; } = "";
        public string operation { get; set; } = "";

        public string command  = "select distinct tblBooks.b_id ,tblBooks.name,tblBooks.pageCount,tblBooks.releaseDate," +
                                "tblBooks.dateOfAddition,tblBooks.stock from tblBooks " +
                                "inner join tblBooksAuthors on tblBooksAuthors.book_id = tblBooks.b_id " +
                                "inner join tblAuthors on tblAuthors.a_id = tblBooksAuthors.author_id " +
                                "inner join tblBooksCategories on tblBooksCategories.book_id = tblBooks.b_id " +
                                "inner join tblCategories on tblCategories.c_id = tblBooksCategories.category_id ";

        string holdCommand = "";
        string holdOperation = "";

        private void frmBorrowingBooks_Load(object sender, EventArgs e)
        {
            
            if(operation == "borrow_book" ) rbtnMyBooks.Enabled = true;

            holdCommand = command;
            holdOperation = operation;

            addBooksToDatagridview(command);
            editDatagridviewColumns();
            addValuesToCombobox();
        }

        private void addValuesToCombobox()
        {
            // category names
            GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories order by name");

            // author names
            GlobalMethods.addValuesToCombobox(cmbAuthors, "select fullname from tblAuthors order by fullname");
        }

        // when open this form, load the books to the datagridview
        private void addBooksToDatagridview(string command)
        {
            GlobalMethods.addValuesToDatagridview(dtgvBooks, command + " order by tblBooks.name");

            dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Gold;
            dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewRow row in dtgvBooks.Rows)
            {
                int stock = Convert.ToInt32(row.Cells[5].Value.ToString());
                if (stock == 0)
                {
                    dtgvBooks.Rows[row.Index].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtgvBooks.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            //row grid default cell style
            if(dtgvBooks.Rows.Count > 0)
            {
                if (dtgvBooks.Rows[0].Cells[5].Value.ToString() == "0")
                {
                    dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Brown;
                    dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                }
            }

        }

        // edit datagridview
        private void editDatagridviewColumns()
        {
            dtgvBooks.Columns[0].Visible = false; //book id

            dtgvBooks.Columns[1].HeaderText = "Book";
            dtgvBooks.Columns[2].HeaderText = "Page Count";
            
            if(operation == "return_book")
            {
                dtgvBooks.Columns[3].HeaderText = "Borow Date";
                dtgvBooks.Columns[4].HeaderText = "Return Date";
                dtgvBooks.Columns[5].Visible = false; // stock
            }
            else
            {
                dtgvBooks.Columns[3].HeaderText = "Release Date";
                dtgvBooks.Columns[4].HeaderText = "Date of Addition";
                dtgvBooks.Columns[5].Visible = true;
            }

            dtgvBooks.Columns[5].HeaderText = "Stock";


            for (int i = 0; i <= 5; i++)
                dtgvBooks.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dtgvBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int stock = Convert.ToInt32(dtgvBooks.Rows[e.RowIndex].Cells[5].Value);
                DateTime returnDate = Convert.ToDateTime(dtgvBooks.Rows[e.RowIndex].Cells[4].Value);

                if ((stock == 0 & operation != "return_book") | (DateTime.Compare(DateTime.Now,returnDate) > 0 & operation == "return_book"))
                {
                    dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Brown;
                    dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Gold;
                    dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Operation!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // for moving the form
        Point lastPoint;
        private void frmBorrowingBooks_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmBorrowingBooks_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // search Books
        private void searchBooks() 
        {
            string search_command = " where ";
            if (operation == "return_book") search_command = " and ";

            // categories
            string sep = "";
            if (lstbxCategories.Items.Count > 0)
            {
                search_command += "(";
                foreach (string item in lstbxCategories.Items)
                {
                    search_command += sep + " tblCategories.name like '%" + item.ToString() + "%' ";
                    sep = " or ";
                }

                search_command += ") and "; //add and operator
            }

            // author name
            sep = "";
            if (lstbxAuthors.Items.Count > 0)
            {
                search_command += "(";
                foreach (string item in lstbxAuthors.Items)
                {
                    search_command += sep + " tblAuthors.fullname like '%" + item.ToString() + "%' ";
                    sep = " or ";
                }

                search_command += ") and "; //add and operator
            }

            // book name
            if (txtBookName.Text != "")
                search_command += " tblBooks.name like '%" + txtBookName.Text.Trim() + "%' and ";


            // out of stock
            if (rbtnHideOutOfStocks.Checked)
                search_command += " tblBooks.stock !='" + 0 + "' ";
            else if (rbtnOnlyOutOfStocks.Checked)
                search_command += " tblBooks.stock ='" + 0 + "' ";

                // or kısmını kontrol et !!!!!!!!!!!!!! gerek yok gibi or a
                string lastChars = search_command.Substring(search_command.Length - 4);
                if (lastChars == "and " || lastChars == " or ")
                    search_command = search_command.Substring(0, search_command.Length - 4);


            if (search_command == " where ")
                search_command = "";


            if (operation == "return_book") addMyBooksToDatagridview(command + search_command);
            else addBooksToDatagridview(command + search_command);

        }

        // selecting a cateogory from combobox
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cmbCategories.SelectedItem.ToString() + "";

            if (cmbCategories.SelectedIndex != -1 & lstbxCategories.Items.Contains(value) == false & value != "")
            {
                lstbxCategories.Items.Add(value);
                searchBooks();
                cmbCategories.Text = "";
            }

        }

        // selecting an author from combobox
        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cmbAuthors.SelectedItem.ToString() + "";

            if (cmbAuthors.SelectedIndex != -1 & lstbxAuthors.Items.Contains(value) == false & value != "")
            {
                lstbxAuthors.Items.Add(value);
                searchBooks();
                cmbAuthors.Text = "";
            }
        }

        // when double clicking the value on listbox, remove clicked value
        private void Listboxes_DoubleClick(object sender, EventArgs e)
        {
            ListBox lstbx = (ListBox)sender;
            if (lstbx.SelectedIndex != -1)
            {
                lstbx.Items.RemoveAt(lstbx.SelectedIndex);
                searchBooks();
            }
        }

        // search books when the user writing on textboxes
        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            searchBooks();
        }

        // search books by clicking radioButtons except my books radiobutton
        private void RadioButtons_Click(object sender, EventArgs e)
        {
            command = holdCommand;
            operation = holdOperation;
            addBooksToDatagridview(command);
            editDatagridviewColumns();
            searchBooks();
        }

        // clear listbox categories
        private void pcbClearCategories_Click(object sender, EventArgs e)
        {
            lstbxCategories.Items.Clear();
            cmbCategories.Text = "";
            searchBooks();
        }

        // clear listbox authors
        private void pcbClearAuthors_Click(object sender, EventArgs e)
        {
            lstbxAuthors.Items.Clear();
            cmbAuthors.Text = "";
            searchBooks();
        }

        // clicking a book
        private void dtgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var book_id = dtgvBooks.Rows[e.RowIndex].Cells[0].Value;
                int user_id = GlobalMethods.getIntValueFromTable("select u_id from tblUsers where username = '" + username + "'");

                frmMessageBox frm = new frmMessageBox();
                frm.book_id = Convert.ToInt32(book_id);
                frm.user_id = user_id;
                frm.operation = operation;
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Invalid Operation!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // The datagridview is refreshed when the user returns here after any tab.
        private void frmBorrowingBooks_Activated(object sender, EventArgs e)
        {
            if (operation == "return_book") addMyBooksToDatagridview(command);
            else addBooksToDatagridview(command);

            searchBooks();
            addValuesToCombobox();
        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void rbtnMyBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMyBooks.Checked)
            {
                operation = "return_book";
                int user_id = GlobalMethods.getIntValueFromTable("select u_id from tblUsers where username = '" + username + "' ");
                command = "select distinct tblBooks.b_id,tblBooks.name,tblBooks.pageCount,tblBooksUsers.borrowDate," +
                          "tblBooksUsers.returnDate,tblBooks.stock from tblBooks " +
                    "inner join tblBooksUsers on tblBooksUsers.book_id = tblBooks.b_id " +
                    "inner join tblBooksCategories on tblBooksCategories.book_id = tblBooksUsers.book_id "+
                    "inner join tblCategories on tblCategories.c_id = tblBooksCategories.category_id "+
                    "inner join tblBooksAuthors on tblBooksAuthors.book_id = tblBooksUsers.book_id "+
                    "inner join tblAuthors on tblAuthors.a_id = tblBooksAuthors.author_id "+
                    "where tblBooksUsers.user_id ='"+user_id+"' ";

                addMyBooksToDatagridview(command);
                editDatagridviewColumns();
                searchBooks();
            }

        }

        private void addMyBooksToDatagridview(string command)
        {
            GlobalMethods.addValuesToDatagridview(dtgvBooks, command + " order by tblBooks.name");


            dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Gold;
            dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.Black;


            foreach (DataGridViewRow row in dtgvBooks.Rows)
            {
                DateTime returnDate = Convert.ToDateTime(row.Cells[4].Value.ToString());
                if (DateTime.Compare(DateTime.Now, returnDate) > 0)
                {
                    dtgvBooks.Rows[row.Index].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtgvBooks.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            //row grid default cell style
            if(dtgvBooks.Rows.Count > 0)
            {
                DateTime firstRowReturnDate = Convert.ToDateTime(dtgvBooks.Rows[0].Cells[4].Value.ToString());
                if (DateTime.Compare(DateTime.Now, firstRowReturnDate) > 0)
                {
                    dtgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.Brown;
                    dtgvBooks.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                }
            }


        }


    }
}
