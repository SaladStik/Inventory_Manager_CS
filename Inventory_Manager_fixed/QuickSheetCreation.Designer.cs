namespace Inventory_Manager
{
    partial class QuickSheetCreation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            addProductButton = new Button();
            productComboBox = new ComboBox();
            productSearchTextBox = new TextBox();
            productDataGridView = new BufferedDataGridView();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "QuickSheet Name";
            nameTextBox.Size = new Size(360, 31);
            nameTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 49);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "QuickSheet Description";
            descriptionTextBox.Size = new Size(360, 31);
            descriptionTextBox.TabIndex = 1;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(297, 126);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 34);
            addProductButton.TabIndex = 2;
            addProductButton.Text = "Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += AddProductButton_Click;
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(12, 87);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(360, 33);
            productComboBox.TabIndex = 3;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(12, 126);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.PlaceholderText = "Search for products";
            productSearchTextBox.Size = new Size(279, 31);
            productSearchTextBox.TabIndex = 4;
            productSearchTextBox.TextChanged += ProductSearchTextBox_TextChanged;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(12, 166);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 62;
            productDataGridView.Size = new Size(360, 240);
            productDataGridView.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 412);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(360, 34);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save QuickSheet";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // QuickSheetCreation
            // 
            ClientSize = new Size(384, 458);
            Controls.Add(saveButton);
            Controls.Add(productDataGridView);
            Controls.Add(productSearchTextBox);
            Controls.Add(productComboBox);
            Controls.Add(addProductButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Name = "QuickSheetCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create QuickSheet";
            Load += QuickSheetCreation_Load;
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private BufferedDataGridView productDataGridView;
        private System.Windows.Forms.Button saveButton;
    }
}
