using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class History : Form
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            historyDataGridView = new DataGridView();
            searchHistory = new TextBox();
            searchHistoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // historyDataGridView
            // 
            historyDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(14, 58);
            historyDataGridView.Margin = new Padding(4, 4, 4, 4);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.RowHeadersWidth = 62;
            historyDataGridView.Size = new Size(887, 460);
            historyDataGridView.TabIndex = 0;
            // 
            // searchHistory
            // 
            searchHistory.Location = new Point(14, 14);
            searchHistory.Margin = new Padding(4, 4, 4, 4);
            searchHistory.Name = "searchHistory";
            searchHistory.Size = new Size(233, 23);
            searchHistory.TabIndex = 1;
            // 
            // searchHistoryButton
            // 
            searchHistoryButton.Location = new Point(254, 11);
            searchHistoryButton.Margin = new Padding(4, 4, 4, 4);
            searchHistoryButton.Name = "searchHistoryButton";
            searchHistoryButton.Size = new Size(88, 26);
            searchHistoryButton.TabIndex = 2;
            searchHistoryButton.Text = "Search";
            searchHistoryButton.UseVisualStyleBackColor = true;
            searchHistoryButton.Click += SearchHistoryButton_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(searchHistoryButton);
            Controls.Add(searchHistory);
            Controls.Add(historyDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "History";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.Button searchHistoryButton;
        private System.Windows.Forms.TextBox searchHistory;

    }
}
