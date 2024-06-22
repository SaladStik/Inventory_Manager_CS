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
            this.promptLabel = new System.Windows.Forms.Label();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(12, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(190, 25);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter serial number:";
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(12, 37);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(360, 31);
            this.serialNumberTextBox.TabIndex = 1;
            this.serialNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serialNumberTextBox_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(216, 74);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(297, 74);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SerialNumberInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 120);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "SerialNumberInputForm";
            this.Text = "Serial Number Input";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
