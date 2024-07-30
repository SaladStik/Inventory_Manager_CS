namespace Inventory_Manager
{
    partial class DeleteQuickSheetForm
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
            deleteButton = new Button();
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
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 51);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(360, 34);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete QuickSheet";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // DeleteQuickSheetForm
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            ClientSize = new Size(384, 97);
            Controls.Add(deleteButton);
            Controls.Add(quickSheetComboBox);
            Name = "DeleteQuickSheetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete QuickSheet";
            Load += DeleteQuickSheetForm_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox quickSheetComboBox;
        private System.Windows.Forms.Button deleteButton;
    }
}
