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
    public partial class TrainMaster : Form
    {
        private string trainNamesFile = "train_names.txt";

        public TrainMaster()
        {
            InitializeComponent();
            dgvTrains.Columns.Add("TrainName", "Train Name"); 
            LoadTrainNames();
            dgvTrains.CellDoubleClick += dgvTrains_CellDoubleClick;

           
        }

        private void LoadTrainNames()
        {
            if (File.Exists(trainNamesFile))
            {
                dgvTrains.Rows.Clear();
                string[] lines = File.ReadAllLines(trainNamesFile);

                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        dgvTrains.Rows.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }


        private void SaveTrainName(string trainName)
        {
            try
            {
                StreamWriter SW = new StreamWriter(trainNamesFile,true);
                SW.WriteLine(trainName);
                SW.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving train name: " + ex.Message);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string trainName = Add_train_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(trainName))
            {
                MessageBox.Show("Please enter a train name");
                return;
            }

            SaveTrainName(trainName);
            MessageBox.Show("Train name saved successfully!");

            Add_train_textbox.Clear();
            Add_train_textbox.Focus();

            LoadTrainNames(); 
        }
      private void dgvTrains_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        string trainToDelete = dgvTrains.Rows[e.RowIndex].Cells[0].Value.ToString();

        DialogResult result = MessageBox.Show(
            "Are you sure you want to delete '{trainToDelete}'?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            DeleteTrainFromFile(trainToDelete);
            LoadTrainNames();
        }
    }
    }


        private void DeleteTrainFromFile(string trainToDelete)
        {
            try
            {
                string[] lines = File.ReadAllLines(trainNamesFile);
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    if (line.Trim() != trainToDelete.Trim())
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(trainNamesFile, updatedLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting train: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrains.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this train name?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvTrains.Rows.RemoveAt(dgvTrains.SelectedRows[0].Index);
                    SaveAllTrainNamesToFile();
                }
            }
            else
            {
                MessageBox.Show("Please select a train name to delete");
            }
        }

        private void SaveAllTrainNamesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(trainNamesFile))
                {
                    foreach (DataGridViewRow row in dgvTrains.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[0].Value != null)
                        {
                            writer.WriteLine(row.Cells[0].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving train names: " + ex.Message);
            }
        }

        private void dgvTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Add_train_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbTrainDetails_Enter(object sender, EventArgs e)
        {

        }

        private void TrainMaster_Load(object sender, EventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}