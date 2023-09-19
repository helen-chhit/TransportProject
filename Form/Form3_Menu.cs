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
    public partial class Form3_Menu : Form
    {
        public Form3_Menu()
        {
            InitializeComponent();
        }

        

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            //Form7_Booking booking = new Form7_Booking();
            //booking.Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            //Form5_Employee employee = new Form5_Employee();
            //employee.Show();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            //Form4_Customer customer = new Form4_Customer();
            //customer.Show();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {
            //Form6_TransportInfo transportInfo = new Form6_TransportInfo();
            //transportInfo.Show();   
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            //Form2_CreateUser createUser = new Form2_CreateUser();
            //createUser.Show();
        }

        //=================
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7_Booking booking = new Form7_Booking();
            booking.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5_Employee employee = new Form5_Employee();
            employee.Show();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form4_Customer customer = new Form4_Customer();
            customer.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form6_TransportInfo transportInfo = new Form6_TransportInfo();
            transportInfo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2_CreateUser createUser = new Form2_CreateUser();
            createUser.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
