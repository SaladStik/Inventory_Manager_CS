using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public class QuantityForm : Form
    {
        public int Quantity { get; private set; }

        private TextBox quantityTextBox;
        private Button confirmButton;

        public QuantityForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            quantityTextBox = new TextBox();
            confirmButton = new Button();

            quantityTextBox.Location = new Point(12, 12);
            quantityTextBox.Size = new Size(260, 20);
            quantityTextBox.PlaceholderText = "Enter Quantity";


            confirmButton.AutoSize = true;
            confirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmButton.Location = new Point(100, 50);
            confirmButton.Size = new Size(75, 23);
            confirmButton.Text = "Enter";
            confirmButton.Click += ConfirmButton_Click;

            this.Controls.Add(quantityTextBox);
            this.Controls.Add(confirmButton);

            this.ClientSize = new Size(375, 100);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Enter Quantity";

            this.AcceptButton = confirmButton; // Allow pressing Enter to confirm
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantityTextBox.Text.Trim(), out int quantity) && quantity > 0)
            {
                Quantity = quantity;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }
    }
}
