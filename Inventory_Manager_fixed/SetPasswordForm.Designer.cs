namespace Inventory_Manager
{
    partial class SetPasswordForm
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
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(12, 12);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(258, 31);
            this.newPasswordTextBox.TabIndex = 0;
            // 
            // setPasswordButton
            // 
            this.setPasswordButton.Location = new System.Drawing.Point(12, 49);
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.Size = new System.Drawing.Size(258, 34);
            this.setPasswordButton.TabIndex = 1;
            this.setPasswordButton.Text = "Set Password";
            this.setPasswordButton.UseVisualStyleBackColor = true;
            this.setPasswordButton.Click += new System.EventHandler(this.setPasswordButton_Click);
            // 
            // SetPasswordForm
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form border style to FixedDialog
            MaximizeBox = false; // Disable the maximize button
            this.AcceptButton = this.setPasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.setPasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Name = "SetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button setPasswordButton;
    }
}
