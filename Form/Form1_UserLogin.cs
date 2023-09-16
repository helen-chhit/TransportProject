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
            if (userLogin.CheckUsers() == true)
            {
                MessageBox.Show("You've logged in successfully!");
                Form3_Menu menu = new Form3_Menu();
                menu.ShowDialog();
                txtUserName.Clear();
                txtPassword.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("You've logged in failed, Please try again!");
            }
        }
        private void lnkCreateUser_Click(object sender, EventArgs e)
        {
            Form2_CreateUser createUser = new Form2_CreateUser();
            createUser.ShowDialog();
            txtUserName.Clear();
            txtPassword.Clear();
            this.Close();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
