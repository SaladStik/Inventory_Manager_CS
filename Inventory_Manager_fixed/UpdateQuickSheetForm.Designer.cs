namespace Inventory_Manager
{
    partial class UpdateQuickSheetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox quickSheetComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button saveButton;

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
            quickSheetComboBox = new ComboBox();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            addProductButton = new Button();
            removeProductButton = new Button();
            productComboBox = new ComboBox();
            productSearchTextBox = new TextBox();
            productDataGridView = new DataGridView();
            saveButton = new Button();
            Description = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // quickSheetComboBox
            // 
            quickSheetComboBox.FormattingEnabled = true;
            quickSheetComboBox.Location = new Point(12, 12);
            quickSheetComboBox.Name = "quickSheetComboBox";
            quickSheetComboBox.Size = new Size(360, 33);
            quickSheetComboBox.TabIndex = 0;
            quickSheetComboBox.SelectedIndexChanged += QuickSheetComboBox_SelectedIndexChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 76);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "QuickSheet Name";
            nameTextBox.Size = new Size(360, 31);
            nameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 138);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "QuickSheet Description";
            descriptionTextBox.Size = new Size(360, 31);
            descriptionTextBox.TabIndex = 2;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(293, 245);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 34);
            addProductButton.TabIndex = 3;
            addProductButton.Text = "Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += AddProductButton_Click;
            // 
            // removeProductButton
            // 
            removeProductButton.Location = new Point(278, 285);
            removeProductButton.Name = "removeProductButton";
            removeProductButton.Size = new Size(90, 34);
            removeProductButton.TabIndex = 4;
            removeProductButton.Text = "Remove";
            removeProductButton.UseVisualStyleBackColor = true;
            removeProductButton.Click += RemoveProductButton_Click;
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(8, 200);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(360, 33);
            productComboBox.TabIndex = 5;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(8, 248);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.PlaceholderText = "Search for products";
            productSearchTextBox.Size = new Size(279, 31);
            productSearchTextBox.TabIndex = 6;
            productSearchTextBox.TextChanged += ProductSearchTextBox_TextChanged;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(8, 325);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 62;
            productDataGridView.Size = new Size(360, 240);
            productDataGridView.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(8, 571);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(360, 34);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save QuickSheet";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(12, 110);
            Description.Name = "Description";
            Description.Size = new Size(102, 25);
            Description.TabIndex = 9;
            Description.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 11;
            label2.Text = "Product";
            // 
            // UpdateQuickSheetForm
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            ClientSize = new Size(380, 617);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Description);
            Controls.Add(saveButton);
            Controls.Add(productDataGridView);
            Controls.Add(productSearchTextBox);
            Controls.Add(productComboBox);
            Controls.Add(removeProductButton);
            Controls.Add(addProductButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(quickSheetComboBox);
            DoubleBuffered = true;
            Name = "UpdateQuickSheetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update QuickSheet";
            Load += UpdateQuickSheetForm_Load;
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Description;
        private Label label1;
        private Label label2;
    }
}
