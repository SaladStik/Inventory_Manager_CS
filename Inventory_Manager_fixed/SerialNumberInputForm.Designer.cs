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
            promptLabel.Location = new Point(8, 5);
            promptLabel.Margin = new Padding(2, 0, 2, 0);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(112, 15);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Enter serial number:";
            // 
            // serialNumberTextBox
            // 
            serialNumberTextBox.Location = new Point(8, 22);
            serialNumberTextBox.Margin = new Padding(2);
            serialNumberTextBox.Name = "serialNumberTextBox";
            serialNumberTextBox.Size = new Size(253, 23);
            serialNumberTextBox.TabIndex = 1;
            serialNumberTextBox.KeyPress += serialNumberTextBox_KeyPress;
            // 
            // okButton
            // 
            okButton.Location = new Point(152, 51);
            okButton.Margin = new Padding(2);
            okButton.Name = "okButton";
            okButton.Size = new Size(52, 28);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(209, 49);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(52, 30);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // SerialNumberInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 82);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(serialNumberTextBox);
            Controls.Add(promptLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SerialNumberInputForm";
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
