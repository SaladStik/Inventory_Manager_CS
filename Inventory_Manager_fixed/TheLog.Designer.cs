namespace Inventory_Manager
{
    partial class TheLog
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
            theLogsTrueForm = new BufferedDataGridView();
            ((System.ComponentModel.ISupportInitialize)theLogsTrueForm).BeginInit();
            SuspendLayout();
            // 
            // theLogsTrueForm
            // 
            theLogsTrueForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            theLogsTrueForm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            theLogsTrueForm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            theLogsTrueForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            theLogsTrueForm.Location = new Point(12, 12);
            theLogsTrueForm.Name = "theLogsTrueForm";
            theLogsTrueForm.Size = new Size(999, 652);
            theLogsTrueForm.TabIndex = 0;
            // 
            // TheLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 676);
            Controls.Add(theLogsTrueForm);
            Name = "TheLog";
            Text = "TheLog";
            ((System.ComponentModel.ISupportInitialize)theLogsTrueForm).EndInit();
            ResumeLayout(false);
        }

        private BufferedDataGridView theLogsTrueForm;
    }
}
