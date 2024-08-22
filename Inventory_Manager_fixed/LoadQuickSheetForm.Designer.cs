namespace Inventory_Manager
{
    partial class LoadQuickSheetForm
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
            quickSheetComboBox = new ComboBox();
            viewButton = new Button();
            printButton = new Button();
            quickSheetDataGridView = new BufferedDataGridView();
            ((System.ComponentModel.ISupportInitialize)quickSheetDataGridView).BeginInit();
            SuspendLayout();
            // 
            // quickSheetComboBox
            // 
            quickSheetComboBox.FormattingEnabled = true;
            quickSheetComboBox.Location = new Point(12, 12);
            quickSheetComboBox.Name = "quickSheetComboBox";
            quickSheetComboBox.Size = new Size(360, 33);
            quickSheetComboBox.TabIndex = 0;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(12, 51);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(125, 34);
            viewButton.TabIndex = 1;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += ViewButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(143, 51);
            printButton.Name = "printButton";
            printButton.Size = new Size(125, 34);
            printButton.TabIndex = 2;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += PrintButton_Click;
            // 
            // quickSheetDataGridView
            // 
            quickSheetDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quickSheetDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            quickSheetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quickSheetDataGridView.Location = new Point(12, 108);
            quickSheetDataGridView.Name = "quickSheetDataGridView";
            quickSheetDataGridView.RowHeadersWidth = 62;
            quickSheetDataGridView.Size = new Size(434, 612);
            quickSheetDataGridView.TabIndex = 3;
            // 
            // LoadQuickSheetForm

            //
            //
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            ClientSize = new Size(458, 732);
            Controls.Add(quickSheetDataGridView);
            Controls.Add(printButton);
            Controls.Add(viewButton);
            Controls.Add(quickSheetComboBox);
            Name = "LoadQuickSheetForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)quickSheetDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox quickSheetComboBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button printButton;
        private BufferedDataGridView quickSheetDataGridView;
    }
}

