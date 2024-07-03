

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

            barcodeTextBox.Location = new Point(12, 12);
            barcodeTextBox.Size = new Size(260, 20);
            barcodeTextBox.PlaceholderText = "Scan Barcode";
            

            confirmButton.AutoSize = true;
            confirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmButton.Location = new Point(100, 50);
            confirmButton.Size = new Size(75, 23);
            confirmButton.Text = "Enter";
            confirmButton.Click += ConfirmButton_Click;

            this.Controls.Add(barcodeTextBox);
            this.Controls.Add(confirmButton);

            this.ClientSize = new Size(375, 100);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Scan Barcode";

            this.AcceptButton = confirmButton; // Allow pressing Enter to confirm
        }
    }
}