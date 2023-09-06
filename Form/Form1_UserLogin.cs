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
    public partial class Form1_UserLogIn : Form
    {
        userLogin userLogin = new userLogin();
        public Form1_UserLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //INPUT
            userLogin.userName = txtUserName.Text;
            userLogin.password = txtPassword.Text;

            //PROCESS
            if (userLogin.CheckUsers() == true)
            {
                MessageBox.Show("Successful!");
            }
                MessageBox.Show("Not successful!");
            //OUTPUT
        }
    }
}
