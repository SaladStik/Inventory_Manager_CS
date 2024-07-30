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
            Print = new Button();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // historyDataGridView
            // 
            historyDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            searchHistory.MaximumSize = new Size(233, 23);
            searchHistory.MinimumSize = new Size(233, 23);
            searchHistory.Name = "searchHistory";
            searchHistory.Size = new Size(233, 23);
            searchHistory.TabIndex = 1;
            // 
            // searchHistoryButton
            // 
            searchHistoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchHistoryButton.AutoSize = true;
            searchHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchHistoryButton.Location = new Point(254, 10);
            searchHistoryButton.Margin = new Padding(4, 4, 4, 4);
            searchHistoryButton.Name = "searchHistoryButton";
            searchHistoryButton.Padding = new Padding(3, 3, 3, 3);
            searchHistoryButton.Size = new Size(58, 31);
            searchHistoryButton.TabIndex = 2;
            searchHistoryButton.Text = "Search";
            searchHistoryButton.UseVisualStyleBackColor = true;
            searchHistoryButton.Click += SearchHistoryButton_Click;
            // 
            // Print
            // 
            Print.Location = new Point(783, 20);
            Print.Margin = new Padding(2);
            Print.Name = "Print";
            Print.Size = new Size(79, 23);
            Print.TabIndex = 3;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // startDate
            // 
            startDate.Location = new Point(338, 20);
            startDate.Margin = new Padding(2);
            startDate.Name = "startDate";
            startDate.Size = new Size(224, 23);
            startDate.TabIndex = 4;
            // 
            // endDate
            // 
            endDate.Location = new Point(569, 20);
            endDate.Margin = new Padding(2);
            endDate.Name = "endDate";
            endDate.Size = new Size(211, 23);
            endDate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "End Date";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(Print);
            Controls.Add(searchHistoryButton);
            Controls.Add(searchHistory);
            Controls.Add(historyDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.Button searchHistoryButton;
        private System.Windows.Forms.TextBox searchHistory;
        private Button Print;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label label1;
        private Label label2;

    }
}
