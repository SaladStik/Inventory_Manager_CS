using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class SerialNumberInputForm : Form
    {
        public string SerialNumber { get; private set; }

        public SerialNumberInputForm(int currentIndex, int totalCount)
        {
            InitializeComponent();
            promptLabel.Text = $"Enter Serial Number for item {currentIndex} of {totalCount}";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SerialNumber = serialNumberTextBox.Text.Trim();
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
