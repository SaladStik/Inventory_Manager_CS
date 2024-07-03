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
        private System.Windows.Forms.TabControl searchTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.Label SearchText;

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
            searchTabs = new TabControl();
            tabPage1 = new TabPage();
            selectViaScan = new Button();
            BarcodeGen = new Button();
            SearchText = new Label();
            QuantityChangeAmtBox = new TextBox();
            quantityUp = new Button();
            QuantityText = new Label();
            quantityDown = new Button();
            ProductUpdateTab = new TabPage();
            BinSet = new Button();
            label1 = new Label();
            BinTextBox = new TextBox();
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
            ProdUpdates2 = new TabPage();
            setType = new Button();
            UpdateType = new ComboBox();
            setBarcode = new Button();
            setModelNum = new Button();
            setAlias = new Button();
            BarcodeText = new TextBox();
            ModelNumText = new TextBox();
            AliasText = new TextBox();
            EnableSerialNumberReq = new Button();
            SerialNumberReqRemoval = new Button();
            tabPage3 = new TabPage();
            productAlias = new TextBox();
            tabPage2 = new TabPage();
            locationNamePrintCombo = new ComboBox();
            LocationNamePrintBox = new Button();
            locationNameTextBox = new TextBox();
            addLocationButton = new Button();
            AdminTab = new TabPage();
            label3 = new Label();
            label2 = new Label();
            LabelLength = new TextBox();
            LabelWidth = new TextBox();
            CalibrateLabels = new Button();
            pullLocLoadingBar = new ProgressBar();
            QTPULLLOC = new Button();
            QT2FAAUTH = new Button();
            QT2FA = new TextBox();
            QTAuth = new Button();
            QTPassword = new TextBox();
            QTUsername = new TextBox();
            DB_SWEEP = new Button();
            SettingsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            searchTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ProductUpdateTab.SuspendLayout();
            ProdUpdates2.SuspendLayout();
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
            Product_List.Location = new Point(18, 201);
            Product_List.Margin = new Padding(6, 5, 6, 5);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.RowHeadersWidth = 62;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(1328, 800);
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
            searchButton.AutoSize = true;
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Location = new Point(356, 30);
            searchButton.Margin = new Padding(6, 5, 6, 5);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(4, 5, 4, 5);
            searchButton.Size = new Size(82, 45);
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
            // searchTabs
            // 
            searchTabs.Controls.Add(tabPage1);
            searchTabs.Controls.Add(ProductUpdateTab);
            searchTabs.Controls.Add(ProdUpdates2);
            searchTabs.Controls.Add(tabPage3);
            searchTabs.Controls.Add(tabPage2);
            searchTabs.Controls.Add(AdminTab);
            searchTabs.Location = new Point(14, 13);
            searchTabs.Margin = new Padding(4, 5, 4, 5);
            searchTabs.Name = "searchTabs";
            searchTabs.SelectedIndex = 0;
            searchTabs.Size = new Size(1273, 182);
            searchTabs.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(selectViaScan);
            tabPage1.Controls.Add(BarcodeGen);
            tabPage1.Controls.Add(SearchText);
            tabPage1.Controls.Add(QuantityChangeAmtBox);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(quantityUp);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(QuantityText);
            tabPage1.Controls.Add(quantityDown);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1265, 144);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // selectViaScan
            // 
            selectViaScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectViaScan.AutoSize = true;
            selectViaScan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectViaScan.Location = new Point(669, 32);
            selectViaScan.Name = "selectViaScan";
            selectViaScan.Size = new Size(272, 35);
            selectViaScan.TabIndex = 13;
            selectViaScan.Text = "Select and Update Via Scanning";
            selectViaScan.UseVisualStyleBackColor = true;
            selectViaScan.Click += SelectViaScan_Click;
            // 
            // BarcodeGen
            // 
            BarcodeGen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BarcodeGen.AutoSize = true;
            BarcodeGen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BarcodeGen.Location = new Point(1091, 8);
            BarcodeGen.Name = "BarcodeGen";
            BarcodeGen.Padding = new Padding(3);
            BarcodeGen.Size = new Size(167, 41);
            BarcodeGen.TabIndex = 12;
            BarcodeGen.Text = "Generate Barcode";
            BarcodeGen.UseVisualStyleBackColor = true;
            BarcodeGen.Click += BarcodeGen_Click;
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
            // QuantityChangeAmtBox
            // 
            QuantityChangeAmtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuantityChangeAmtBox.Location = new Point(487, 36);
            QuantityChangeAmtBox.MaxLength = 4;
            QuantityChangeAmtBox.Name = "QuantityChangeAmtBox";
            QuantityChangeAmtBox.PlaceholderText = "#";
            QuantityChangeAmtBox.Size = new Size(80, 31);
            QuantityChangeAmtBox.TabIndex = 13;
            // 
            // quantityUp
            // 
            quantityUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityUp.AutoSize = true;
            quantityUp.BackColor = Color.Lime;
            quantityUp.Location = new Point(574, 29);
            quantityUp.Margin = new Padding(4, 5, 4, 5);
            quantityUp.Name = "quantityUp";
            quantityUp.Padding = new Padding(3);
            quantityUp.Size = new Size(40, 41);
            quantityUp.TabIndex = 9;
            quantityUp.Text = "+";
            quantityUp.UseVisualStyleBackColor = false;
            quantityUp.Click += increaseQuantityButton_Click;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(487, 8);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(80, 25);
            QuantityText.TabIndex = 12;
            QuantityText.Text = "Quantity";
            // 
            // quantityDown
            // 
            quantityDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityDown.AutoSize = true;
            quantityDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            quantityDown.BackColor = Color.Crimson;
            quantityDown.Location = new Point(616, 29);
            quantityDown.Margin = new Padding(4, 5, 4, 5);
            quantityDown.Name = "quantityDown";
            quantityDown.Padding = new Padding(3);
            quantityDown.Size = new Size(35, 41);
            quantityDown.TabIndex = 10;
            quantityDown.Text = "-";
            quantityDown.UseVisualStyleBackColor = false;
            quantityDown.Click += decreaseQuantityButton_Click;
            // 
            // ProductUpdateTab
            // 
            ProductUpdateTab.Controls.Add(BinSet);
            ProductUpdateTab.Controls.Add(label1);
            ProductUpdateTab.Controls.Add(BinTextBox);
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
            ProductUpdateTab.Size = new Size(1265, 144);
            ProductUpdateTab.TabIndex = 4;
            ProductUpdateTab.Text = "Product Updates";
            ProductUpdateTab.UseVisualStyleBackColor = true;
            // 
            // BinSet
            // 
            BinSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BinSet.AutoSize = true;
            BinSet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BinSet.Location = new Point(829, 30);
            BinSet.Name = "BinSet";
            BinSet.Padding = new Padding(3);
            BinSet.Size = new Size(53, 41);
            BinSet.TabIndex = 23;
            BinSet.Text = "Set";
            BinSet.UseVisualStyleBackColor = true;
            BinSet.Click += BinSet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 7);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 22;
            label1.Text = "Bin";
            // 
            // BinTextBox
            // 
            BinTextBox.Location = new Point(673, 35);
            BinTextBox.Name = "BinTextBox";
            BinTextBox.PlaceholderText = "Bin";
            BinTextBox.Size = new Size(150, 31);
            BinTextBox.TabIndex = 21;
            // 
            // AddMinimumStock
            // 
            AddMinimumStock.Location = new Point(1073, 45);
            AddMinimumStock.Name = "AddMinimumStock";
            AddMinimumStock.Size = new Size(186, 42);
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
            SupplierLinkText.Location = new Point(366, 58);
            SupplierLinkText.Name = "SupplierLinkText";
            SupplierLinkText.Size = new Size(113, 25);
            SupplierLinkText.TabIndex = 17;
            SupplierLinkText.Text = "Supplier Link";
            // 
            // SupplierLinkButton
            // 
            SupplierLinkButton.Location = new Point(1073, 85);
            SupplierLinkButton.Name = "SupplierLinkButton";
            SupplierLinkButton.Size = new Size(186, 42);
            SupplierLinkButton.TabIndex = 16;
            SupplierLinkButton.Text = "Insert Supplier Link";
            SupplierLinkButton.UseVisualStyleBackColor = true;
            SupplierLinkButton.Click += SupplierLinkButton_Click;
            // 
            // supplierLinkBox
            // 
            supplierLinkBox.Location = new Point(366, 88);
            supplierLinkBox.Name = "supplierLinkBox";
            supplierLinkBox.PlaceholderText = "Supplier Link";
            supplierLinkBox.Size = new Size(703, 31);
            supplierLinkBox.TabIndex = 15;
            // 
            // SupplierAddButton
            // 
            SupplierAddButton.Location = new Point(229, 82);
            SupplierAddButton.Name = "SupplierAddButton";
            SupplierAddButton.Size = new Size(131, 50);
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
            ImageUploadButton.Location = new Point(6, 7);
            ImageUploadButton.Name = "ImageUploadButton";
            ImageUploadButton.Size = new Size(161, 48);
            ImageUploadButton.TabIndex = 10;
            ImageUploadButton.Text = "Upload Image";
            ImageUploadButton.UseVisualStyleBackColor = false;
            ImageUploadButton.Click += ImageUploadButton_Click;
            // 
            // ProdUpdates2
            // 
            ProdUpdates2.Controls.Add(setType);
            ProdUpdates2.Controls.Add(UpdateType);
            ProdUpdates2.Controls.Add(setBarcode);
            ProdUpdates2.Controls.Add(setModelNum);
            ProdUpdates2.Controls.Add(setAlias);
            ProdUpdates2.Controls.Add(BarcodeText);
            ProdUpdates2.Controls.Add(ModelNumText);
            ProdUpdates2.Controls.Add(AliasText);
            ProdUpdates2.Controls.Add(EnableSerialNumberReq);
            ProdUpdates2.Controls.Add(SerialNumberReqRemoval);
            ProdUpdates2.Location = new Point(4, 34);
            ProdUpdates2.Name = "ProdUpdates2";
            ProdUpdates2.Padding = new Padding(3);
            ProdUpdates2.Size = new Size(1265, 144);
            ProdUpdates2.TabIndex = 5;
            ProdUpdates2.Text = "Product Updates 2";
            ProdUpdates2.UseVisualStyleBackColor = true;
            // 
            // setType
            // 
            setType.AutoSize = true;
            setType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setType.Location = new Point(903, 9);
            setType.Name = "setType";
            setType.Size = new Size(47, 35);
            setType.TabIndex = 9;
            setType.Text = "Set";
            setType.UseVisualStyleBackColor = true;
            // 
            // UpdateType
            // 
            UpdateType.FormattingEnabled = true;
            UpdateType.Location = new Point(715, 10);
            UpdateType.Name = "UpdateType";
            UpdateType.Size = new Size(182, 33);
            UpdateType.TabIndex = 8;
            // 
            // setBarcode
            // 
            setBarcode.AutoSize = true;
            setBarcode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setBarcode.Location = new Point(628, 88);
            setBarcode.Name = "setBarcode";
            setBarcode.Size = new Size(47, 35);
            setBarcode.TabIndex = 7;
            setBarcode.Text = "Set";
            setBarcode.UseVisualStyleBackColor = true;
            // 
            // setModelNum
            // 
            setModelNum.AutoSize = true;
            setModelNum.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setModelNum.Location = new Point(628, 49);
            setModelNum.Name = "setModelNum";
            setModelNum.Size = new Size(47, 35);
            setModelNum.TabIndex = 6;
            setModelNum.Text = "Set";
            setModelNum.UseVisualStyleBackColor = true;
            // 
            // setAlias
            // 
            setAlias.AutoSize = true;
            setAlias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setAlias.Location = new Point(628, 8);
            setAlias.Name = "setAlias";
            setAlias.Size = new Size(47, 35);
            setAlias.TabIndex = 5;
            setAlias.Text = "Set";
            setAlias.UseVisualStyleBackColor = true;
            // 
            // BarcodeText
            // 
            BarcodeText.Location = new Point(351, 88);
            BarcodeText.Name = "BarcodeText";
            BarcodeText.PlaceholderText = "Barcode";
            BarcodeText.Size = new Size(271, 31);
            BarcodeText.TabIndex = 4;
            // 
            // ModelNumText
            // 
            ModelNumText.Location = new Point(351, 51);
            ModelNumText.Name = "ModelNumText";
            ModelNumText.PlaceholderText = "Model Number";
            ModelNumText.Size = new Size(271, 31);
            ModelNumText.TabIndex = 3;
            // 
            // AliasText
            // 
            AliasText.Location = new Point(351, 10);
            AliasText.Name = "AliasText";
            AliasText.PlaceholderText = "Alias";
            AliasText.Size = new Size(271, 31);
            AliasText.TabIndex = 2;
            // 
            // EnableSerialNumberReq
            // 
            EnableSerialNumberReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnableSerialNumberReq.AutoSize = true;
            EnableSerialNumberReq.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EnableSerialNumberReq.Location = new Point(6, 47);
            EnableSerialNumberReq.Name = "EnableSerialNumberReq";
            EnableSerialNumberReq.Size = new Size(296, 35);
            EnableSerialNumberReq.TabIndex = 1;
            EnableSerialNumberReq.Text = "Enable Serial Number Requirement";
            EnableSerialNumberReq.UseVisualStyleBackColor = true;
            EnableSerialNumberReq.Click += EnableSerialNumberReq_Click;
            // 
            // SerialNumberReqRemoval
            // 
            SerialNumberReqRemoval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SerialNumberReqRemoval.AutoSize = true;
            SerialNumberReqRemoval.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SerialNumberReqRemoval.Location = new Point(6, 6);
            SerialNumberReqRemoval.Name = "SerialNumberReqRemoval";
            SerialNumberReqRemoval.Size = new Size(308, 35);
            SerialNumberReqRemoval.TabIndex = 0;
            SerialNumberReqRemoval.Text = "Remove Serial Number Requirement";
            SerialNumberReqRemoval.UseVisualStyleBackColor = true;
            SerialNumberReqRemoval.Click += SerialNumberReqRemoval_Click;
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
            tabPage3.Size = new Size(1265, 144);
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
            productAlias.Size = new Size(318, 31);
            productAlias.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationNamePrintCombo);
            tabPage2.Controls.Add(LocationNamePrintBox);
            tabPage2.Controls.Add(locationNameTextBox);
            tabPage2.Controls.Add(addLocationButton);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1265, 144);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Location Creation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationNamePrintCombo
            // 
            locationNamePrintCombo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationNamePrintCombo.FormattingEnabled = true;
            locationNamePrintCombo.Location = new Point(462, 13);
            locationNamePrintCombo.Name = "locationNamePrintCombo";
            locationNamePrintCombo.Size = new Size(240, 33);
            locationNamePrintCombo.TabIndex = 12;
            // 
            // LocationNamePrintBox
            // 
            LocationNamePrintBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LocationNamePrintBox.AutoSize = true;
            LocationNamePrintBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LocationNamePrintBox.Location = new Point(708, 11);
            LocationNamePrintBox.Name = "LocationNamePrintBox";
            LocationNamePrintBox.Size = new Size(182, 35);
            LocationNamePrintBox.TabIndex = 11;
            LocationNamePrintBox.Text = "Print Location Name";
            LocationNamePrintBox.UseVisualStyleBackColor = true;
            LocationNamePrintBox.Click += LocationNamePrintBox_Click;
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
            AdminTab.Controls.Add(label3);
            AdminTab.Controls.Add(label2);
            AdminTab.Controls.Add(LabelLength);
            AdminTab.Controls.Add(LabelWidth);
            AdminTab.Controls.Add(CalibrateLabels);
            AdminTab.Controls.Add(pullLocLoadingBar);
            AdminTab.Controls.Add(QTPULLLOC);
            AdminTab.Controls.Add(QT2FAAUTH);
            AdminTab.Controls.Add(QT2FA);
            AdminTab.Controls.Add(QTAuth);
            AdminTab.Controls.Add(QTPassword);
            AdminTab.Controls.Add(QTUsername);
            AdminTab.Controls.Add(DB_SWEEP);
            AdminTab.Location = new Point(4, 34);
            AdminTab.Name = "AdminTab";
            AdminTab.Padding = new Padding(3);
            AdminTab.Size = new Size(1265, 144);
            AdminTab.TabIndex = 3;
            AdminTab.Text = "Admin";
            AdminTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(958, 15);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 12;
            label3.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(802, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 11;
            label2.Text = "Length";
            label2.Click += label2_Click;
            // 
            // LabelLength
            // 
            LabelLength.Location = new Point(802, 48);
            LabelLength.Name = "LabelLength";
            LabelLength.Size = new Size(150, 31);
            LabelLength.TabIndex = 10;
            // 
            // LabelWidth
            // 
            LabelWidth.Location = new Point(958, 48);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(150, 31);
            LabelWidth.TabIndex = 9;
            // 
            // CalibrateLabels
            // 
            CalibrateLabels.AutoSize = true;
            CalibrateLabels.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrateLabels.Location = new Point(1114, 44);
            CalibrateLabels.Name = "CalibrateLabels";
            CalibrateLabels.Size = new Size(145, 35);
            CalibrateLabels.TabIndex = 8;
            CalibrateLabels.Text = "Calibrate Labels";
            CalibrateLabels.UseVisualStyleBackColor = true;
            CalibrateLabels.Click += button1_Click;
            // 
            // pullLocLoadingBar
            // 
            pullLocLoadingBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pullLocLoadingBar.Location = new Point(6, 92);
            pullLocLoadingBar.Name = "pullLocLoadingBar";
            pullLocLoadingBar.Size = new Size(130, 34);
            pullLocLoadingBar.TabIndex = 7;
            pullLocLoadingBar.Visible = false;
            // 
            // QTPULLLOC
            // 
            QTPULLLOC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QTPULLLOC.Location = new Point(6, 53);
            QTPULLLOC.Name = "QTPULLLOC";
            QTPULLLOC.Size = new Size(130, 33);
            QTPULLLOC.TabIndex = 6;
            QTPULLLOC.Text = "Pull Locations";
            QTPULLLOC.UseVisualStyleBackColor = true;
            QTPULLLOC.Visible = false;
            QTPULLLOC.Click += QTPULLLOC_Click;
            // 
            // QT2FAAUTH
            // 
            QT2FAAUTH.Location = new Point(466, 48);
            QT2FAAUTH.Name = "QT2FAAUTH";
            QT2FAAUTH.Size = new Size(131, 38);
            QT2FAAUTH.TabIndex = 5;
            QT2FAAUTH.Text = "Authenticate";
            QT2FAAUTH.UseVisualStyleBackColor = true;
            QT2FAAUTH.Visible = false;
            QT2FAAUTH.Click += QT2FAAUTH_Click;
            // 
            // QT2FA
            // 
            QT2FA.Location = new Point(466, 12);
            QT2FA.Name = "QT2FA";
            QT2FA.PlaceholderText = "2FA";
            QT2FA.Size = new Size(150, 31);
            QT2FA.TabIndex = 4;
            QT2FA.Visible = false;
            // 
            // QTAuth
            // 
            QTAuth.Location = new Point(154, 87);
            QTAuth.Name = "QTAuth";
            QTAuth.Padding = new Padding(3);
            QTAuth.Size = new Size(126, 45);
            QTAuth.TabIndex = 3;
            QTAuth.Text = "Authenticate";
            QTAuth.UseVisualStyleBackColor = true;
            QTAuth.Click += QTAuth_Click;
            // 
            // QTPassword
            // 
            QTPassword.Location = new Point(154, 48);
            QTPassword.Name = "QTPassword";
            QTPassword.PasswordChar = 'ඞ';
            QTPassword.PlaceholderText = "Password ඞ";
            QTPassword.Size = new Size(261, 31);
            QTPassword.TabIndex = 2;
            // 
            // QTUsername
            // 
            QTUsername.Location = new Point(154, 12);
            QTUsername.Name = "QTUsername";
            QTUsername.PlaceholderText = "Username";
            QTUsername.Size = new Size(261, 31);
            QTUsername.TabIndex = 1;
            // 
            // DB_SWEEP
            // 
            DB_SWEEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DB_SWEEP.AutoSize = true;
            DB_SWEEP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DB_SWEEP.BackColor = Color.PaleVioletRed;
            DB_SWEEP.Location = new Point(6, 7);
            DB_SWEEP.Name = "DB_SWEEP";
            DB_SWEEP.Padding = new Padding(3);
            DB_SWEEP.Size = new Size(111, 41);
            DB_SWEEP.TabIndex = 0;
            DB_SWEEP.Text = "DB SWEEP";
            DB_SWEEP.UseVisualStyleBackColor = false;
            DB_SWEEP.Click += DB_SWEEP_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsButton.Location = new Point(1294, 13);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(83, 47);
            SettingsButton.TabIndex = 12;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Visible = false;
            SettingsButton.Click += SettingsButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 1015);
            Controls.Add(SettingsButton);
            Controls.Add(searchTabs);
            Controls.Add(Product_List);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Inventory  Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            searchTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ProductUpdateTab.ResumeLayout(false);
            ProductUpdateTab.PerformLayout();
            ProdUpdates2.ResumeLayout(false);
            ProdUpdates2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            AdminTab.ResumeLayout(false);
            AdminTab.PerformLayout();
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
        private TextBox QuantityChangeAmtBox;
        private Button quantityDown;
        private Button quantityUp;
        private Label QuantityText;
        private TextBox QTPassword;
        private TextBox QTUsername;
        private Button QTAuth;
        private Button QTPULLLOC;
        private Button QT2FAAUTH;
        private TextBox QT2FA;
        private Button BarcodeGen;
        private Button BinSet;
        private Label label1;
        private TextBox BinTextBox;
        private TabPage ProdUpdates2;
        private Button SerialNumberReqRemoval;
        private Button EnableSerialNumberReq;
        private Button selectViaScan;
        private ProgressBar pullLocLoadingBar;
        private ComboBox locationNamePrintCombo;
        private Button LocationNamePrintBox;
        private TextBox BarcodeText;
        private TextBox ModelNumText;
        private TextBox AliasText;
        private Button setType;
        private ComboBox UpdateType;
        private Button setBarcode;
        private Button setModelNum;
        private Button setAlias;
        private Label label3;
        private Label label2;
        private TextBox LabelLength;
        private TextBox LabelWidth;
        private Button CalibrateLabels;
    }
}