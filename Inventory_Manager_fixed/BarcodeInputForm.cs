namespace Inventory_Manager
{
    public partial class BarcodeInputForm : Form
    {
        public string EnteredBarcode { get; private set; }



        public BarcodeInputForm()
        {
            InitializeComponent();
        }



        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            EnteredBarcode = barcodeTextBox.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
