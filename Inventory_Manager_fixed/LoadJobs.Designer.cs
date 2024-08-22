namespace Inventory_Manager
{
    partial class LoadJobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JobDataGridView = new BufferedDataGridView();
            printButton = new Button();
            viewButton = new Button();
            JobComboBox = new ComboBox();
            jobLabelText = new Label();
            JobSaveButton = new Button();
            End_Job_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)JobDataGridView).BeginInit();
            SuspendLayout();
            // 
            // JobDataGridView
            // 
            JobDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JobDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            JobDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobDataGridView.Location = new Point(12, 108);
            JobDataGridView.Name = "JobDataGridView";
            JobDataGridView.RowHeadersWidth = 62;
            JobDataGridView.Size = new Size(434, 572);
            JobDataGridView.TabIndex = 7;
            JobDataGridView.CellDoubleClick += JobDataGridView_CellDoubleClick;
            JobDataGridView.CellEndEdit += JobDataGridView_CellEndEdit;
            // 
            // printButton
            // 
            printButton.Location = new Point(143, 68);
            printButton.Name = "printButton";
            printButton.Size = new Size(125, 34);
            printButton.TabIndex = 6;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += PrintButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(12, 68);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(125, 34);
            viewButton.TabIndex = 5;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += ViewButton_Click;
            // 
            // JobComboBox
            // 
            JobComboBox.FormattingEnabled = true;
            JobComboBox.Location = new Point(12, 39);
            JobComboBox.Name = "JobComboBox";
            JobComboBox.Size = new Size(360, 23);
            JobComboBox.TabIndex = 4;
            // 
            // jobLabelText
            // 
            jobLabelText.AutoSize = true;
            jobLabelText.Font = new Font("Segoe UI", 12F);
            jobLabelText.Location = new Point(12, 15);
            jobLabelText.Name = "jobLabelText";
            jobLabelText.Size = new Size(93, 21);
            jobLabelText.TabIndex = 8;
            jobLabelText.Text = "Select A Job";
            // 
            // JobSaveButton
            // 
            JobSaveButton.Location = new Point(12, 686);
            JobSaveButton.Name = "JobSaveButton";
            JobSaveButton.Size = new Size(125, 34);
            JobSaveButton.TabIndex = 9;
            JobSaveButton.Text = "Save Job";
            JobSaveButton.UseVisualStyleBackColor = true;
            JobSaveButton.Click += JobSaveButton_Click;
            // 
            // End_Job_Button
            // 
            End_Job_Button.Location = new Point(143, 686);
            End_Job_Button.Name = "End_Job_Button";
            End_Job_Button.Size = new Size(125, 34);
            End_Job_Button.TabIndex = 10;
            End_Job_Button.Text = "End Job";
            End_Job_Button.UseVisualStyleBackColor = true;
            End_Job_Button.Click += End_Job_Button_Click;
            // 
            // LoadJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 732);
            Controls.Add(End_Job_Button);
            Controls.Add(JobSaveButton);
            Controls.Add(jobLabelText);
            Controls.Add(JobDataGridView);
            Controls.Add(printButton);
            Controls.Add(viewButton);
            Controls.Add(JobComboBox);
            Name = "LoadJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadJobs";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)JobDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BufferedDataGridView JobDataGridView;
        private Button printButton;
        private Button viewButton;
        private ComboBox JobComboBox;
        private Label jobLabelText;
        private Button JobSaveButton;
        private Button End_Job_Button;
    }
}
