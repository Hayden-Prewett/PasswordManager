namespace PasswordManager
{
    partial class AddPassword
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
            btnApplyAddPassword = new Button();
            lblWebsiteName = new Label();
            txtWebsite = new TextBox();
            textBox1 = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnApplyAddPassword
            // 
            btnApplyAddPassword.Location = new Point(657, 405);
            btnApplyAddPassword.Name = "btnApplyAddPassword";
            btnApplyAddPassword.Size = new Size(131, 33);
            btnApplyAddPassword.TabIndex = 0;
            btnApplyAddPassword.Text = "Apply";
            btnApplyAddPassword.UseVisualStyleBackColor = true;
            // 
            // lblWebsiteName
            // 
            lblWebsiteName.AutoSize = true;
            lblWebsiteName.Location = new Point(12, 28);
            lblWebsiteName.Name = "lblWebsiteName";
            lblWebsiteName.Size = new Size(109, 20);
            lblWebsiteName.TabIndex = 2;
            lblWebsiteName.Text = "Website Name:";
            lblWebsiteName.Click += label1_Click;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(127, 25);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(312, 27);
            txtWebsite.TabIndex = 3;
            txtWebsite.TextChanged += txtWebsite_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 27);
            textBox1.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 76);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 27);
            txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 124);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // AddPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(textBox1);
            Controls.Add(lblUsername);
            Controls.Add(txtWebsite);
            Controls.Add(lblWebsiteName);
            Controls.Add(btnApplyAddPassword);
            Name = "AddPassword";
            Text = "AddPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApplyAddPassword;
        private Label lblWebsiteName;
        private TextBox txtWebsite;
        private TextBox textBox1;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}