using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Project.Class
{
    internal class Customers : Persons
    {
        //FIELDS
        public string Remark { get; set; }

        //METHODS
        public bool InsertCustomer()
        {
            //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand("INSERT INTO Customer " +
                    "(customerNo, customerName, customerGender, customerAddress, phoneNumber) " +
                    " VALUES(@CustNo,@CustName,@Gender,@Address,@Phone); ", con);
                cmd.Parameters.AddWithValue("@CustNo", ID);
                cmd.Parameters.AddWithValue("@CustName", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", PhoneNumber);

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

        public bool DeleteCustomer()
        {
            //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand("DELETE Customer"
                                    + " WHERE customerNo=@CustNo;", con);

                cmd.Parameters.AddWithValue("@CustNo", ID);

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
                //Output
                return check;
            }
        }

        public bool UpdateCustomer()
        {
            //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //INPUT
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand("Update Customer SET"
                                        + " customerName=@CustName,"
                                        + " customerGender=@Gender,"
                                        + " customerAddress=@Address,"
                                        + " phoneNumber=@Phone"
                                        + " WHERE customerNo=@CustNo;", con);

                cmd.Parameters.AddWithValue("@CustNo", ID);
                cmd.Parameters.AddWithValue("@CustName", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", PhoneNumber);

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

        public bool SearchCustomer()
        {   //DECLARE
            bool check;
            SqlConnection con;
            SqlCommand cmd;

            //Input
            using (con = new SqlConnection(addConnection.GetConnection()))
            {
                cmd = new SqlCommand(@"SELECT * FROM [dbo].[Customer] WHERE customerNo = @CustNo;", con);
                cmd.Parameters.AddWithValue("@CustNo", ID);

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //PROCESS
                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();

                if (sqlDr.HasRows)
                {   //OUTPUT
                    ID = sqlDr.GetValue(0).ToString();
                    Name = sqlDr.GetValue(1).ToString();
                    Gender = sqlDr.GetValue(2).ToString();
                    Address = sqlDr.GetValue(3).ToString();
                    PhoneNumber = sqlDr.GetValue(4).ToString();
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
    }
}
