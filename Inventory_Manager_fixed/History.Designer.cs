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
            historyDataGridView.Location = new Point(20, 96);
            historyDataGridView.Margin = new Padding(5, 6, 5, 6);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.RowHeadersWidth = 62;
            historyDataGridView.Size = new Size(1267, 767);
            historyDataGridView.TabIndex = 0;
            // 
            // searchHistory
            // 
            searchHistory.Location = new Point(20, 23);
            searchHistory.Margin = new Padding(5, 6, 5, 6);
            searchHistory.Name = "searchHistory";
            searchHistory.Size = new Size(331, 31);
            searchHistory.TabIndex = 1;
            // 
            // searchHistoryButton
            // 
            searchHistoryButton.Location = new Point(363, 19);
            searchHistoryButton.Margin = new Padding(5, 6, 5, 6);
            searchHistoryButton.Name = "searchHistoryButton";
            searchHistoryButton.Size = new Size(125, 44);
            searchHistoryButton.TabIndex = 2;
            searchHistoryButton.Text = "Search";
            searchHistoryButton.UseVisualStyleBackColor = true;
            searchHistoryButton.Click += SearchHistoryButton_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 887);
            Controls.Add(searchHistoryButton);
            Controls.Add(searchHistory);
            Controls.Add(historyDataGridView);
            Margin = new Padding(5, 6, 5, 6);
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
