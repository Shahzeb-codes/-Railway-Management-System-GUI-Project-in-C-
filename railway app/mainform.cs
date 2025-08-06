using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace railway_app
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TrainMaster().Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            new Cancel().Show();
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            new Reservation_Master().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pessengermasterBtn_Click(object sender, EventArgs e)
        {
            new passengermaster().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
