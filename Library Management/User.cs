using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Library_Management
{
    public class User
    {
        public void addUser(string name,string surname,string phone,string birthdate,int gender,string mail,string username,string psw) // add a user to the database
        {
            int u_level = 0;
            int p_id = GlobalMethods.getNewID("tblUsers", "u_id");
            DateTime date = DateTime.Parse(birthdate).Date;

            //create salt password and hashed the password
            Guid obj = Guid.NewGuid();
            string saltpsw = obj.ToString();
            string hashedpsw = ComputeSha256Hash(saltpsw + psw);


            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblUsers (u_id,name,surname,phone,mail,birthdate,gender,u_level,username,password,saltPassword) values" +
                " (@u_id,@name,@surname,@phone,@mail,@birthdate,@gender,@u_level,@username,@password,@saltpassword)", GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@u_id", p_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@birthdate", date);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@u_level", u_level);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", hashedpsw);
            cmd.Parameters.AddWithValue("@saltpassword", saltpsw);

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }

        public string ComputeSha256Hash(string rawData) // convert password to sha256
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool areUsernameAndPasswordExist(string username,string password) // check the entered username and password values from the login form, if the user exist or not.
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("select username,password,saltPassword from tblUsers", GlobalMethods.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            bool exist = false;

            while (reader.Read())
            {
                if (reader["username"].ToString() == username)
                {
                    string psw = ComputeSha256Hash(reader["saltPassword"].ToString() + password);

                    if (psw == reader["password"].ToString())
                        exist = true;

                    break;
                }
            }
            reader.Close();
            GlobalMethods.connection.Close();

            return exist;
        }

        public bool valueLengthCheck(string name,string surname,string mail,string psw) // Check Entered Values Length for register or edit user
        {
            bool check = true;

            if (name.Length < 2)
            {
                MessageBox.Show("Name length must be at least 2 characters!", "Name Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            if (surname.Length < 2)
            {
                MessageBox.Show("Surname length must be at least 2 characters!", "Surname Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            if (mail.Length < 10)
            {
                MessageBox.Show("Mail length must be at least 10 characters!", "Email Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            if (psw.Length < 4)
            {
                MessageBox.Show("Password length must be at least 4 characters!", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            return check;

        }

        public bool checkInvalidCharacters(string name,string surname,string username) // Check Invalid Characters in Some Entered Values
        {
            bool check = true;
            char[] invalidCharacters = { '*', '/', '-', '|', '^', '+', '.', '{', '}', '=', '&', '%', '!', '<', '>', '?', 'é', '½', '£', '#', '$', '[', ']' };


            foreach (char c in invalidCharacters)
            {
                if (name.Contains(c))
                {
                    MessageBox.Show("Use of invalid characters in Name!", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                    break;
                }
                else if (surname.Contains(c))
                {
                    MessageBox.Show("Use of invalid characters in Surname!", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                    break;
                }
                else if (username.Contains(c))
                {
                    MessageBox.Show("Use of invalid characters in Username!", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                    break;
                }
            }

            return check;
        }

        public bool checkPasswords(string psw,string pswR) // check entered passwords for register or edit user
        {

            if (psw != pswR)
            {
                MessageBox.Show("Entered Passwords are not Match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkBirthdate(string birthdate) // check entered birthdate. Min age must be 4.
        {
            try
            {
                DateTime dt = DateTime.Parse(birthdate).Date;
                if (dt.Year > DateTime.Now.Year || DateTime.Now.Year - dt.Year <= 3)
                {
                    MessageBox.Show("Invalid Birthdate!", "Birthdate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Birthdate!", "Birthdate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkMainValuesAreExist(string phone,string mail,string username,string condition) // check if username,mail or phone using by another user.
        {
            bool check = false;

            Dictionary<string, string> values = new Dictionary<string, string>(); // key = 1,value = 2
            values.Add("phone", phone);
            values.Add("mail", mail);
            values.Add("username", username.ToLower());


            foreach (var v in values)
            {
                string command = "select count(lower(username)) from tblUsers where " + v.Key + " = '" + v.Value + "' " +condition;

                if (GlobalMethods.isIntValueExist(command))
                {
                    MessageBox.Show("Entered " + v.Key + " already using!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = true;
                }

            }

            return check;
        }

        public void updateUser(string command)
        {
            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand(command, GlobalMethods.connection);

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close();
        }
    }
}
