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
    public partial class Form2_CreateUser : Form
    {
        public Form2_CreateUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //DECLARE
            createUser CreateUser = new createUser();
            //INPUT
            CreateUser.userName = txtUserName.Text;
            CreateUser.password = txtPassword.Text;
            //PROCESS
            if (CreateUser.CheckUser() == false)
            {
                MessageBox.Show("This user is already exist, please create another user!");
                txtUserName.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("The user is successfully created!");
                txtUserName.Clear();
                txtPassword.Clear();
                Form1_UserLogIn userLogin = new Form1_UserLogIn();
                userLogin.Show();
            } 
        }
    }
}
