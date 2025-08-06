using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace railway_app
{
    public partial class passengermaster : Form
    {
        private string filePath = "Customer Data\\CustomerData.txt";
        private string trainNamesFile = "train_names.txt";
        private int selectedRowIndex = -1;

        public passengermaster()
        {
            InitializeComponent();
        }

        private void passengermaster_Load(object sender, EventArgs e)
        {
            Nationality_comboBox.Items.AddRange(new string[] {
                "India", "USA", "UK", "Canada", "Australia"
            });

            LoadTrainNames();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Ticket No";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Address";
            dataGridView1.Columns[3].Name = "Gender";
            dataGridView1.Columns[4].Name = "Nationality";
            dataGridView1.Columns[5].Name = "Train";


            LoadDataFromFile();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadTrainNames()
        {
            try
            {
                if (File.Exists(trainNamesFile))
                {
                    Train_comboBox.Items.Clear();
                    var names = File.ReadAllLines(trainNamesFile);
                    foreach (var name in names)
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            Train_comboBox.Items.Add(name);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train names: " + ex.Message);
            }
        }

        private void LoadDataFromFile()
        {
            dataGridView1.Rows.Clear();

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] data = line.Split('#');
                    if (data.Length == 6)
                    {
                        dataGridView1.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5]);
                    }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Name_textBox.Text = row.Cells["Name"].Value.ToString();

                Address_textBox.Text = row.Cells["Address"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();
                Male_radio_btn.Checked = gender == "Male";
                Female_radio_btn.Checked = gender == "Female";

                Nationality_comboBox.SelectedItem = row.Cells["Nationality"].Value.ToString();
                Train_comboBox.SelectedItem = row.Cells["Train"].Value.ToString();
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            string ticketNo = GenerateTicketNumber();

            string line = string.Format("{0}#{1}#{2}#{3}#{4}#{5}{6}",
                ticketNo,
                Name_textBox.Text.Trim(),
                Address_textBox.Text.Trim(),
                Male_radio_btn.Checked ? "Male" : "Female",
                Nationality_comboBox.SelectedItem,
                Train_comboBox.SelectedItem,
                Environment.NewLine);

            File.AppendAllText(filePath, line);
            LoadDataFromFile();
            ClearInputFields();
        }

        private string GenerateTicketNumber()
        {
            Random rand = new Random();
            return "TKT" + rand.Next(100000, 999999);
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            if (!ValidateInputs())
                return;

            string ticketNo = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            var lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] data = lines[i].Split('#');
                if (data.Length == 6 && data[0] == ticketNo)
                {
                    
                    lines[i] = string.Format("{0}#{1}#{2}#{3}#{4}#{5}",
                        ticketNo,
                        Name_textBox.Text.Trim(),
                        Address_textBox.Text.Trim(),
                        Male_radio_btn.Checked ? "Male" : "Female",
                        Nationality_comboBox.SelectedItem,
                        Train_comboBox.SelectedItem);

                    File.WriteAllLines(filePath, lines);
                    LoadDataFromFile();
                    ClearInputFields();
                    selectedRowIndex = -1;
                    return;
                }
            }

            MessageBox.Show("Could not find the ticket to edit.");
        }


 
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Name_textBox.Text) ||
                string.IsNullOrWhiteSpace(Address_textBox.Text) ||
                Nationality_comboBox.SelectedItem == null ||
                Train_comboBox.SelectedItem == null ||
                (!Male_radio_btn.Checked && !Female_radio_btn.Checked))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return false;
            }
            return true;
        }

        private void ClearInputFields()
        {
            Name_textBox.Clear();
            Address_textBox.Clear();
            Male_radio_btn.Checked = false;
            Female_radio_btn.Checked = false;
            Nationality_comboBox.SelectedIndex = -1;
            Train_comboBox.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Nationality_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Train_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}