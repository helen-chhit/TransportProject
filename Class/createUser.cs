using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Project.Class
{
    internal class createUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool CheckUsers()
        {
            using (SqlConnection conn = new SqlConnection(addConnection.GetConnection()))
            {
                try
                {
                    conn.Open();
                    bool check = false;
                    string select = "INSERT INTO [User] (userName, password)" + " values ('" + userName + "', '" + password + "')";
                    SqlCommand cmd = new SqlCommand(select, conn);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                    return check;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
