using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace railway_app
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Password_textBox.Text == "admin" && UserName_Textbox.Text == "admin")
            {
                new mainform().Show();
            }
            else
            {
                DialogResult Dr = MessageBox.Show("Invalid Password Error", "Invalid Password");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
