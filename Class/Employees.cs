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
    class Employees : Persons
    {
        //FIELDS
        public string Position { get; set; }
        public int UserID { get; set; }

        //METHODS
        public bool InsertEmployee()
        {
            //DECLARE
            bool check;
            SqlConnection con;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee " +
                    "(employeeNo, employeeName, employeeGender, employeeAddress, position, userID) " +
                    "VALUES('" + ID + "', '" + Name + "', '" + Gender + "', '" + Address + "', '" + Position + "', " + UserID + ")", con);
                //cmd.Parameters.AddWithValue("@EmployeeNo", ID);
                //cmd.Parameters.AddWithValue("@EmployeeName", Name);
                //cmd.Parameters.AddWithValue("@Gender", Gender);
                //cmd.Parameters.AddWithValue("@Address", Address);
                //cmd.Parameters.AddWithValue("@Position", Position);
                //cmd.Parameters.AddWithValue("@UserID", UserID);

                //PROCESS
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    System.Console.WriteLine("It is done!");
                    check = true;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("It is not done!");
                    check = false;
                }
                con.Close();
                //OUTPUT
                return check;
            }
        }
        public bool ModifyEmployee()
        {
            //DECLARE
            bool check;
            SqlConnection con;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET"
                                        + " employeeName='" + Name + "',"
                                        + " employeeGender='" + Gender + "',"
                                        + " employeeAddress='" + Address + "',"
                                        + " position='" + Position + "',"
                                        + " userID=" + UserID
                                        + " WHERE employeeNo='" + ID + "'", con);

                //SqlCommand cmd = new SqlCommand("UPDATE Employee SET"
                //                        + " employeeName=@EmployeeName,"
                //                        + " employeeGender=@Gender,"
                //                        + " employeeAddress=@Address,"
                //                        + " position=@Position,"
                //                        + " userID=@UserID"
                //                        + " WHERE employeeNo=@EmployeeNo;", con);

                //cmd.Parameters.AddWithValue("@EmployeeNo", ID);
                //cmd.Parameters.AddWithValue("@EmployeeName", Name);
                //cmd.Parameters.AddWithValue("@Gender", Gender);
                //cmd.Parameters.AddWithValue("@Address", Address);
                //cmd.Parameters.AddWithValue("@Position", Position);
                //cmd.Parameters.AddWithValue("@UserID", UserID);

                //PROCESS
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    System.Console.WriteLine("It is done!");
                    check = true;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("It is not done!");
                    check = false;
                }
                con.Close();
                //OUTPUT
                return check;
            }
        }
        public bool SearchEmployee()
        {   //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand(@"SELECT * FROM [dbo].[Employee] WHERE employeeNo = @EmployeeNo;", con);
                cmd.Parameters.AddWithValue("@EmployeeNo", ID);

                if (con.State != System.Data.ConnectionState.Open)
                { 
                    con.Open();
                }

                //PROCESS
                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();

                if (sqlDr.HasRows)
                {  
                    //OUTPUT
                    ID = sqlDr.GetValue(1).ToString();
                    Name = sqlDr.GetValue(2).ToString();
                    Gender = sqlDr.GetValue(3).ToString();
                    Address = sqlDr.GetValue(4).ToString();
                    Position = sqlDr.GetValue(5).ToString();
                    UserID = int.Parse(sqlDr.GetValue(0).ToString());
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
        public bool DeleteEmployee()
        {
            //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand("DELETE Employee"
                                    + " WHERE employeeNo=@EmployeeNo;", con);

                cmd.Parameters.AddWithValue("@EmployeeNo", ID);

                //PROCESS
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    System.Console.WriteLine("It is done!");
                    check = true;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("It is not done!");
                    check = false;
                }
                //OUTPUT
                return check;
            }
        }
    }
}
