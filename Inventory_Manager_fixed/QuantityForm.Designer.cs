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
            SuspendLayout();
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(12, 12);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "Enter Quantity";
            quantityTextBox.Size = new Size(351, 31);
            quantityTextBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmButton.Location = new Point(163, 49);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(62, 35);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Enter";
            confirmButton.Click += ConfirmButton_Click;
            // 
            // QuantityForm
            // 
            AcceptButton = confirmButton;
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            ClientSize = new Size(375, 100);
            Controls.Add(quantityTextBox);
            Controls.Add(confirmButton);
            Name = "QuantityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Quantity";
            ResumeLayout(false);
            PerformLayout();
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
