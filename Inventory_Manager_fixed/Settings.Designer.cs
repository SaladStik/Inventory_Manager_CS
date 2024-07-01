namespace Inventory_Manager
{
    partial class Settings
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Tabs = new TabControl();
            MainTab = new TabPage();
            DB_SERVER_IP_BUTTON = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            DB_IMAGES_SERVER_PATH = new TextBox();
            DB_USERNAME_AUTH_LABEL = new Label();
            DB_USERNAME_AUTH_TEXT = new TextBox();
            DB_PASSWORD_AUTH_LABEL = new Label();
            DB_AUTH_BUTTON = new Button();
            DB_PASSWORD_AUTH_TEXT = new TextBox();
            DB_SERVER_IP_LABEL = new Label();
            DB_SERVER_IP_TEXT = new TextBox();
            Tabs.SuspendLayout();
            MainTab.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tabs.Controls.Add(MainTab);
            Tabs.Location = new Point(11, 12);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(440, 703);
            Tabs.TabIndex = 0;
            // 
            // MainTab
            // 
            MainTab.Controls.Add(DB_SERVER_IP_BUTTON);
            MainTab.Controls.Add(groupBox1);
            MainTab.Controls.Add(DB_SERVER_IP_LABEL);
            MainTab.Controls.Add(DB_SERVER_IP_TEXT);
            MainTab.Location = new Point(4, 34);
            MainTab.Name = "MainTab";
            MainTab.Padding = new Padding(3, 3, 3, 3);
            MainTab.Size = new Size(432, 665);
            MainTab.TabIndex = 1;
            MainTab.Text = "Main";
            MainTab.UseVisualStyleBackColor = true;
            // 
            // DB_SERVER_IP_BUTTON
            // 
            DB_SERVER_IP_BUTTON.Location = new Point(6, 77);
            DB_SERVER_IP_BUTTON.Name = "DB_SERVER_IP_BUTTON";
            DB_SERVER_IP_BUTTON.Size = new Size(111, 43);
            DB_SERVER_IP_BUTTON.TabIndex = 8;
            DB_SERVER_IP_BUTTON.Text = "Set";
            DB_SERVER_IP_BUTTON.UseVisualStyleBackColor = true;
            DB_SERVER_IP_BUTTON.Click += DB_SERVER_IP_BUTTON_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DB_IMAGES_SERVER_PATH);
            groupBox1.Controls.Add(DB_USERNAME_AUTH_LABEL);
            groupBox1.Controls.Add(DB_USERNAME_AUTH_TEXT);
            groupBox1.Controls.Add(DB_PASSWORD_AUTH_LABEL);
            groupBox1.Controls.Add(DB_AUTH_BUTTON);
            groupBox1.Controls.Add(DB_PASSWORD_AUTH_TEXT);
            groupBox1.Location = new Point(6, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 333);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Images Server";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 6;
            label1.Text = "Images Database Server Path";
            // 
            // DB_IMAGES_SERVER_PATH
            // 
            DB_IMAGES_SERVER_PATH.Location = new Point(10, 55);
            DB_IMAGES_SERVER_PATH.Name = "DB_IMAGES_SERVER_PATH";
            DB_IMAGES_SERVER_PATH.PlaceholderText = "ex: \\\\Server\\Share\\Data\\Images";
            DB_IMAGES_SERVER_PATH.Size = new Size(333, 31);
            DB_IMAGES_SERVER_PATH.TabIndex = 5;
            // 
            // DB_USERNAME_AUTH_LABEL
            // 
            DB_USERNAME_AUTH_LABEL.AutoSize = true;
            DB_USERNAME_AUTH_LABEL.Location = new Point(10, 100);
            DB_USERNAME_AUTH_LABEL.Name = "DB_USERNAME_AUTH_LABEL";
            DB_USERNAME_AUTH_LABEL.Size = new Size(91, 25);
            DB_USERNAME_AUTH_LABEL.TabIndex = 0;
            DB_USERNAME_AUTH_LABEL.Text = "Username";
            DB_USERNAME_AUTH_LABEL.Click += label1_Click;
            // 
            // DB_USERNAME_AUTH_TEXT
            // 
            DB_USERNAME_AUTH_TEXT.Location = new Point(10, 128);
            DB_USERNAME_AUTH_TEXT.Name = "DB_USERNAME_AUTH_TEXT";
            DB_USERNAME_AUTH_TEXT.Size = new Size(215, 31);
            DB_USERNAME_AUTH_TEXT.TabIndex = 1;
            // 
            // DB_PASSWORD_AUTH_LABEL
            // 
            DB_PASSWORD_AUTH_LABEL.AutoSize = true;
            DB_PASSWORD_AUTH_LABEL.Location = new Point(10, 163);
            DB_PASSWORD_AUTH_LABEL.Name = "DB_PASSWORD_AUTH_LABEL";
            DB_PASSWORD_AUTH_LABEL.Size = new Size(87, 25);
            DB_PASSWORD_AUTH_LABEL.TabIndex = 2;
            DB_PASSWORD_AUTH_LABEL.Text = "Password";
            // 
            // DB_AUTH_BUTTON
            // 
            DB_AUTH_BUTTON.Location = new Point(10, 235);
            DB_AUTH_BUTTON.Name = "DB_AUTH_BUTTON";
            DB_AUTH_BUTTON.Size = new Size(127, 42);
            DB_AUTH_BUTTON.TabIndex = 4;
            DB_AUTH_BUTTON.Text = "Authenticate";
            DB_AUTH_BUTTON.UseVisualStyleBackColor = true;
            DB_AUTH_BUTTON.Click += DB_AUTH_BUTTON_Click;
            // 
            // DB_PASSWORD_AUTH_TEXT
            // 
            DB_PASSWORD_AUTH_TEXT.Location = new Point(10, 190);
            DB_PASSWORD_AUTH_TEXT.Name = "DB_PASSWORD_AUTH_TEXT";
            DB_PASSWORD_AUTH_TEXT.PasswordChar = 'ඞ';
            DB_PASSWORD_AUTH_TEXT.Size = new Size(215, 31);
            DB_PASSWORD_AUTH_TEXT.TabIndex = 3;
            // 
            // DB_SERVER_IP_LABEL
            // 
            DB_SERVER_IP_LABEL.AutoSize = true;
            DB_SERVER_IP_LABEL.Location = new Point(6, 3);
            DB_SERVER_IP_LABEL.Name = "DB_SERVER_IP_LABEL";
            DB_SERVER_IP_LABEL.Size = new Size(160, 25);
            DB_SERVER_IP_LABEL.TabIndex = 6;
            DB_SERVER_IP_LABEL.Text = "Database Server IP";
            // 
            // DB_SERVER_IP_TEXT
            // 
            DB_SERVER_IP_TEXT.Location = new Point(6, 32);
            DB_SERVER_IP_TEXT.Name = "DB_SERVER_IP_TEXT";
            DB_SERVER_IP_TEXT.Size = new Size(263, 31);
            DB_SERVER_IP_TEXT.TabIndex = 5;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 728);
            Controls.Add(Tabs);
            Name = "Settings";
            Text = "Settings";
            Tabs.ResumeLayout(false);
            MainTab.ResumeLayout(false);
            MainTab.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage MainTab;
        private TextBox DB_USERNAME_AUTH_TEXT;
        private Label DB_USERNAME_AUTH_LABEL;
        private Button DB_AUTH_BUTTON;
        private TextBox DB_PASSWORD_AUTH_TEXT;
        private Label DB_PASSWORD_AUTH_LABEL;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox DB_IMAGES_SERVER_PATH;
        private Label DB_SERVER_IP_LABEL;
        private TextBox DB_SERVER_IP_TEXT;
        private Button DB_SERVER_IP_BUTTON;
    }
}