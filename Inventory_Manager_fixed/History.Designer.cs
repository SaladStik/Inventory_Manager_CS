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
            historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(20, 97);
            historyDataGridView.Margin = new Padding(6, 7, 6, 7);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.RowHeadersWidth = 62;
            historyDataGridView.Size = new Size(1267, 767);
            historyDataGridView.TabIndex = 0;
            // 
            // searchHistory
            // 
            searchHistory.Location = new Point(20, 23);
            searchHistory.Margin = new Padding(6, 7, 6, 7);
            searchHistory.MaximumSize = new Size(331, 23);
            searchHistory.MinimumSize = new Size(331, 23);
            searchHistory.Name = "searchHistory";
            searchHistory.Size = new Size(331, 31);
            searchHistory.TabIndex = 1;
            // 
            // searchHistoryButton
            // 
            searchHistoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchHistoryButton.AutoSize = true;
            searchHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchHistoryButton.Location = new Point(363, 18);
            searchHistoryButton.Margin = new Padding(6, 7, 6, 7);
            searchHistoryButton.Name = "searchHistoryButton";
            searchHistoryButton.Padding = new Padding(4, 5, 4, 5);
            searchHistoryButton.Size = new Size(82, 45);
            searchHistoryButton.TabIndex = 2;
            searchHistoryButton.Text = "Search";
            searchHistoryButton.UseVisualStyleBackColor = true;
            searchHistoryButton.Click += SearchHistoryButton_Click;
            // 
            // Print
            // 
            Print.Location = new Point(1119, 32);
            Print.Name = "Print";
            Print.Size = new Size(112, 34);
            Print.TabIndex = 3;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click; // Add the Click event handler
                                        // 
                                        // startDate
                                        // 
            startDate.Location = new Point(482, 32);
            startDate.Name = "startDate";
            startDate.Size = new Size(318, 31);
            startDate.TabIndex = 4;
            // 
            // endDate
            // 
            endDate.Location = new Point(813, 32);
            endDate.Name = "endDate";
            endDate.Size = new Size(300, 31);
            endDate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 4);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 6;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(813, 4);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 7;
            label2.Text = "End Date";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 887);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(Print);
            Controls.Add(searchHistoryButton);
            Controls.Add(searchHistory);
            Controls.Add(historyDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "History";
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
