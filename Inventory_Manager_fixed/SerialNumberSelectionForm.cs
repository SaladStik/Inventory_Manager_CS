using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class SerialNumberSelectionForm : Form
    {
        public List<string> SelectedSerialNumbers { get; private set; }

        public SerialNumberSelectionForm(List<string> serialNumbers)
        {
            InitializeComponent();

            foreach (var serial in serialNumbers)
            {
                serialNumbersCheckedListBox.Items.Add(serial);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedSerialNumbers = serialNumbersCheckedListBox.CheckedItems.OfType<string>().ToList();
            if (SelectedSerialNumbers.Count == 0)
            {
                MessageBox.Show("Please select at least one serial number.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
