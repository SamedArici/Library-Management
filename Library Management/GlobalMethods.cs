using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = System.Windows.Forms.Application;

namespace Library_Management
{
    public static class GlobalMethods
    {
        public static SqlConnection connection = new SqlConnection("your_sql_connection");

        public static int getNewID(string table,string id_col_name)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from " + table, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 1;
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[id_col_name].ToString()) != count)
                    break;

                ++count;
            }
            reader.Close();
            connection.Close();

            return count;
        }

        public static string toTitleCase(string s)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
        }

        public static void exitApplication()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        public static void exitOrLogout(Form currentForm)
        {
            frmMessageBox frm = new frmMessageBox();
            frm.operation = "exit";
            frm.previous_frm = currentForm;
            frm.ShowDialog();
        }

        public static int getIntValueFromTable(string command)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return result;
        }

        public static string getStringValueFromTable(string command)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            string result = (string)cmd.ExecuteScalar();    

            connection.Close();

            return result;
        }

        public static DateTime getDatetimeValueFromTable(string command)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            DateTime result = (DateTime) cmd.ExecuteScalar();

            connection.Close();

            return result;
        }

        public static bool checkDate(string date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date).Date;
                if (dt.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Invalid Date!", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Date!", "Date Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool isIntValueExist(string sqlCommand) // if the int value exist, return true or return false.
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(sqlCommand,connection);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            if (count == 0)
                return false;

            return true;
        }

        public static bool isStringValueExist(string sqlCommand,string key) // if the string value exist, return true or return false.
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(sqlCommand, connection);

            string value = (string) cmd.ExecuteScalar();

            connection.Close();

            if (value != key)
                return false;

            return true;
        }

        public static void enableButtonPaint(PaintEventArgs e,Button btn,string btnText)
        {
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btn.Text = string.Empty;
            e.Graphics.DrawString(btnText, btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void addValuesToCombobox(ComboBox cmb,string command)
        {
            cmb.Items.Clear();

            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmb.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
        }

        public static string selectImageFromComputer(PictureBox pcb)
        {
            string selectedImage = "";
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (fileDialog.FileName.Length > 200) MessageBox.Show("Image size is too high!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        Bitmap bit = new Bitmap(fileDialog.FileName);
                        selectedImage = fileDialog.FileName;
                        pcb.Image = bit;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return selectedImage;
        }

        public static void addValuesToListbox(ListBox lstbx, string command)
        {
            lstbx.Items.Clear();

            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstbx.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
        }

        public static void addValuesToDatagridview(DataGridView dataGridView, string command)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        public static void updateTable(string command)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void removeFromTableById(string command, int id)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
