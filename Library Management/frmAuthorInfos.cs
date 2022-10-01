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
    public partial class frmAuthorInfos : Form
    {
        public frmAuthorInfos()
        {
            InitializeComponent();
        }
        public int author_id { get; set; } = 0;
        private void frmAuthorInfos_Load(object sender, EventArgs e)
        {
            // add selected author personal infos
            fillPersonalInfos();

            // add author's books
            string command = "select tblBooks.name from tblBooksAuthors " +
                             "inner join tblBooks on tblBooks.b_id = tblBooksAuthors.book_id " +
                             "inner join tblAuthors on tblAuthors.a_id = tblBooksAuthors.author_id " +
                             "where tblAuthors.a_id = '" + author_id + "'";
            GlobalMethods.addValuesToListbox(lstbxAuthorBooks, command);
        }



        private void fillPersonalInfos()
        {
            GlobalMethods.connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblAuthors where a_id ='" + author_id + "'", GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblAuthor.Text = reader["fullname"].ToString();
                if (lblAuthor.Width > 400) lblAuthornameUnderline.Size = new Size(lblAuthor.Width, 1);

                lblBirthdate.Text = Convert.ToDateTime(reader["birthdate"].ToString()).ToShortDateString();
                lblCountry.Text = reader["country"].ToString();
                pcbImage.ImageLocation = reader["image"].ToString();
            }
            reader.Close();
            GlobalMethods.connection.Close();
        }


        private void pcbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Point lastPoint;
        private void frmAuthorInfos_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmAuthorInfos_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

    }
}
