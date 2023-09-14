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
    public partial class Form5_Employee : Form
    {

        //DECLARE
        Employees emp = new Employees();

        public Form5_Employee()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtEmployeeNo.Clear();
            txtEmployeeName.Clear();
            txtEmployeeGender.Clear();
            txtEmployeeAddress.Clear();
            txtPosition.Clear();
            txtUserID.Clear();
        }

        //SAVE BUTTON (use INSERT query)
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            //INPUT
            emp.ID = txtEmployeeNo.Text;
            emp.Name = txtEmployeeName.Text;
            emp.Gender = txtEmployeeGender.Text;
            emp.Address = txtEmployeeAddress.Text;
            emp.Position = txtPosition.Text;
            emp.UserID = int.Parse(txtUserID.Text);

            //PROCESS
            if (emp.InsertEmployee())
            {   //OUTPUT
                MessageBox.Show("Inserted Sucessfuly!");
                ClearAll();
                txtEmployeeNo.Focus();
            }
            else
            {
                MessageBox.Show("Insert Failed!");
            }
        }

        //MODIFY BUTTON (use UPDATE query)
        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            //INPUT 
            emp.ID = txtEmployeeNo.Text;
            emp.Name = txtEmployeeName.Text;
            emp.Gender = txtEmployeeGender.Text;
            emp.Address = txtEmployeeAddress.Text;
            emp.Position = txtPosition.Text;
            emp.UserID = int.Parse(txtUserID.Text);

            //PROCESS
            if (emp.ModifyEmployee())
            {
                //OUTPUT
                MessageBox.Show("Modified Successfully!");
                ClearAll();
                txtEmployeeNo.Focus();
            }
            else
            {
                MessageBox.Show("Modified Failed!");
            }
        }

        //SEARCH BUTTON (use SELECT query)
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            //INPUT
            emp.ID = txtEmployeeNo.Text;

            //PROCESS
            if (emp.SearchEmployee())
            {   //OUTPUT
                MessageBox.Show("Click OK to view the OUTPUT!");
                txtEmployeeNo.Text = emp.ID.ToString();
                txtEmployeeName.Text = emp.Name;
                txtEmployeeGender.Text = emp.Gender;
                txtEmployeeAddress.Text = emp.Address;
                txtPosition.Text = emp.Position;
                txtUserID.Text = emp.UserID.ToString();
            }
            else
            {
                MessageBox.Show("Nothing!");
            }
        }

        //REMOVE BUTTON (use DELETE query)
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            //INPUT
            emp.ID = txtEmployeeNo.Text;

            //PROCESS
            if (emp.DeleteEmployee())
            {   //OUTPUT
                MessageBox.Show("Removed Sucessfully!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Removed Failed!");
            }
        }
    }
}
