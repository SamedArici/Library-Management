using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        string command = "select u_id,name,surname,username,mail,phone,gender from tblUsers ";
        private void frmUsers_Load(object sender, EventArgs e)
        {
            GlobalMethods.addValuesToDatagridview(dtgvUsers, command + "  where u_level ='0' order by name");
            editDatagridviewColumns();
            GlobalMethods.addValuesToCombobox(cmbUsers, "select username from tblUsers");

        }

        private void editDatagridviewColumns()
        {
            dtgvUsers.Columns[0].Visible = false; // user id
            dtgvUsers.Columns[1].HeaderText = "Name";
            dtgvUsers.Columns[2].HeaderText = "Surname";
            dtgvUsers.Columns[3].HeaderText = "Username";
            dtgvUsers.Columns[4].HeaderText = "Mail";
            dtgvUsers.Columns[5].HeaderText = "Phone";
            dtgvUsers.Columns[6].HeaderText = "Female";

            for (int i = 0; i <= 6; i++)
                dtgvUsers.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void frmUsers_Activated(object sender, EventArgs e)
        {
            GlobalMethods.addValuesToDatagridview(dtgvUsers, command + " order by name");
            GlobalMethods.addValuesToCombobox(cmbUsers, "select username from tblUsers");
            searchUser();
        }


        private void searchUser()
        {
            string searchCommand = " where u_level = '0' ";
            if (rbtnOnlyAdmins.Checked)
                searchCommand = " where u_level = '1' ";

            if (txtName.Text != "") searchCommand += " and name like '%" + txtName.Text.Trim() + "%' ";

            if (txtSurname.Text != "") searchCommand += " and surname like '%" + txtSurname.Text.Trim() + "%' ";

            if (cmbUsers.SelectedIndex != -1) searchCommand += " and username like '%" + cmbUsers.SelectedItem.ToString() + "%' ";
             
            if (txtMail.Text != "") searchCommand += " and mail like '%" + txtMail.Text.Trim() + "%' ";

            if (mtxtPhone.Text.Length == 14) searchCommand += " and phone like '%" + mtxtPhone.Text.Trim() + "%' ";

            if (rbtnAll.Checked == false) searchCommand +=  " and gender like '%" + Convert.ToInt32(rbtnFemale.Checked) + "%' ";


            GlobalMethods.addValuesToDatagridview(dtgvUsers, command + searchCommand + " order by name");
        }

        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            searchUser();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex != -1) searchUser();
        }

        private void cmbUsers_TextChanged(object sender, EventArgs e)
        {
            if(cmbUsers.Text == "")
            {
                cmbUsers.SelectedIndex = -1;
                searchUser();
            }
        }

        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButtons_Click(object sender, EventArgs e)
        {
            searchUser();
        }

        private void pcbClearTexts_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            cmbUsers.Text = "";
            txtMail.Clear();
            mtxtPhone.Clear();
            rbtnAll.Checked = true;
        }

        private void dtgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(rbtnOnlyAdmins.Checked == false)
                {
                    int user_id = (int)dtgvUsers.Rows[e.RowIndex].Cells[0].Value;

                    frmMessageBox frm = new frmMessageBox();
                    frm.user_id = user_id;
                    frm.operation = "edit_user";
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Operation!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
