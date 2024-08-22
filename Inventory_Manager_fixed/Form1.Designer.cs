namespace Inventory_Manager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private BufferedDataGridView Product_List;
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
            Product_List = new BufferedDataGridView();
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
            loadQuickSheet = new Button();
            selectViaScan = new Button();
            SearchText = new Label();
            QuantityChangeAmtBox = new TextBox();
            quantityUp = new Button();
            QuantityText = new Label();
            quantityDown = new Button();
            JobTab = new TabPage();
            button2 = new Button();
            Begin_Job = new Button();
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
            BarcodeGen = new Button();
            AdminTab = new TabPage();
            User_Menu_Button = new Button();
            UpdateQuickSheet = new Button();
            button1 = new Button();
            CreateQuickSheets = new Button();
            addLocationButton = new Button();
            locationNameTextBox = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            searchTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            JobTab.SuspendLayout();
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
            Product_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Product_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Product_List.Location = new Point(10, 123);
            Product_List.Margin = new Padding(4, 3, 4, 3);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.RowHeadersWidth = 62;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(948, 478);
            Product_List.TabIndex = 0;
            Product_List.CellContentClick += Product_List_CellContentClick;
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
            searchButton.AutoSize = true;
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Location = new Point(249, 18);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(3);
            searchButton.Size = new Size(58, 31);
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
            // searchTabs
            // 
            searchTabs.Controls.Add(tabPage1);
            searchTabs.Controls.Add(JobTab);
            searchTabs.Controls.Add(ProductUpdateTab);
            searchTabs.Controls.Add(ProdUpdates2);
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
            tabPage1.Controls.Add(loadQuickSheet);
            tabPage1.Controls.Add(selectViaScan);
            tabPage1.Controls.Add(SearchText);
            tabPage1.Controls.Add(QuantityChangeAmtBox);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(quantityUp);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(QuantityText);
            tabPage1.Controls.Add(quantityDown);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(883, 81);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // loadQuickSheet
            // 
            loadQuickSheet.AutoSize = true;
            loadQuickSheet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadQuickSheet.Location = new Point(8, 49);
            loadQuickSheet.Margin = new Padding(2);
            loadQuickSheet.Name = "loadQuickSheet";
            loadQuickSheet.Size = new Size(106, 25);
            loadQuickSheet.TabIndex = 14;
            loadQuickSheet.Text = "Load QuickSheet";
            loadQuickSheet.UseVisualStyleBackColor = true;
            loadQuickSheet.Click += loadQuickSheet_Click;
            // 
            // selectViaScan
            // 
            selectViaScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectViaScan.AutoSize = true;
            selectViaScan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectViaScan.Location = new Point(493, 20);
            selectViaScan.Margin = new Padding(2);
            selectViaScan.Name = "selectViaScan";
            selectViaScan.Size = new Size(183, 25);
            selectViaScan.TabIndex = 13;
            selectViaScan.Text = "Select and Update Via Scanning";
            selectViaScan.UseVisualStyleBackColor = true;
            selectViaScan.Click += SelectViaScan_Click;
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
            // QuantityChangeAmtBox
            // 
            QuantityChangeAmtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuantityChangeAmtBox.Location = new Point(341, 22);
            QuantityChangeAmtBox.Margin = new Padding(2);
            QuantityChangeAmtBox.MaxLength = 4;
            QuantityChangeAmtBox.Name = "QuantityChangeAmtBox";
            QuantityChangeAmtBox.PlaceholderText = "#";
            QuantityChangeAmtBox.Size = new Size(57, 23);
            QuantityChangeAmtBox.TabIndex = 13;
            // 
            // quantityUp
            // 
            quantityUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityUp.AutoSize = true;
            quantityUp.BackColor = Color.Transparent;
            quantityUp.Location = new Point(402, 17);
            quantityUp.Name = "quantityUp";
            quantityUp.Padding = new Padding(2);
            quantityUp.Size = new Size(33, 34);
            quantityUp.TabIndex = 9;
            quantityUp.Text = "+";
            quantityUp.UseVisualStyleBackColor = false;
            quantityUp.Click += increaseQuantityButton_Click;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(341, 5);
            QuantityText.Margin = new Padding(2, 0, 2, 0);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(53, 15);
            QuantityText.TabIndex = 12;
            QuantityText.Text = "Quantity";
            // 
            // quantityDown
            // 
            quantityDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityDown.AutoSize = true;
            quantityDown.BackColor = Color.Transparent;
            quantityDown.Location = new Point(441, 18);
            quantityDown.Name = "quantityDown";
            quantityDown.Padding = new Padding(2);
            quantityDown.Size = new Size(33, 34);
            quantityDown.TabIndex = 10;
            quantityDown.Text = "-";
            quantityDown.UseVisualStyleBackColor = false;
            quantityDown.Click += decreaseQuantityButton_Click;
            // 
            // JobTab
            // 
            JobTab.Controls.Add(button2);
            JobTab.Controls.Add(Begin_Job);
            JobTab.Location = new Point(4, 24);
            JobTab.Name = "JobTab";
            JobTab.Padding = new Padding(3);
            JobTab.Size = new Size(883, 81);
            JobTab.TabIndex = 6;
            JobTab.Text = "Jobs";
            JobTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(6, 37);
            button2.Name = "button2";
            button2.Size = new Size(81, 25);
            button2.TabIndex = 16;
            button2.Text = "Update Jobs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Begin_Job
            // 
            Begin_Job.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Begin_Job.AutoSize = true;
            Begin_Job.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Begin_Job.Location = new Point(6, 6);
            Begin_Job.Name = "Begin_Job";
            Begin_Job.Size = new Size(68, 25);
            Begin_Job.TabIndex = 15;
            Begin_Job.Text = "Begin Job";
            Begin_Job.UseVisualStyleBackColor = true;
            Begin_Job.Click += Begin_Job_Click;
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
            ProductUpdateTab.Location = new Point(4, 24);
            ProductUpdateTab.Margin = new Padding(2);
            ProductUpdateTab.Name = "ProductUpdateTab";
            ProductUpdateTab.Padding = new Padding(2);
            ProductUpdateTab.Size = new Size(883, 81);
            ProductUpdateTab.TabIndex = 4;
            ProductUpdateTab.Text = "Product Updates";
            ProductUpdateTab.UseVisualStyleBackColor = true;
            // 
            // BinSet
            // 
            BinSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BinSet.AutoSize = true;
            BinSet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BinSet.Location = new Point(580, 18);
            BinSet.Margin = new Padding(2);
            BinSet.Name = "BinSet";
            BinSet.Padding = new Padding(2);
            BinSet.Size = new Size(37, 29);
            BinSet.TabIndex = 23;
            BinSet.Text = "Set";
            BinSet.UseVisualStyleBackColor = true;
            BinSet.Click += BinSet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 22;
            label1.Text = "Bin";
            // 
            // BinTextBox
            // 
            BinTextBox.Location = new Point(471, 21);
            BinTextBox.Margin = new Padding(2);
            BinTextBox.Name = "BinTextBox";
            BinTextBox.PlaceholderText = "Bin";
            BinTextBox.Size = new Size(106, 23);
            BinTextBox.TabIndex = 21;
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
            ImageUploadButton.BackColor = Color.Transparent;
            ImageUploadButton.Location = new Point(4, 4);
            ImageUploadButton.Margin = new Padding(2);
            ImageUploadButton.Name = "ImageUploadButton";
            ImageUploadButton.Size = new Size(113, 29);
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
            ProdUpdates2.Location = new Point(4, 24);
            ProdUpdates2.Margin = new Padding(2);
            ProdUpdates2.Name = "ProdUpdates2";
            ProdUpdates2.Padding = new Padding(2);
            ProdUpdates2.Size = new Size(883, 81);
            ProdUpdates2.TabIndex = 5;
            ProdUpdates2.Text = "Product Updates 2";
            ProdUpdates2.UseVisualStyleBackColor = true;
            // 
            // setType
            // 
            setType.AutoSize = true;
            setType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setType.Location = new Point(632, 5);
            setType.Margin = new Padding(2);
            setType.Name = "setType";
            setType.Size = new Size(33, 25);
            setType.TabIndex = 9;
            setType.Text = "Set";
            setType.UseVisualStyleBackColor = true;
            // 
            // UpdateType
            // 
            UpdateType.FormattingEnabled = true;
            UpdateType.Location = new Point(500, 6);
            UpdateType.Margin = new Padding(2);
            UpdateType.Name = "UpdateType";
            UpdateType.Size = new Size(129, 23);
            UpdateType.TabIndex = 8;
            // 
            // setBarcode
            // 
            setBarcode.AutoSize = true;
            setBarcode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setBarcode.Location = new Point(440, 53);
            setBarcode.Margin = new Padding(2);
            setBarcode.Name = "setBarcode";
            setBarcode.Size = new Size(33, 25);
            setBarcode.TabIndex = 7;
            setBarcode.Text = "Set";
            setBarcode.UseVisualStyleBackColor = true;
            // 
            // setModelNum
            // 
            setModelNum.AutoSize = true;
            setModelNum.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setModelNum.Location = new Point(440, 29);
            setModelNum.Margin = new Padding(2);
            setModelNum.Name = "setModelNum";
            setModelNum.Size = new Size(33, 25);
            setModelNum.TabIndex = 6;
            setModelNum.Text = "Set";
            setModelNum.UseVisualStyleBackColor = true;
            // 
            // setAlias
            // 
            setAlias.AutoSize = true;
            setAlias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setAlias.Location = new Point(440, 5);
            setAlias.Margin = new Padding(2);
            setAlias.Name = "setAlias";
            setAlias.Size = new Size(33, 25);
            setAlias.TabIndex = 5;
            setAlias.Text = "Set";
            setAlias.UseVisualStyleBackColor = true;
            // 
            // BarcodeText
            // 
            BarcodeText.Location = new Point(246, 53);
            BarcodeText.Margin = new Padding(2);
            BarcodeText.Name = "BarcodeText";
            BarcodeText.PlaceholderText = "Barcode";
            BarcodeText.Size = new Size(191, 23);
            BarcodeText.TabIndex = 4;
            // 
            // ModelNumText
            // 
            ModelNumText.Location = new Point(246, 31);
            ModelNumText.Margin = new Padding(2);
            ModelNumText.Name = "ModelNumText";
            ModelNumText.PlaceholderText = "Model Number";
            ModelNumText.Size = new Size(191, 23);
            ModelNumText.TabIndex = 3;
            // 
            // AliasText
            // 
            AliasText.Location = new Point(246, 6);
            AliasText.Margin = new Padding(2);
            AliasText.Name = "AliasText";
            AliasText.PlaceholderText = "Alias";
            AliasText.Size = new Size(191, 23);
            AliasText.TabIndex = 2;
            // 
            // EnableSerialNumberReq
            // 
            EnableSerialNumberReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnableSerialNumberReq.AutoSize = true;
            EnableSerialNumberReq.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EnableSerialNumberReq.Location = new Point(4, 28);
            EnableSerialNumberReq.Margin = new Padding(2);
            EnableSerialNumberReq.Name = "EnableSerialNumberReq";
            EnableSerialNumberReq.Size = new Size(201, 25);
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
            SerialNumberReqRemoval.Location = new Point(4, 4);
            SerialNumberReqRemoval.Margin = new Padding(2);
            SerialNumberReqRemoval.Name = "SerialNumberReqRemoval";
            SerialNumberReqRemoval.Size = new Size(209, 25);
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
            productAlias.Size = new Size(224, 23);
            productAlias.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationNamePrintCombo);
            tabPage2.Controls.Add(LocationNamePrintBox);
            tabPage2.Controls.Add(BarcodeGen);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(883, 81);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Labels";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationNamePrintCombo
            // 
            locationNamePrintCombo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationNamePrintCombo.FormattingEnabled = true;
            locationNamePrintCombo.Location = new Point(5, 5);
            locationNamePrintCombo.Margin = new Padding(2);
            locationNamePrintCombo.Name = "locationNamePrintCombo";
            locationNamePrintCombo.Size = new Size(169, 23);
            locationNamePrintCombo.TabIndex = 12;
            // 
            // LocationNamePrintBox
            // 
            LocationNamePrintBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LocationNamePrintBox.AutoSize = true;
            LocationNamePrintBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LocationNamePrintBox.Location = new Point(177, 5);
            LocationNamePrintBox.Margin = new Padding(2);
            LocationNamePrintBox.Name = "LocationNamePrintBox";
            LocationNamePrintBox.Size = new Size(126, 25);
            LocationNamePrintBox.TabIndex = 11;
            LocationNamePrintBox.Text = "Print Location Name";
            LocationNamePrintBox.UseVisualStyleBackColor = true;
            LocationNamePrintBox.Click += LocationNamePrintBox_Click;
            // 
            // BarcodeGen
            // 
            BarcodeGen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BarcodeGen.AutoSize = true;
            BarcodeGen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BarcodeGen.Location = new Point(5, 28);
            BarcodeGen.Margin = new Padding(2);
            BarcodeGen.Name = "BarcodeGen";
            BarcodeGen.Size = new Size(110, 25);
            BarcodeGen.TabIndex = 12;
            BarcodeGen.Text = "Generate Barcode";
            BarcodeGen.UseVisualStyleBackColor = true;
            BarcodeGen.Click += BarcodeGen_Click;
            // 
            // AdminTab
            // 
            AdminTab.Controls.Add(User_Menu_Button);
            AdminTab.Controls.Add(UpdateQuickSheet);
            AdminTab.Controls.Add(button1);
            AdminTab.Controls.Add(CreateQuickSheets);
            AdminTab.Controls.Add(addLocationButton);
            AdminTab.Controls.Add(locationNameTextBox);
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
            AdminTab.Location = new Point(4, 24);
            AdminTab.Margin = new Padding(2);
            AdminTab.Name = "AdminTab";
            AdminTab.Padding = new Padding(2);
            AdminTab.Size = new Size(883, 81);
            AdminTab.TabIndex = 3;
            AdminTab.Text = "Admin";
            AdminTab.UseVisualStyleBackColor = true;
            // 
            // User_Menu_Button
            // 
            User_Menu_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            User_Menu_Button.Location = new Point(4, 32);
            User_Menu_Button.Margin = new Padding(2);
            User_Menu_Button.Name = "User_Menu_Button";
            User_Menu_Button.Padding = new Padding(2);
            User_Menu_Button.Size = new Size(78, 27);
            User_Menu_Button.TabIndex = 16;
            User_Menu_Button.Text = "Users";
            User_Menu_Button.UseVisualStyleBackColor = true;
            User_Menu_Button.Click += User_Menu_Button_Click;
            // 
            // UpdateQuickSheet
            // 
            UpdateQuickSheet.AutoSize = true;
            UpdateQuickSheet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateQuickSheet.Location = new Point(421, 26);
            UpdateQuickSheet.Margin = new Padding(2);
            UpdateQuickSheet.Name = "UpdateQuickSheet";
            UpdateQuickSheet.Size = new Size(118, 25);
            UpdateQuickSheet.TabIndex = 15;
            UpdateQuickSheet.Text = "Update QuickSheet";
            UpdateQuickSheet.UseVisualStyleBackColor = true;
            UpdateQuickSheet.Click += UpdateQuickSheet_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(421, 51);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 25);
            button1.TabIndex = 14;
            button1.Text = "Delete QuickSheet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // CreateQuickSheets
            // 
            CreateQuickSheets.AutoSize = true;
            CreateQuickSheets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateQuickSheets.Location = new Point(420, 1);
            CreateQuickSheets.Margin = new Padding(2);
            CreateQuickSheets.Name = "CreateQuickSheets";
            CreateQuickSheets.Size = new Size(114, 25);
            CreateQuickSheets.TabIndex = 13;
            CreateQuickSheets.Text = "Create QuickSheet";
            CreateQuickSheets.UseVisualStyleBackColor = true;
            CreateQuickSheets.Click += CreateQuickSheets_Click;
            // 
            // addLocationButton
            // 
            addLocationButton.Location = new Point(781, 52);
            addLocationButton.Name = "addLocationButton";
            addLocationButton.Size = new Size(88, 27);
            addLocationButton.TabIndex = 10;
            addLocationButton.Text = "Add Location";
            addLocationButton.UseVisualStyleBackColor = true;
            addLocationButton.Click += addLocationButton_Click;
            // 
            // locationNameTextBox
            // 
            locationNameTextBox.Location = new Point(625, 52);
            locationNameTextBox.Name = "locationNameTextBox";
            locationNameTextBox.PlaceholderText = "Location Name";
            locationNameTextBox.Size = new Size(150, 23);
            locationNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(671, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Height";
            label2.Click += label2_Click;
            // 
            // LabelLength
            // 
            LabelLength.Location = new Point(561, 26);
            LabelLength.Margin = new Padding(2);
            LabelLength.Name = "LabelLength";
            LabelLength.Size = new Size(106, 23);
            LabelLength.TabIndex = 10;
            // 
            // LabelWidth
            // 
            LabelWidth.Location = new Point(671, 26);
            LabelWidth.Margin = new Padding(2);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(106, 23);
            LabelWidth.TabIndex = 9;
            // 
            // CalibrateLabels
            // 
            CalibrateLabels.AutoSize = true;
            CalibrateLabels.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrateLabels.Location = new Point(779, 22);
            CalibrateLabels.Margin = new Padding(2);
            CalibrateLabels.Name = "CalibrateLabels";
            CalibrateLabels.Size = new Size(100, 25);
            CalibrateLabels.TabIndex = 8;
            CalibrateLabels.Text = "Calibrate Labels";
            CalibrateLabels.UseVisualStyleBackColor = true;
            CalibrateLabels.Click += button1_Click;
            // 
            // pullLocLoadingBar
            // 
            pullLocLoadingBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pullLocLoadingBar.Location = new Point(295, 55);
            pullLocLoadingBar.Margin = new Padding(2);
            pullLocLoadingBar.Name = "pullLocLoadingBar";
            pullLocLoadingBar.Size = new Size(105, 20);
            pullLocLoadingBar.TabIndex = 7;
            pullLocLoadingBar.Visible = false;
            // 
            // QTPULLLOC
            // 
            QTPULLLOC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QTPULLLOC.Location = new Point(178, 53);
            QTPULLLOC.Margin = new Padding(2);
            QTPULLLOC.Name = "QTPULLLOC";
            QTPULLLOC.Padding = new Padding(2);
            QTPULLLOC.Size = new Size(100, 26);
            QTPULLLOC.TabIndex = 6;
            QTPULLLOC.Text = "Pull Locations";
            QTPULLLOC.UseVisualStyleBackColor = true;
            QTPULLLOC.Visible = false;
            QTPULLLOC.Click += QTPULLLOC_Click;
            // 
            // QT2FAAUTH
            // 
            QT2FAAUTH.Location = new Point(295, 28);
            QT2FAAUTH.Margin = new Padding(2);
            QT2FAAUTH.Name = "QT2FAAUTH";
            QT2FAAUTH.Size = new Size(92, 23);
            QT2FAAUTH.TabIndex = 5;
            QT2FAAUTH.Text = "Authenticate";
            QT2FAAUTH.UseVisualStyleBackColor = true;
            QT2FAAUTH.Visible = false;
            QT2FAAUTH.Click += QT2FAAUTH_Click;
            // 
            // QT2FA
            // 
            QT2FA.Location = new Point(295, 5);
            QT2FA.Margin = new Padding(2);
            QT2FA.Name = "QT2FA";
            QT2FA.PlaceholderText = "2FA";
            QT2FA.Size = new Size(106, 23);
            QT2FA.TabIndex = 4;
            QT2FA.Visible = false;
            // 
            // QTAuth
            // 
            QTAuth.Location = new Point(80, 52);
            QTAuth.Margin = new Padding(2);
            QTAuth.Name = "QTAuth";
            QTAuth.Padding = new Padding(2);
            QTAuth.Size = new Size(94, 27);
            QTAuth.TabIndex = 3;
            QTAuth.Text = "Authenticate";
            QTAuth.UseVisualStyleBackColor = true;
            QTAuth.Click += QTAuth_Click;
            // 
            // QTPassword
            // 
            QTPassword.Location = new Point(108, 29);
            QTPassword.Margin = new Padding(2);
            QTPassword.Name = "QTPassword";
            QTPassword.PasswordChar = 'ඞ';
            QTPassword.PlaceholderText = "Password ඞ";
            QTPassword.Size = new Size(184, 23);
            QTPassword.TabIndex = 2;
            // 
            // QTUsername
            // 
            QTUsername.Location = new Point(108, 7);
            QTUsername.Margin = new Padding(2);
            QTUsername.Name = "QTUsername";
            QTUsername.PlaceholderText = "Username";
            QTUsername.Size = new Size(184, 23);
            QTUsername.TabIndex = 1;
            // 
            // DB_SWEEP
            // 
            DB_SWEEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DB_SWEEP.AutoSize = true;
            DB_SWEEP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DB_SWEEP.BackColor = Color.PaleVioletRed;
            DB_SWEEP.Location = new Point(4, 4);
            DB_SWEEP.Margin = new Padding(2);
            DB_SWEEP.Name = "DB_SWEEP";
            DB_SWEEP.Padding = new Padding(2);
            DB_SWEEP.Size = new Size(75, 29);
            DB_SWEEP.TabIndex = 0;
            DB_SWEEP.Text = "DB SWEEP";
            DB_SWEEP.UseVisualStyleBackColor = false;
            DB_SWEEP.Click += DB_SWEEP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 609);
            Controls.Add(searchTabs);
            Controls.Add(Product_List);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory  Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            searchTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            JobTab.ResumeLayout(false);
            JobTab.PerformLayout();
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
        private Button CreateQuickSheets;
        private Button loadQuickSheet;
        private Button button1;
        private Button UpdateQuickSheet;
        private Button User_Menu_Button;
        private TabPage JobTab;
        private Button Begin_Job;
        private Button button2;
    }
}