namespace Inventory_Manager
{
    partial class JobCreation
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
            JobSaveButton = new Button();
            JobProductDataGridView = new BufferedDataGridView();
            JobProductSearchTextBox = new TextBox();
            JobProductComboBox = new ComboBox();
            JobAddProductButton = new Button();
            JobDescriptionTextBox = new TextBox();
            JobNameTextBox = new TextBox();
            JobProductQuantityTextBox = new TextBox();
            TktNumText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)JobProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // JobSaveButton
            // 
            JobSaveButton.Location = new Point(12, 426);
            JobSaveButton.Name = "JobSaveButton";
            JobSaveButton.Size = new Size(360, 34);
            JobSaveButton.TabIndex = 13;
            JobSaveButton.Text = "Create Job";
            JobSaveButton.UseVisualStyleBackColor = true;
            JobSaveButton.Click += JobSaveButton_Click;
            // 
            // JobProductDataGridView
            // 
            JobProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobProductDataGridView.Location = new Point(12, 165);
            JobProductDataGridView.Name = "JobProductDataGridView";
            JobProductDataGridView.RowHeadersWidth = 62;
            JobProductDataGridView.Size = new Size(360, 255);
            JobProductDataGridView.TabIndex = 12;
            // 
            // JobProductSearchTextBox
            // 
            JobProductSearchTextBox.Location = new Point(12, 107);
            JobProductSearchTextBox.Name = "JobProductSearchTextBox";
            JobProductSearchTextBox.PlaceholderText = "Search for products";
            JobProductSearchTextBox.Size = new Size(279, 23);
            JobProductSearchTextBox.TabIndex = 11;
            JobProductSearchTextBox.TextChanged += JobProductSearchTextBox_TextChanged;
            // 
            // JobProductComboBox
            // 
            JobProductComboBox.FormattingEnabled = true;
            JobProductComboBox.Location = new Point(12, 136);
            JobProductComboBox.Name = "JobProductComboBox";
            JobProductComboBox.Size = new Size(279, 23);
            JobProductComboBox.TabIndex = 10;
            // 
            // JobAddProductButton
            // 
            JobAddProductButton.Location = new Point(297, 136);
            JobAddProductButton.Name = "JobAddProductButton";
            JobAddProductButton.Size = new Size(75, 23);
            JobAddProductButton.TabIndex = 9;
            JobAddProductButton.Text = "Add";
            JobAddProductButton.UseVisualStyleBackColor = true;
            JobAddProductButton.Click += JobAddProductButton_Click;
            // 
            // JobDescriptionTextBox
            // 
            JobDescriptionTextBox.Location = new Point(12, 49);
            JobDescriptionTextBox.Name = "JobDescriptionTextBox";
            JobDescriptionTextBox.PlaceholderText = "Job Description";
            JobDescriptionTextBox.Size = new Size(360, 23);
            JobDescriptionTextBox.TabIndex = 8;
            // 
            // JobNameTextBox
            // 
            JobNameTextBox.Location = new Point(12, 12);
            JobNameTextBox.Name = "JobNameTextBox";
            JobNameTextBox.PlaceholderText = "Job Name";
            JobNameTextBox.Size = new Size(360, 23);
            JobNameTextBox.TabIndex = 7;
            // 
            // JobProductQuantityTextBox
            // 
            JobProductQuantityTextBox.Location = new Point(297, 107);
            JobProductQuantityTextBox.Name = "JobProductQuantityTextBox";
            JobProductQuantityTextBox.PlaceholderText = "Quantity";
            JobProductQuantityTextBox.Size = new Size(75, 23);
            JobProductQuantityTextBox.TabIndex = 14;
            // 
            // TktNumText
            // 
            TktNumText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TktNumText.Location = new Point(12, 78);
            TktNumText.MaxLength = 7;
            TktNumText.Name = "TktNumText";
            TktNumText.PlaceholderText = "Tkt Num #";
            TktNumText.Size = new Size(100, 23);
            TktNumText.TabIndex = 15;
            // 
            // JobCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 472);
            Controls.Add(TktNumText);
            Controls.Add(JobSaveButton);
            Controls.Add(JobProductDataGridView);
            Controls.Add(JobProductSearchTextBox);
            Controls.Add(JobProductComboBox);
            Controls.Add(JobAddProductButton);
            Controls.Add(JobDescriptionTextBox);
            Controls.Add(JobNameTextBox);
            Controls.Add(JobProductQuantityTextBox);
            Name = "JobCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Creation";
            TopMost = true;
            Load += JobCreation_Load;
            ((System.ComponentModel.ISupportInitialize)JobProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button JobSaveButton;
        private BufferedDataGridView JobProductDataGridView;
        private System.Windows.Forms.TextBox JobProductSearchTextBox;
        private System.Windows.Forms.ComboBox JobProductComboBox;
        private System.Windows.Forms.Button JobAddProductButton;
        private System.Windows.Forms.TextBox JobDescriptionTextBox;
        private System.Windows.Forms.TextBox JobNameTextBox;
        private System.Windows.Forms.TextBox JobProductQuantityTextBox;
        private TextBox TktNumText;
    }
}
