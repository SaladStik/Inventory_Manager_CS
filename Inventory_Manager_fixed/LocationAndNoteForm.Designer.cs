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
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.serialNumberComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(12, 12);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(268, 23);
            this.locationComboBox.TabIndex = 0;
            // 
            // serialNumberComboBox
            // 
            this.serialNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialNumberComboBox.FormattingEnabled = true;
            this.serialNumberComboBox.Location = new System.Drawing.Point(12, 41);
            this.serialNumberComboBox.Name = "serialNumberComboBox";
            this.serialNumberComboBox.Size = new System.Drawing.Size(268, 23);
            this.serialNumberComboBox.TabIndex = 4;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 70);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(268, 60);
            this.noteTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 136);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(205, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LocationAndNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 171);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.serialNumberComboBox);
            this.Controls.Add(this.locationComboBox);
            this.Name = "LocationAndNoteForm";
            this.Text = "Select Location, Serial Number, and Note";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
