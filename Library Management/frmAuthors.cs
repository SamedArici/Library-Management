using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }
        public string username { get; set; } = "";

        string command = "select * from tblAuthors ";
        private void frmAuthors_Load(object sender, EventArgs e)
        {
            GlobalMethods.addValuesToDatagridview(dtgvAuthors, command + " order by fullname");
            GlobalMethods.addValuesToCombobox(cmbAuthors, "select fullname from tblAuthors");
            editDatagridviewColumns();
        }

        private void editDatagridviewColumns()
        {
            dtgvAuthors.Columns[0].Visible = false; // hide author_id
            dtgvAuthors.Columns[1].HeaderText = "Fullname";
            dtgvAuthors.Columns[2].HeaderText = "Birthdate";
            dtgvAuthors.Columns[3].HeaderText = "Country";
            dtgvAuthors.Columns[4].Visible = false; // hide image

            for (int i = 0; i <= 4; i++)
                dtgvAuthors.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        Point lastPoint;
        private void frmAuthors_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void frmAuthors_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchAuthor()
        {
            string searchCommand = " where ";
            string sep = "";
            if (cmbAuthors.SelectedIndex != -1)
            {
                searchCommand += " fullname like '%" + cmbAuthors.SelectedItem.ToString() + "%' ";
                sep = " and ";
            }

            if(mtxtBirthdate.Text.Length == 10)
            {
                searchCommand += sep + " birthdate like '%" + Convert.ToDateTime(mtxtBirthdate.Text.Trim()).ToString("yyyy-MM-dd") + "%' ";
                sep = " and ";
            }

            if (txtCountry.Text != "") searchCommand += sep + " country like '%" + txtCountry.Text.Trim() + "%' ";

            if (searchCommand == " where ") searchCommand = "";

            GlobalMethods.addValuesToDatagridview(dtgvAuthors, command+searchCommand + " order by fullname");
        }

        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuthors.SelectedIndex != -1)
            {
                searchAuthor();
            }
        }

        private void cmbAuthors_TextChanged(object sender, EventArgs e)
        {
            if (cmbAuthors.Text == "") searchAuthor();
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            searchAuthor();
        }

        private void mtxtBirthdate_TextChanged(object sender, EventArgs e)
        {
            searchAuthor();
        }

        private void dtgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int user_level = GlobalMethods.getIntValueFromTable("select u_level from tblUsers where username = '" + username + "'");
                int author_id = (int)dtgvAuthors.Rows[e.RowIndex].Cells[0].Value;
                if (user_level != 1)
                {
                    frmAuthorInfos frm = new frmAuthorInfos();
                    frm.author_id = author_id;
                    frm.ShowDialog();
                }
                else
                {
                    frmMessageBox frm = new frmMessageBox();
                    frm.operation = "edit_author";
                    frm.author_id = author_id;
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Operation!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAuthors_Activated(object sender, EventArgs e)
        {
            GlobalMethods.addValuesToDatagridview(dtgvAuthors, command + " order by fullname");
            GlobalMethods.addValuesToCombobox(cmbAuthors, "select fullname from tblAuthors");
        }
    }
}
