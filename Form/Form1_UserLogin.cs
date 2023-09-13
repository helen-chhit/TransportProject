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
        public Form1_UserLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //DECALRE
            userLogin userLogin = new userLogin();
            //INPUT
            userLogin.userName = txtUserName.Text;
            userLogin.password = txtPassword.Text;
            //PROCESS
            if (userLogin.CheckUsers())
            {
                MessageBox.Show("You've logged in successfully!");
            }
            else
            {
                MessageBox.Show("You've logged in failed, Please try again!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
