using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class SerialNumberInputForm : Form
    {
        public string EnteredSerialNumber { get; private set; }

        

        private void ProcessSerialNumber()
        {
            EnteredSerialNumber = serialNumberTextBox.Text.Trim();
            if (string.IsNullOrEmpty(EnteredSerialNumber))
            {
                MessageBox.Show("Serial number cannot be empty. Please enter a valid serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialNumberInputForm));
            promptLabel = new Label();
            serialNumberTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(11, 8);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(168, 25);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Enter serial number:";
            // 
            // serialNumberTextBox
            // 
            serialNumberTextBox.Location = new Point(11, 37);
            serialNumberTextBox.Name = "serialNumberTextBox";
            serialNumberTextBox.Size = new Size(360, 31);
            serialNumberTextBox.TabIndex = 1;
            serialNumberTextBox.KeyPress += serialNumberTextBox_KeyPress;
            // 
            // okButton
            // 
            okButton.Location = new Point(217, 85);
            okButton.Name = "okButton";
            okButton.Size = new Size(74, 47);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(299, 82);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(74, 50);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // SerialNumberInputForm
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 137);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(serialNumberTextBox);
            Controls.Add(promptLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SerialNumberInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serial Number Input";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
