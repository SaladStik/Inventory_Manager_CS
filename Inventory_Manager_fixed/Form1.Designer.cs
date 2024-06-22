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
        private System.Windows.Forms.ComboBox typeComboBox; // Correctly declare typeComboBox here
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.CheckBox requireSerialNumberCheckBox;
        private System.Windows.Forms.Button quantityUp;
        private System.Windows.Forms.Button quantityDown;
        private System.Windows.Forms.TabControl searchTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.TextBox QuantityChangeAmtBox;
        private System.Windows.Forms.Label QuantityText;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Product_List = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            modelNumberTextBox = new TextBox();
            typeComboBox = new ComboBox();
            quantityTextBox = new TextBox();
            barcodeTextBox = new TextBox();
            requireSerialNumberCheckBox = new CheckBox();
            quantityUp = new Button();
            quantityDown = new Button();
            searchTabs = new TabControl();
            tabPage1 = new TabPage();
            QuantityChangeAmtBox = new TextBox();
            QuantityText = new Label();
            SearchText = new Label();
            ProductUpdateTab = new TabPage();
            AddMinimumStock = new Button();
            MinimumStockTextBox = new TextBox();
            MinimumStockLabel = new Label();
            SupplierLinkText = new Label();
            SupplierLinkButton = new Button();
            supplierLinkBox = new TextBox();
            SupplierAddButton = new Button();
            SupplierInputText = new Label();
            supplierSelectionBox = new ComboBox();
            ImageUploadButton = new Button();
            tabPage3 = new TabPage();
            productAlias = new TextBox();
            tabPage2 = new TabPage();
            locationNameTextBox = new TextBox();
            addLocationButton = new Button();
            AdminTab = new TabPage();
            DB_SWEEP = new Button();
            SettingsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            searchTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ProductUpdateTab.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            AdminTab.SuspendLayout();
            SuspendLayout();
            // 
            // Product_List
            // 
            Product_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Product_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Product_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Product_List.Location = new Point(10, 119);
            Product_List.Margin = new Padding(4, 3, 4, 3);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.RowHeadersWidth = 62;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(948, 470);
            Product_List.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(8, 23);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(233, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.Location = new Point(249, 18);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 28);
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
            // typeComboBox
            // 
            typeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            typeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeComboBox.Location = new Point(162, 6);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(150, 23);
            typeComboBox.TabIndex = 4;
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
            quantityUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityUp.BackColor = Color.Lime;
            quantityUp.Location = new Point(412, 20);
            quantityUp.Name = "quantityUp";
            quantityUp.Size = new Size(23, 26);
            quantityUp.TabIndex = 9;
            quantityUp.Text = "+";
            quantityUp.UseVisualStyleBackColor = false;
            quantityUp.Click += increaseQuantityButton_Click;
            // 
            // quantityDown
            // 
            quantityDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityDown.BackColor = Color.Crimson;
            quantityDown.Location = new Point(441, 20);
            quantityDown.Name = "quantityDown";
            quantityDown.Size = new Size(23, 26);
            quantityDown.TabIndex = 10;
            quantityDown.Text = "-";
            quantityDown.UseVisualStyleBackColor = false;
            quantityDown.Click += decreaseQuantityButton_Click;
            // 
            // searchTabs
            // 
            searchTabs.Controls.Add(tabPage1);
            searchTabs.Controls.Add(ProductUpdateTab);
            searchTabs.Controls.Add(tabPage3);
            searchTabs.Controls.Add(tabPage2);
            searchTabs.Controls.Add(AdminTab);
            searchTabs.Location = new Point(10, 8);
            searchTabs.Name = "searchTabs";
            searchTabs.SelectedIndex = 0;
            searchTabs.Size = new Size(891, 109);
            searchTabs.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(QuantityChangeAmtBox);
            tabPage1.Controls.Add(QuantityText);
            tabPage1.Controls.Add(SearchText);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(quantityDown);
            tabPage1.Controls.Add(quantityUp);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(883, 81);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // QuantityChangeAmtBox
            // 
            QuantityChangeAmtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuantityChangeAmtBox.Location = new Point(351, 23);
            QuantityChangeAmtBox.Margin = new Padding(2);
            QuantityChangeAmtBox.MaxLength = 4;
            QuantityChangeAmtBox.Name = "QuantityChangeAmtBox";
            QuantityChangeAmtBox.PlaceholderText = "#";
            QuantityChangeAmtBox.Size = new Size(57, 23);
            QuantityChangeAmtBox.TabIndex = 13;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(351, 5);
            QuantityText.Margin = new Padding(2, 0, 2, 0);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(53, 15);
            QuantityText.TabIndex = 12;
            QuantityText.Text = "Quantity";
            // 
            // SearchText
            // 
            SearchText.AutoSize = true;
            SearchText.Location = new Point(8, 5);
            SearchText.Margin = new Padding(2, 0, 2, 0);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(42, 15);
            SearchText.TabIndex = 11;
            SearchText.Text = "Search";
            // 
            // ProductUpdateTab
            // 
            ProductUpdateTab.Controls.Add(AddMinimumStock);
            ProductUpdateTab.Controls.Add(MinimumStockTextBox);
            ProductUpdateTab.Controls.Add(MinimumStockLabel);
            ProductUpdateTab.Controls.Add(SupplierLinkText);
            ProductUpdateTab.Controls.Add(SupplierLinkButton);
            ProductUpdateTab.Controls.Add(supplierLinkBox);
            ProductUpdateTab.Controls.Add(SupplierAddButton);
            ProductUpdateTab.Controls.Add(SupplierInputText);
            ProductUpdateTab.Controls.Add(supplierSelectionBox);
            ProductUpdateTab.Controls.Add(ImageUploadButton);
            ProductUpdateTab.Location = new Point(4, 24);
            ProductUpdateTab.Margin = new Padding(2);
            ProductUpdateTab.Name = "ProductUpdateTab";
            ProductUpdateTab.Padding = new Padding(2);
            ProductUpdateTab.Size = new Size(883, 81);
            ProductUpdateTab.TabIndex = 4;
            ProductUpdateTab.Text = "Product Updates";
            ProductUpdateTab.UseVisualStyleBackColor = true;
            // 
            // AddMinimumStock
            // 
            AddMinimumStock.Location = new Point(751, 27);
            AddMinimumStock.Margin = new Padding(2);
            AddMinimumStock.Name = "AddMinimumStock";
            AddMinimumStock.Size = new Size(130, 25);
            AddMinimumStock.TabIndex = 20;
            AddMinimumStock.Text = "Add Minimum Stock";
            AddMinimumStock.UseVisualStyleBackColor = true;
            AddMinimumStock.Click += AddMinimumStock_Click;
            // 
            // MinimumStockTextBox
            // 
            MinimumStockTextBox.Location = new Point(642, 29);
            MinimumStockTextBox.Margin = new Padding(2);
            MinimumStockTextBox.Name = "MinimumStockTextBox";
            MinimumStockTextBox.PlaceholderText = "#";
            MinimumStockTextBox.Size = new Size(106, 23);
            MinimumStockTextBox.TabIndex = 19;
            // 
            // MinimumStockLabel
            // 
            MinimumStockLabel.AutoSize = true;
            MinimumStockLabel.Location = new Point(642, 8);
            MinimumStockLabel.Margin = new Padding(2, 0, 2, 0);
            MinimumStockLabel.Name = "MinimumStockLabel";
            MinimumStockLabel.Size = new Size(92, 15);
            MinimumStockLabel.TabIndex = 18;
            MinimumStockLabel.Text = "Minimum Stock";
            MinimumStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SupplierLinkText
            // 
            SupplierLinkText.AutoSize = true;
            SupplierLinkText.Location = new Point(256, 35);
            SupplierLinkText.Margin = new Padding(2, 0, 2, 0);
            SupplierLinkText.Name = "SupplierLinkText";
            SupplierLinkText.Size = new Size(75, 15);
            SupplierLinkText.TabIndex = 17;
            SupplierLinkText.Text = "Supplier Link";
            // 
            // SupplierLinkButton
            // 
            SupplierLinkButton.Location = new Point(751, 51);
            SupplierLinkButton.Margin = new Padding(2);
            SupplierLinkButton.Name = "SupplierLinkButton";
            SupplierLinkButton.Size = new Size(130, 25);
            SupplierLinkButton.TabIndex = 16;
            SupplierLinkButton.Text = "Insert Supplier Link";
            SupplierLinkButton.UseVisualStyleBackColor = true;
            SupplierLinkButton.Click += SupplierLinkButton_Click;
            // 
            // supplierLinkBox
            // 
            supplierLinkBox.Location = new Point(256, 53);
            supplierLinkBox.Margin = new Padding(2);
            supplierLinkBox.Name = "supplierLinkBox";
            supplierLinkBox.PlaceholderText = "Supplier Link";
            supplierLinkBox.Size = new Size(493, 23);
            supplierLinkBox.TabIndex = 15;
            // 
            // SupplierAddButton
            // 
            SupplierAddButton.Location = new Point(160, 49);
            SupplierAddButton.Margin = new Padding(2);
            SupplierAddButton.Name = "SupplierAddButton";
            SupplierAddButton.Size = new Size(92, 30);
            SupplierAddButton.TabIndex = 14;
            SupplierAddButton.Text = "Add Supplier";
            SupplierAddButton.UseVisualStyleBackColor = true;
            SupplierAddButton.Click += SupplierAddButton_Click;
            // 
            // SupplierInputText
            // 
            SupplierInputText.AutoSize = true;
            SupplierInputText.Location = new Point(5, 35);
            SupplierInputText.Margin = new Padding(2, 0, 2, 0);
            SupplierInputText.Name = "SupplierInputText";
            SupplierInputText.Size = new Size(95, 15);
            SupplierInputText.TabIndex = 13;
            SupplierInputText.Text = "Select A Supplier";
            // 
            // supplierSelectionBox
            // 
            supplierSelectionBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            supplierSelectionBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            supplierSelectionBox.Location = new Point(5, 53);
            supplierSelectionBox.Name = "supplierSelectionBox";
            supplierSelectionBox.Size = new Size(150, 23);
            supplierSelectionBox.TabIndex = 12;
            // 
            // ImageUploadButton
            // 
            ImageUploadButton.BackColor = Color.DarkGray;
            ImageUploadButton.Location = new Point(4, 4);
            ImageUploadButton.Margin = new Padding(2);
            ImageUploadButton.Name = "ImageUploadButton";
            ImageUploadButton.Size = new Size(113, 29);
            ImageUploadButton.TabIndex = 10;
            ImageUploadButton.Text = "Upload Image";
            ImageUploadButton.UseVisualStyleBackColor = false;
            ImageUploadButton.Click += ImageUploadButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(productAlias);
            tabPage3.Controls.Add(modelNumberTextBox);
            tabPage3.Controls.Add(typeComboBox);
            tabPage3.Controls.Add(quantityTextBox);
            tabPage3.Controls.Add(barcodeTextBox);
            tabPage3.Controls.Add(addButton);
            tabPage3.Controls.Add(requireSerialNumberCheckBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(883, 81);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Creation";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // productAlias
            // 
            productAlias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productAlias.Location = new Point(585, 6);
            productAlias.Margin = new Padding(2);
            productAlias.Name = "productAlias";
            productAlias.PlaceholderText = "Alias";
            productAlias.Size = new Size(106, 23);
            productAlias.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationNameTextBox);
            tabPage2.Controls.Add(addLocationButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(883, 81);
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
            // AdminTab
            // 
            AdminTab.Controls.Add(DB_SWEEP);
            AdminTab.Location = new Point(4, 24);
            AdminTab.Margin = new Padding(2);
            AdminTab.Name = "AdminTab";
            AdminTab.Padding = new Padding(2);
            AdminTab.Size = new Size(883, 81);
            AdminTab.TabIndex = 3;
            AdminTab.Text = "Admin";
            AdminTab.UseVisualStyleBackColor = true;
            // 
            // DB_SWEEP
            // 
            DB_SWEEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DB_SWEEP.BackColor = Color.PaleVioletRed;
            DB_SWEEP.Location = new Point(4, 4);
            DB_SWEEP.Margin = new Padding(2);
            DB_SWEEP.Name = "DB_SWEEP";
            DB_SWEEP.Size = new Size(78, 25);
            DB_SWEEP.TabIndex = 0;
            DB_SWEEP.Text = "DB SWEEP";
            DB_SWEEP.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsButton.Location = new Point(906, 8);
            SettingsButton.Margin = new Padding(2);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(58, 28);
            SettingsButton.TabIndex = 12;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 609);
            Controls.Add(SettingsButton);
            Controls.Add(searchTabs);
            Controls.Add(Product_List);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Inventory  Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            searchTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ProductUpdateTab.ResumeLayout(false);
            ProductUpdateTab.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            AdminTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TextBox productAlias;
        private TabPage AdminTab;
        private Button DB_SWEEP;
        private Button ImageUploadButton;
        private TabPage ProductUpdateTab;
        private Button SupplierAddButton;
        private Label SupplierInputText;
        private ComboBox supplierSelectionBox;
        private Label SupplierLinkText;
        private Button SupplierLinkButton;
        private TextBox supplierLinkBox;
        private TextBox MinimumStockTextBox;
        private Label MinimumStockLabel;
        private Button AddMinimumStock;
        private Button SettingsButton;
    }
}