using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_Project.Class;

namespace Transport_Project
{
    public partial class Form4_Customer : Form
    {
        //DECLARE
        Customers customers = new Customers();
        public Form4_Customer()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtCustomerNo.Clear();
            txtCustomerName.Clear();
            txtCustomerGender.Clear();
            txtCustomerAddress.Clear();
            txtPhoneNumber.Clear();

            txtCustomerNo.Focus();
        }

        //INSERT BUTTON (use INSERT query)
        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            //INPUT
            customers.ID = txtCustomerNo.Text;
            customers.Name = txtCustomerName.Text;
            customers.Gender = txtCustomerGender.Text;
            customers.Address = txtCustomerAddress.Text;
            customers.PhoneNumber = txtPhoneNumber.Text;

            //PROCESS
            if (customers.InsertCustomer())
            {   //OUTPUT
                MessageBox.Show("Inserted Sucessfully!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Inserted Failed!");
            }
        }

        //UPDATE BUTTON (use UPDATE query)
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //INPUT
            customers.ID = txtCustomerNo.Text;
            customers.Name = txtCustomerName.Text;
            customers.Gender = txtCustomerGender.Text;
            customers.Address = txtCustomerAddress.Text;
            customers.PhoneNumber = txtPhoneNumber.Text;

            //PROCESS
            if (customers.UpdateCustomer())
            {   //Output
                MessageBox.Show("Updated Sucessfully!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        //DELETE BUTTON (use DELETE query)
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //INPUT
            customers.ID = txtCustomerNo.Text;

            //PROCESS
            if (customers.DeleteCustomer())
            {   //OUTPUT
                MessageBox.Show("Deleted Sucessfully!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Deleted Failed!");
            }
        }

        //SEARCH BUTTON (use SELECT query)
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            //INPUT
            customers.ID = txtCustomerNo.Text;

            //PROCESS
            if (customers.SearchCustomer())
            {   //OUTPUT
                MessageBox.Show("Click OK to view the OUTPUT!");
                txtCustomerNo.Text = customers.ID.ToString();
                txtCustomerName.Text = customers.Name;
                txtCustomerGender.Text = customers.Gender;
                txtCustomerAddress.Text = customers.Address;
                txtPhoneNumber.Text = customers.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Nothing!");
            }
        }
    }
}
