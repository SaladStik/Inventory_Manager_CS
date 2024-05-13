using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LocationAndNoteForm : Form
    {
        public int SelectedLocationId { get; private set; }
        public string Note { get; private set; }
        public string SelectedSerialNumber { get; private set; }

        public LocationAndNoteForm(List<Tuple<int, string>> locations, List<string> serialNumbers)
        {
            InitializeComponent();

            // Bind the ComboBox to display location names but use the location IDs as values
            locationComboBox.DataSource = locations;
            locationComboBox.DisplayMember = "Item2"; // Display location name
            locationComboBox.ValueMember = "Item1";   // Use location ID as value

            serialNumberComboBox.DataSource = serialNumbers;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (locationComboBox.SelectedItem != null && serialNumberComboBox.SelectedItem != null)
            {
                SelectedLocationId = (int)locationComboBox.SelectedValue;
                Note = noteTextBox.Text.Trim();
                SelectedSerialNumber = serialNumberComboBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a location and a serial number.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
