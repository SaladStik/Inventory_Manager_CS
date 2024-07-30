namespace Inventory_Manager
{
    partial class UserManagement
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
            UserList_DataGrid = new DataGridView();
            UsersLabel = new Label();
            UsernameLabel = new Label();
            FirstName_Label = new Label();
            LastName_Label = new Label();
            Username_TextBox = new TextBox();
            FirstName_TextBox = new TextBox();
            LastName_TextBox = new TextBox();
            Role_ComboBox = new ComboBox();
            Role_Label = new Label();
            CreateUser_Button = new Button();
            RemoveUser_Button = new Button();
            ResetUserPassword_Button = new Button();
            SetUserPassword_Button = new Button();
            SetRole_ComboBox = new ComboBox();
            SetRole_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)UserList_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // UserList_DataGrid
            // 
            UserList_DataGrid.AllowUserToAddRows = false;
            UserList_DataGrid.AllowUserToDeleteRows = false;
            UserList_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserList_DataGrid.Location = new Point(12, 195);
            UserList_DataGrid.Name = "UserList_DataGrid";
            UserList_DataGrid.ReadOnly = true;
            UserList_DataGrid.RowHeadersWidth = 62;
            UserList_DataGrid.RowTemplate.Height = 28;
            UserList_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserList_DataGrid.Size = new Size(884, 485);
            UserList_DataGrid.TabIndex = 0;
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersLabel.Location = new Point(13, 154);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(85, 38);
            UsersLabel.TabIndex = 1;
            UsersLabel.Text = "Users";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(12, 71);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(91, 25);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username";
            // 
            // FirstName_Label
            // 
            FirstName_Label.AutoSize = true;
            FirstName_Label.Location = new Point(12, 9);
            FirstName_Label.Name = "FirstName_Label";
            FirstName_Label.Size = new Size(97, 25);
            FirstName_Label.TabIndex = 3;
            FirstName_Label.Text = "First Name";
            // 
            // LastName_Label
            // 
            LastName_Label.AutoSize = true;
            LastName_Label.Location = new Point(208, 9);
            LastName_Label.Name = "LastName_Label";
            LastName_Label.Size = new Size(95, 25);
            LastName_Label.TabIndex = 4;
            LastName_Label.Text = "Last Name";
            // 
            // Username_TextBox
            // 
            Username_TextBox.Location = new Point(13, 99);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.Size = new Size(212, 31);
            Username_TextBox.TabIndex = 5;
            Username_TextBox.TextChanged += Username_TextBox_TextChanged;
            // 
            // FirstName_TextBox
            // 
            FirstName_TextBox.Location = new Point(12, 37);
            FirstName_TextBox.Name = "FirstName_TextBox";
            FirstName_TextBox.Size = new Size(190, 31);
            FirstName_TextBox.TabIndex = 6;
            FirstName_TextBox.TextChanged += FirstName_TextBox_TextChanged;
            // 
            // LastName_TextBox
            // 
            LastName_TextBox.Location = new Point(208, 37);
            LastName_TextBox.Name = "LastName_TextBox";
            LastName_TextBox.Size = new Size(204, 31);
            LastName_TextBox.TabIndex = 7;
            LastName_TextBox.TextChanged += LastName_TextBox_TextChanged;
            // 
            // Role_ComboBox
            // 
            Role_ComboBox.FormattingEnabled = true;
            Role_ComboBox.Location = new Point(231, 99);
            Role_ComboBox.Name = "Role_ComboBox";
            Role_ComboBox.Size = new Size(181, 33);
            Role_ComboBox.TabIndex = 8;
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Location = new Point(231, 71);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(46, 25);
            Role_Label.TabIndex = 9;
            Role_Label.Text = "Role";
            // 
            // CreateUser_Button
            // 
            CreateUser_Button.Location = new Point(418, 99);
            CreateUser_Button.Name = "CreateUser_Button";
            CreateUser_Button.Size = new Size(112, 34);
            CreateUser_Button.TabIndex = 10;
            CreateUser_Button.Text = "Create User";
            CreateUser_Button.UseVisualStyleBackColor = true;
            CreateUser_Button.Click += CreateUser_Button_Click;
            // 
            // RemoveUser_Button
            // 
            RemoveUser_Button.Location = new Point(13, 686);
            RemoveUser_Button.Name = "RemoveUser_Button";
            RemoveUser_Button.Size = new Size(126, 35);
            RemoveUser_Button.TabIndex = 11;
            RemoveUser_Button.Text = "Remove User";
            RemoveUser_Button.UseVisualStyleBackColor = true;
            RemoveUser_Button.Click += RemoveUser_Button_Click;
            // 
            // ResetUserPassword_Button
            // 
            ResetUserPassword_Button.Location = new Point(752, 9);
            ResetUserPassword_Button.Name = "ResetUserPassword_Button";
            ResetUserPassword_Button.Size = new Size(144, 35);
            ResetUserPassword_Button.TabIndex = 12;
            ResetUserPassword_Button.Text = "Reset Password";
            ResetUserPassword_Button.UseVisualStyleBackColor = true;
            ResetUserPassword_Button.Click += ResetUserPassword_Button_Click;
            // 
            // SetUserPassword_Button
            // 
            SetUserPassword_Button.Location = new Point(752, 50);
            SetUserPassword_Button.Name = "SetUserPassword_Button";
            SetUserPassword_Button.Size = new Size(144, 35);
            SetUserPassword_Button.TabIndex = 13;
            SetUserPassword_Button.Text = "Set Password";
            SetUserPassword_Button.UseVisualStyleBackColor = true;
            SetUserPassword_Button.Click += SetUserPassword_Button_Click;
            // 
            // SetRole_ComboBox
            // 
            SetRole_ComboBox.FormattingEnabled = true;
            SetRole_ComboBox.Location = new Point(237, 688);
            SetRole_ComboBox.Name = "SetRole_ComboBox";
            SetRole_ComboBox.Size = new Size(181, 33);
            SetRole_ComboBox.TabIndex = 15;
            // 
            // SetRole_Button
            // 
            SetRole_Button.Location = new Point(145, 686);
            SetRole_Button.Name = "SetRole_Button";
            SetRole_Button.Size = new Size(86, 35);
            SetRole_Button.TabIndex = 16;
            SetRole_Button.Text = "Set Role";
            SetRole_Button.UseVisualStyleBackColor = true;
            SetRole_Button.Click += SetRole_Button_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 728);
            Controls.Add(SetRole_Button);
            Controls.Add(SetRole_ComboBox);
            Controls.Add(SetUserPassword_Button);
            Controls.Add(ResetUserPassword_Button);
            Controls.Add(RemoveUser_Button);
            Controls.Add(CreateUser_Button);
            Controls.Add(Role_Label);
            Controls.Add(Role_ComboBox);
            Controls.Add(LastName_TextBox);
            Controls.Add(FirstName_TextBox);
            Controls.Add(Username_TextBox);
            Controls.Add(LastName_Label);
            Controls.Add(FirstName_Label);
            Controls.Add(UsernameLabel);
            Controls.Add(UsersLabel);
            Controls.Add(UserList_DataGrid);
            DoubleBuffered = true;
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)UserList_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.DataGridView UserList_DataGrid;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.ComboBox Role_ComboBox;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.Button CreateUser_Button;
        private System.Windows.Forms.Button RemoveUser_Button;
        private System.Windows.Forms.Button ResetUserPassword_Button;
        private System.Windows.Forms.Button SetUserPassword_Button;
        private System.Windows.Forms.ComboBox SetRole_ComboBox;
        private System.Windows.Forms.Button SetRole_Button;
    }
}
