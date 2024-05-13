namespace Inventory_Manager
{
    partial class History
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView historyDataGridView;

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
            historyDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // historyDataGridView
            // 
            historyDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(13, 100);
            historyDataGridView.Margin = new Padding(4, 3, 4, 3);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.Size = new Size(1024, 523);
            historyDataGridView.TabIndex = 0;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 635);
            Controls.Add(historyDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "History";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
