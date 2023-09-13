using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Transport_Project.Class;

namespace Transport_Project.Class
{
    internal class createUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool CheckUser()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(addConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [User] (userName, password)" + " values ('" + userName + "', '" + password + "')", conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                return check;
            }
        }
    }
}
