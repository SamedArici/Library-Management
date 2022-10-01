using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class Authors
    {
        public void addAuthor(string fullName,DateTime birthdate,string country,string image)
        {
            int author_id = GlobalMethods.getNewID("tblAuthors", "a_id");

            fullName = GlobalMethods.toTitleCase(fullName);
            country = GlobalMethods.toTitleCase(country);

            GlobalMethods.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblAuthors (a_id,fullname,birthdate,country,image) values " +
                "(@id,@name,@date,@country,@img)", GlobalMethods.connection);

            cmd.Parameters.AddWithValue("@id", author_id);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@date", birthdate);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@img", image);

            cmd.ExecuteNonQuery();

            GlobalMethods.connection.Close(); 
        }
    }
}
