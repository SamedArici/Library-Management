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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        Books books = new Books();

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories where not c_id = '1' order by name");
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategories.SelectedIndex != -1) txtRename.Enabled = true;

            else txtRename.Enabled = false;
        }

        
        private void btnAddCategory_Click(object sender, EventArgs e) // add category
        {
            string c_name = txtNewCategoryName.Text.Trim();
            if (c_name == "")
                MessageBox.Show("Enter the new category name!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (GlobalMethods.isStringValueExist("select lower(name) from tblCategories where name = '" + c_name.ToLower() + "'", c_name.ToLower()))
                MessageBox.Show("Entered category already exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to add a new category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialog == DialogResult.Yes)
                {
                    int category_id = GlobalMethods.getNewID("tblCategories", "c_id");

                    // add the new category
                    GlobalMethods.connection.Open();

                    SqlCommand cmd = new SqlCommand("insert into tblCategories (c_id,name) values (@id,@name)", GlobalMethods.connection);
                    cmd.Parameters.AddWithValue("@id", category_id);
                    cmd.Parameters.AddWithValue("@name", GlobalMethods.toTitleCase(c_name));
                    cmd.ExecuteNonQuery();

                    GlobalMethods.connection.Close();

                    MessageBox.Show("New Category Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNewCategoryName.Clear();

                    GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories where not c_id = '1' order by name");
                }

            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e) // update category
        {
            if(cmbCategories.SelectedIndex == -1)
                MessageBox.Show("Select a category you want to update!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if(txtRename.Text == "")
                MessageBox.Show("Enter the new name of the selected category!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to update the selected category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int category_id = GlobalMethods.getIntValueFromTable("select c_id from tblCategories where name ='" + cmbCategories.SelectedItem.ToString() + "'");

                    GlobalMethods.connection.Open();

                    SqlCommand cmd = new SqlCommand("update tblCategories set name='" + GlobalMethods.toTitleCase(txtRename.Text.Trim()) + "' " +
                        "where c_id='" + category_id + "'", GlobalMethods.connection);
                    cmd.ExecuteNonQuery();
                    GlobalMethods.connection.Close();

                    txtRename.Clear();
                    cmbCategories.SelectedIndex = -1;
                    cmbCategories.Text = "";

                    GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories where not c_id = '1' order by name");

                    MessageBox.Show("Category name updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // delete category
        {
            if (cmbCategories.SelectedIndex == -1)
                MessageBox.Show("Select a category you want to update!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete the selected category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int category_id = GlobalMethods.getIntValueFromTable("select c_id from tblCategories where name ='" + cmbCategories.SelectedItem.ToString() + "'");


                    GlobalMethods.removeFromTableById("delete from tblCategories where c_id = @id", category_id);

                    // updating the categories of books with a deleted category (category_id = 1 means unknown category)
                    string command = "update tblBooksCategories set category_id ='" + 1 + "' where category_id ='" + category_id + "'";
                    GlobalMethods.updateTable(command);


                    cmbCategories.SelectedIndex = -1;
                    cmbCategories.Text = "";

                    GlobalMethods.addValuesToCombobox(cmbCategories, "select name from tblCategories where not c_id = '1' order by name");

                    MessageBox.Show("Category name deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // for moving the form
        Point lastPoint;
        private void frmCategories_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmCategories_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnAddCategory_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddCategory.ForeColor = Color.Green;
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.ForeColor = Color.Blue;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.ForeColor = Color.Red;
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
        }
    }
}
