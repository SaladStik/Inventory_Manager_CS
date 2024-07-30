namespace Inventory_Manager
{
    partial class LoginPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            Username_Label = new Label();
            Password_Label = new Label();
            Username_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            SignIn_Button = new Button();
            ForgotPassword_Button = new Button();
            ErrorMessage_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_Label.Location = new Point(195, 7);
            Username_Label.Margin = new Padding(2, 0, 2, 0);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(75, 20);
            Username_Label.TabIndex = 1;
            Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Segoe UI", 11F);
            Password_Label.Location = new Point(195, 47);
            Password_Label.Margin = new Padding(2, 0, 2, 0);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(70, 20);
            Password_Label.TabIndex = 2;
            Password_Label.Text = "Password";
            // 
            // Username_TextBox
            // 
            Username_TextBox.Location = new Point(195, 27);
            Username_TextBox.Margin = new Padding(2, 2, 2, 2);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.PlaceholderText = "Username";
            Username_TextBox.Size = new Size(202, 23);
            Username_TextBox.TabIndex = 3;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(195, 67);
            Password_TextBox.Margin = new Padding(2, 2, 2, 2);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "Password";
            Password_TextBox.Size = new Size(202, 23);
            Password_TextBox.TabIndex = 4;
            Password_TextBox.UseSystemPasswordChar = true;
            // 
            // SignIn_Button
            // 
            SignIn_Button.AutoSize = true;
            SignIn_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignIn_Button.Font = new Font("Segoe UI", 11F);
            SignIn_Button.Location = new Point(195, 94);
            SignIn_Button.Margin = new Padding(2, 2, 2, 2);
            SignIn_Button.Name = "SignIn_Button";
            SignIn_Button.Size = new Size(64, 30);
            SignIn_Button.TabIndex = 5;
            SignIn_Button.Text = "Sign In";
            SignIn_Button.UseVisualStyleBackColor = true;
            SignIn_Button.Click += SignIn_Button_Click;
            // 
            // ForgotPassword_Button
            // 
            ForgotPassword_Button.AutoSize = true;
            ForgotPassword_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ForgotPassword_Button.Font = new Font("Segoe UI", 11F);
            ForgotPassword_Button.Location = new Point(269, 94);
            ForgotPassword_Button.Margin = new Padding(2, 2, 2, 2);
            ForgotPassword_Button.Name = "ForgotPassword_Button";
            ForgotPassword_Button.Size = new Size(128, 30);
            ForgotPassword_Button.TabIndex = 6;
            ForgotPassword_Button.Text = "Forgot Password";
            ForgotPassword_Button.UseVisualStyleBackColor = true;
            ForgotPassword_Button.Click += ForgotPassword_Button_Click;
            // 
            // ErrorMessage_Label
            // 
            ErrorMessage_Label.AutoSize = true;
            ErrorMessage_Label.ForeColor = Color.Red;
            ErrorMessage_Label.Location = new Point(8, 155);
            ErrorMessage_Label.Margin = new Padding(2, 0, 2, 0);
            ErrorMessage_Label.Name = "ErrorMessage_Label";
            ErrorMessage_Label.Size = new Size(0, 15);
            ErrorMessage_Label.TabIndex = 7;
            ErrorMessage_Label.Visible = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 175);
            Controls.Add(ErrorMessage_Label);
            Controls.Add(ForgotPassword_Button);
            Controls.Add(SignIn_Button);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_TextBox);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label Username_Label;
        private Label Password_Label;
        private TextBox Username_TextBox;
        private TextBox Password_TextBox;
        private Button SignIn_Button;
        private Button ForgotPassword_Button;
        private Label ErrorMessage_Label;
    }
}
