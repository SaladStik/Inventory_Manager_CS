﻿namespace Inventory_Manager
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
            historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(14, 79);
            historyDataGridView.Margin = new Padding(4, 3, 4, 3);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.Size = new Size(905, 427);
            historyDataGridView.TabIndex = 0;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(historyDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "History";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
