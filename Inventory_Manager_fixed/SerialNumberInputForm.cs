using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class SerialNumberInputForm : Form
    {
        public string SerialNumber { get; private set; }

        public SerialNumberInputForm(int currentNumber, int totalNumber)
        {
            InitializeComponent();
            promptLabel.Text = $"Enter serial number {currentNumber} of {totalNumber}";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ProcessSerialNumber();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void serialNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the "ding" sound
                ProcessSerialNumber();
            }
        }
    }
}
