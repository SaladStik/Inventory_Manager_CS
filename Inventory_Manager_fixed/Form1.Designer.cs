namespace Inventory_Manager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView Product_List;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;

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
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            SuspendLayout();
            // 
            // Product_List
            // 
            Product_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Product_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Product_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Product_List.Location = new Point(14, 47);
            Product_List.Margin = new Padding(4, 3, 4, 3);
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.Size = new Size(911, 470);
            Product_List.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(14, 14);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(233, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(254, 12);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 27);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 529);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(Product_List);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
