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
            Product_List.Location = new Point(14, 184);
            Product_List.Margin = new Padding(6, 5, 6, 5);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.RowHeadersWidth = 62;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(1354, 798);
            Product_List.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(11, 38);
            searchTextBox.Margin = new Padding(6, 5, 6, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(331, 31);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.Location = new Point(354, 38);
            searchButton.Margin = new Padding(6, 5, 6, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(126, 40);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(231, 53);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(126, 45);
            addButton.TabIndex = 8;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // modelNumberTextBox
            // 
            modelNumberTextBox.Location = new Point(9, 10);
            modelNumberTextBox.Margin = new Padding(4, 5, 4, 5);
            modelNumberTextBox.Name = "modelNumberTextBox";
            modelNumberTextBox.PlaceholderText = "Model Number";
            modelNumberTextBox.Size = new Size(213, 31);
            modelNumberTextBox.TabIndex = 3;
            // 
            // typeComboBox
            // 
            typeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            typeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeComboBox.Location = new Point(231, 10);
            typeComboBox.Margin = new Padding(4, 5, 4, 5);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(213, 33);
            typeComboBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(456, 10);
            quantityTextBox.Margin = new Padding(4, 5, 4, 5);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "Quantity";
            quantityTextBox.Size = new Size(141, 31);
            quantityTextBox.TabIndex = 5;
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(607, 10);
            barcodeTextBox.Margin = new Padding(4, 5, 4, 5);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.PlaceholderText = "Barcode";
            barcodeTextBox.Size = new Size(213, 31);
            barcodeTextBox.TabIndex = 6;
            // 
            // requireSerialNumberCheckBox
            // 
            requireSerialNumberCheckBox.Location = new Point(9, 53);
            requireSerialNumberCheckBox.Margin = new Padding(4, 5, 4, 5);
            requireSerialNumberCheckBox.Name = "requireSerialNumberCheckBox";
            requireSerialNumberCheckBox.Size = new Size(214, 38);
            requireSerialNumberCheckBox.TabIndex = 7;
            requireSerialNumberCheckBox.Text = "Require Serial Number";
            // 
            // quantityUp
            // 
            quantityUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityUp.BackColor = Color.Lime;
            quantityUp.Location = new Point(589, 34);
            quantityUp.Margin = new Padding(4, 5, 4, 5);
            quantityUp.Name = "quantityUp";
            quantityUp.Size = new Size(33, 44);
            quantityUp.TabIndex = 9;
            quantityUp.Text = "+";
            quantityUp.UseVisualStyleBackColor = false;
            quantityUp.Click += increaseQuantityButton_Click;
            // 
            // quantityDown
            // 
            quantityDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityDown.BackColor = Color.Crimson;
            quantityDown.Location = new Point(630, 34);
            quantityDown.Margin = new Padding(4, 5, 4, 5);
            quantityDown.Name = "quantityDown";
            quantityDown.Size = new Size(33, 44);
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
            searchTabs.Location = new Point(14, 14);
            searchTabs.Margin = new Padding(4, 5, 4, 5);
            searchTabs.Name = "searchTabs";
            searchTabs.SelectedIndex = 0;
            searchTabs.Size = new Size(1273, 167);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1265, 129);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // QuantityChangeAmtBox
            // 
            QuantityChangeAmtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuantityChangeAmtBox.Location = new Point(502, 38);
            QuantityChangeAmtBox.MaxLength = 4;
            QuantityChangeAmtBox.Name = "QuantityChangeAmtBox";
            QuantityChangeAmtBox.PlaceholderText = "#";
            QuantityChangeAmtBox.Size = new Size(80, 31);
            QuantityChangeAmtBox.TabIndex = 13;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(502, 8);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(80, 25);
            QuantityText.TabIndex = 12;
            QuantityText.Text = "Quantity";
            // 
            // SearchText
            // 
            SearchText.AutoSize = true;
            SearchText.Location = new Point(11, 8);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(64, 25);
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
            ProductUpdateTab.Location = new Point(4, 34);
            ProductUpdateTab.Name = "ProductUpdateTab";
            ProductUpdateTab.Padding = new Padding(3);
            ProductUpdateTab.Size = new Size(1265, 129);
            ProductUpdateTab.TabIndex = 4;
            ProductUpdateTab.Text = "Product Updates";
            ProductUpdateTab.UseVisualStyleBackColor = true;
            // 
            // AddMinimumStock
            // 
            AddMinimumStock.Location = new Point(1073, 46);
            AddMinimumStock.Name = "AddMinimumStock";
            AddMinimumStock.Size = new Size(186, 34);
            AddMinimumStock.TabIndex = 20;
            AddMinimumStock.Text = "Add Minimum Stock";
            AddMinimumStock.UseVisualStyleBackColor = true;
            AddMinimumStock.Click += AddMinimumStock_Click;
            // 
            // MinimumStockTextBox
            // 
            MinimumStockTextBox.Location = new Point(917, 48);
            MinimumStockTextBox.Name = "MinimumStockTextBox";
            MinimumStockTextBox.PlaceholderText = "#";
            MinimumStockTextBox.Size = new Size(150, 31);
            MinimumStockTextBox.TabIndex = 19;
            // 
            // MinimumStockLabel
            // 
            MinimumStockLabel.AutoSize = true;
            MinimumStockLabel.Location = new Point(917, 13);
            MinimumStockLabel.Name = "MinimumStockLabel";
            MinimumStockLabel.Size = new Size(136, 25);
            MinimumStockLabel.TabIndex = 18;
            MinimumStockLabel.Text = "Minimum Stock";
            MinimumStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SupplierLinkText
            // 
            SupplierLinkText.AutoSize = true;
            SupplierLinkText.Location = new Point(365, 58);
            SupplierLinkText.Name = "SupplierLinkText";
            SupplierLinkText.Size = new Size(113, 25);
            SupplierLinkText.TabIndex = 17;
            SupplierLinkText.Text = "Supplier Link";
            // 
            // SupplierLinkButton
            // 
            SupplierLinkButton.Location = new Point(1073, 85);
            SupplierLinkButton.Name = "SupplierLinkButton";
            SupplierLinkButton.Size = new Size(186, 34);
            SupplierLinkButton.TabIndex = 16;
            SupplierLinkButton.Text = "Insert Supplier Link";
            SupplierLinkButton.UseVisualStyleBackColor = true;
            SupplierLinkButton.Click += SupplierLinkButton_Click;
            // 
            // supplierLinkBox
            // 
            supplierLinkBox.Location = new Point(365, 88);
            supplierLinkBox.Name = "supplierLinkBox";
            supplierLinkBox.PlaceholderText = "Supplier Link";
            supplierLinkBox.Size = new Size(702, 31);
            supplierLinkBox.TabIndex = 15;
            // 
            // SupplierAddButton
            // 
            SupplierAddButton.Location = new Point(227, 85);
            SupplierAddButton.Name = "SupplierAddButton";
            SupplierAddButton.Size = new Size(132, 34);
            SupplierAddButton.TabIndex = 14;
            SupplierAddButton.Text = "Add Supplier";
            SupplierAddButton.UseVisualStyleBackColor = true;
            SupplierAddButton.Click += SupplierAddButton_Click;
            // 
            // SupplierInputText
            // 
            SupplierInputText.AutoSize = true;
            SupplierInputText.Location = new Point(7, 58);
            SupplierInputText.Name = "SupplierInputText";
            SupplierInputText.Size = new Size(145, 25);
            SupplierInputText.TabIndex = 13;
            SupplierInputText.Text = "Select A Supplier";
            // 
            // supplierSelectionBox
            // 
            supplierSelectionBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            supplierSelectionBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            supplierSelectionBox.Location = new Point(7, 88);
            supplierSelectionBox.Margin = new Padding(4, 5, 4, 5);
            supplierSelectionBox.Name = "supplierSelectionBox";
            supplierSelectionBox.Size = new Size(213, 33);
            supplierSelectionBox.TabIndex = 12;
            // 
            // ImageUploadButton
            // 
            ImageUploadButton.BackColor = Color.DarkGray;
            ImageUploadButton.Location = new Point(6, 6);
            ImageUploadButton.Name = "ImageUploadButton";
            ImageUploadButton.Size = new Size(161, 49);
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
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(1265, 129);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Creation";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // productAlias
            // 
            productAlias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productAlias.Location = new Point(836, 10);
            productAlias.Name = "productAlias";
            productAlias.PlaceholderText = "Alias";
            productAlias.Size = new Size(150, 31);
            productAlias.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationNameTextBox);
            tabPage2.Controls.Add(addLocationButton);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1265, 129);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Location Creation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationNameTextBox
            // 
            locationNameTextBox.Location = new Point(9, 10);
            locationNameTextBox.Margin = new Padding(4, 5, 4, 5);
            locationNameTextBox.Name = "locationNameTextBox";
            locationNameTextBox.PlaceholderText = "Location Name";
            locationNameTextBox.Size = new Size(213, 31);
            locationNameTextBox.TabIndex = 9;
            // 
            // addLocationButton
            // 
            addLocationButton.Location = new Point(231, 10);
            addLocationButton.Margin = new Padding(4, 5, 4, 5);
            addLocationButton.Name = "addLocationButton";
            addLocationButton.Size = new Size(126, 45);
            addLocationButton.TabIndex = 10;
            addLocationButton.Text = "Add Location";
            addLocationButton.UseVisualStyleBackColor = true;
            addLocationButton.Click += addLocationButton_Click;
            // 
            // AdminTab
            // 
            AdminTab.Controls.Add(DB_SWEEP);
            AdminTab.Location = new Point(4, 34);
            AdminTab.Name = "AdminTab";
            AdminTab.Padding = new Padding(3);
            AdminTab.Size = new Size(1265, 129);
            AdminTab.TabIndex = 3;
            AdminTab.Text = "Admin";
            AdminTab.UseVisualStyleBackColor = true;
            // 
            // DB_SWEEP
            // 
            DB_SWEEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DB_SWEEP.BackColor = Color.PaleVioletRed;
            DB_SWEEP.Location = new Point(6, 6);
            DB_SWEEP.Name = "DB_SWEEP";
            DB_SWEEP.Size = new Size(112, 41);
            DB_SWEEP.TabIndex = 0;
            DB_SWEEP.Text = "DB SWEEP";
            DB_SWEEP.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsButton.Location = new Point(1256, 8);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(112, 34);
            SettingsButton.TabIndex = 12;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 1015);
            Controls.Add(SettingsButton);
            Controls.Add(searchTabs);
            Controls.Add(Product_List);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
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