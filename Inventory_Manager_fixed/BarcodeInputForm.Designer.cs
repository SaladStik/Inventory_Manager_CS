

namespace Inventory_Manager
{
    partial class BarcodeInputForm
    {
        private TextBox barcodeTextBox;
        private Button confirmButton;


        private void InitializeComponent()
        {
            barcodeTextBox = new TextBox();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(12, 12);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.PlaceholderText = "Scan Barcode";
            barcodeTextBox.Size = new Size(352, 23);
            barcodeTextBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmButton.Location = new Point(162, 41);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(44, 25);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Enter";
            confirmButton.Click += ConfirmButton_Click;
            // 
            // BarcodeInputForm
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            AcceptButton = confirmButton;
            ClientSize = new Size(376, 89);
            Controls.Add(barcodeTextBox);
            Controls.Add(confirmButton);
            Name = "BarcodeInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scan Barcode";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}