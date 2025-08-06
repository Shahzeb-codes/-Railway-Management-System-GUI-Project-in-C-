using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace railway_app
{
    public partial class Cancel : Form
    {
        private string filePath = "Customer Data\\CustomerData.txt";

        public Cancel()
        {
            InitializeComponent();
        }

        private void Cancel_Load(object sender, EventArgs e)
        {
            LoadTicketNumbers();
            InitializeDataGridView();  // <-- NEW
            LoadCustomerData();        // <-- NEW
        }

        private void LoadTicketNumbers()
        {
            if (File.Exists(filePath))
            {
                comboBox1.Items.Clear();
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] data = line.Split('#');
                    if (data.Length >= 1)
                    {
                        comboBox1.Items.Add(data[0]); // Ticket No
                    }
                }
            }
        }

        private void InitializeDataGridView() // <-- NEW METHOD
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Ticket No";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Address";
            dataGridView1.Columns[3].Name = "Gender";
            dataGridView1.Columns[4].Name = "Nationality";
            dataGridView1.Columns[5].Name = "Train";
        }

        private void LoadCustomerData() // <-- NEW METHOD
        {
            dataGridView1.Rows.Clear();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] data = line.Split('#');
                    if (data.Length == 6)
                    {
                        dataGridView1.Rows.Add(data);
                    }
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket number to cancel.");
                return;
            }

            string selectedTicket = comboBox1.SelectedItem.ToString();
            var lines = File.ReadAllLines(filePath).ToList();

            bool removed = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] data = lines[i].Split('#');
                if (data.Length >= 1 && data[0] == selectedTicket)
                {
                    lines.RemoveAt(i);
                    removed = true;
                    break;
                }
            }

            if (removed)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Ticket cancelled successfully.");

                comboBox1.Items.Clear();
                LoadTicketNumbers();     // Refresh ticket numbers
                LoadCustomerData();      // Refresh grid
            }
            else
            {
                MessageBox.Show("Ticket not found.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTicket = comboBox1.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedTicket)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
                if (data.Length >= 6 && data[0] == selectedTicket)
                {
                    MessageBox.Show("Passenger Name: " + data[1] + "\nTrain: " + data[5], "Ticket Details");
                    break;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Not used if you prefer Cancel_btn
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Optional
        }
    }
}
