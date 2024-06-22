namespace Inventory_Manager
{
    partial class LocationAndNoteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox serialNumberComboBox;

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
            locationComboBox = new ComboBox();
            serialNumberComboBox = new ComboBox();
            noteTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // locationComboBox
            // 
            locationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Location = new Point(12, 12);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(268, 23);
            locationComboBox.TabIndex = 0;
            // 
            // serialNumberComboBox
            // 
            serialNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serialNumberComboBox.FormattingEnabled = true;
            serialNumberComboBox.Location = new Point(12, 41);
            serialNumberComboBox.Name = "serialNumberComboBox";
            serialNumberComboBox.Size = new Size(268, 23);
            serialNumberComboBox.TabIndex = 4;
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(12, 70);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(268, 60);
            noteTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(124, 136);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(205, 136);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // LocationAndNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 168);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(noteTextBox);
            Controls.Add(serialNumberComboBox);
            Controls.Add(locationComboBox);
            Name = "LocationAndNoteForm";
            Text = "Select Location, Serial Number, and Note";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
