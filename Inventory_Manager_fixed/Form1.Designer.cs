namespace Inventory_Manager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView Product_List;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox modelNumberTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.CheckBox requireSerialNumberCheckBox;
        private System.Windows.Forms.Button quantityUp;
        private System.Windows.Forms.Button quantityDown;
        private System.Windows.Forms.TabControl searchTabs; // renamed field
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Button addLocationButton;

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
            Product_List = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            modelNumberTextBox = new TextBox();
            typeTextBox = new TextBox();
            quantityTextBox = new TextBox();
            barcodeTextBox = new TextBox();
            requireSerialNumberCheckBox = new CheckBox();
            quantityUp = new Button();
            quantityDown = new Button();
            searchTabs = new TabControl();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            locationNameTextBox = new TextBox();
            addLocationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            searchTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Product_List
            // 
            Product_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Product_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Product_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Product_List.Location = new Point(10, 118);
            Product_List.Margin = new Padding(4, 3, 4, 3);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(948, 479);
            Product_List.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(7, 10);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(233, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(248, 6);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 27);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(162, 32);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 8;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // modelNumberTextBox
            // 
            modelNumberTextBox.Location = new Point(6, 6);
            modelNumberTextBox.Name = "modelNumberTextBox";
            modelNumberTextBox.PlaceholderText = "Model Number";
            modelNumberTextBox.Size = new Size(150, 23);
            modelNumberTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(162, 6);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.PlaceholderText = "Type";
            typeTextBox.Size = new Size(150, 23);
            typeTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(319, 6);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "Quantity";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 5;
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(425, 6);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.PlaceholderText = "Barcode";
            barcodeTextBox.Size = new Size(150, 23);
            barcodeTextBox.TabIndex = 6;
            // 
            // requireSerialNumberCheckBox
            // 
            requireSerialNumberCheckBox.Location = new Point(6, 32);
            requireSerialNumberCheckBox.Name = "requireSerialNumberCheckBox";
            requireSerialNumberCheckBox.Size = new Size(150, 23);
            requireSerialNumberCheckBox.TabIndex = 7;
            requireSerialNumberCheckBox.Text = "Require Serial Number";
            // 
            // quantityUp
            // 
            quantityUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityUp.Location = new Point(907, 89);
            quantityUp.Name = "quantityUp";
            quantityUp.Size = new Size(23, 23);
            quantityUp.TabIndex = 9;
            quantityUp.Text = "+";
            quantityUp.UseVisualStyleBackColor = true;
            quantityUp.Click += increaseQuantityButton_Click;
            // 
            // quantityDown
            // 
            quantityDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityDown.Location = new Point(936, 89);
            quantityDown.Name = "quantityDown";
            quantityDown.Size = new Size(23, 23);
            quantityDown.TabIndex = 10;
            quantityDown.Text = "-";
            quantityDown.UseVisualStyleBackColor = true;
            quantityDown.Click += decreaseQuantityButton_Click;
            // 
            // searchTabs
            // 
            searchTabs.Controls.Add(tabPage1);
            searchTabs.Controls.Add(tabPage3);
            searchTabs.Controls.Add(tabPage2);
            searchTabs.Location = new Point(14, 12);
            searchTabs.Name = "searchTabs";
            searchTabs.SelectedIndex = 0;
            searchTabs.Size = new Size(887, 100);
            searchTabs.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(879, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(modelNumberTextBox);
            tabPage3.Controls.Add(typeTextBox);
            tabPage3.Controls.Add(quantityTextBox);
            tabPage3.Controls.Add(barcodeTextBox);
            tabPage3.Controls.Add(addButton);
            tabPage3.Controls.Add(requireSerialNumberCheckBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(879, 72);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Creation";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationNameTextBox);
            tabPage2.Controls.Add(addLocationButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(879, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Location Creation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationNameTextBox
            // 
            locationNameTextBox.Location = new Point(6, 6);
            locationNameTextBox.Name = "locationNameTextBox";
            locationNameTextBox.PlaceholderText = "Location Name";
            locationNameTextBox.Size = new Size(150, 23);
            locationNameTextBox.TabIndex = 9;
            // 
            // addLocationButton
            // 
            addLocationButton.Location = new Point(162, 6);
            addLocationButton.Name = "addLocationButton";
            addLocationButton.Size = new Size(88, 27);
            addLocationButton.TabIndex = 10;
            addLocationButton.Text = "Add Location";
            addLocationButton.UseVisualStyleBackColor = true;
            addLocationButton.Click += addLocationButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 609);
            Controls.Add(Product_List);
            Controls.Add(searchTabs);
            Controls.Add(quantityUp);
            Controls.Add(quantityDown);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            searchTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }
    }
}
