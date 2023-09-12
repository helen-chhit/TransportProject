using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Project.Class
{
    internal class userLogin
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool CheckUsers()
        {
            //using (SqlConnection conn = new SqlConnection(addConnection.GetConnection()))
            //{
            //    try
            //    {
            //        conn.Open();
            //        bool check = false;
            //        string select = "SELECT * FROM [User] WHERE userName = '" + userName + "' and password = '" + password + "'";
            //        SqlCommand cmd = new SqlCommand(select, conn);
            //        cmd.Parameters.AddWithValue("@userName", userName);
            //        cmd.Parameters.AddWithValue("@password", password);
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        conn.Close();
            //        return check;
            //    }
            //    catch(Exception)
            //    {
            //        throw;
            //    }



            //}
            bool check = false;
            using (SqlConnection conn = new SqlConnection(addConnection.GetConnection()))
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand(@"SELECT userID FROM [User]" +" WHERE userName = @UserName and password=@Password;", conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        check = true;
                    else
                        check = false;
                    reader.Close();
                    return check;
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}
