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
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(800, 450);
            this.historyDataGridView.TabIndex = 0;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyDataGridView);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
