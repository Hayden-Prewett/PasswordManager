namespace PasswordManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddPassword = new Button();
            btnChangePassword = new Button();
            btnRemovePassword = new Button();
            lsPasswordList = new ListBox();
            SuspendLayout();
            // 
            // btnAddPassword
            // 
            btnAddPassword.Location = new Point(25, 12);
            btnAddPassword.Name = "btnAddPassword";
            btnAddPassword.Size = new Size(236, 36);
            btnAddPassword.TabIndex = 0;
            btnAddPassword.Text = "Add a password";
            btnAddPassword.UseVisualStyleBackColor = true;
            btnAddPassword.Click += btnAddPassword_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(277, 12);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(236, 36);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "Change a password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnRemovePassword
            // 
            btnRemovePassword.Location = new Point(535, 12);
            btnRemovePassword.Name = "btnRemovePassword";
            btnRemovePassword.Size = new Size(236, 36);
            btnRemovePassword.TabIndex = 2;
            btnRemovePassword.Text = "Remove a password";
            btnRemovePassword.UseVisualStyleBackColor = true;
            btnRemovePassword.Click += btnRemovePassword_Click;
            // 
            // lsPasswordList
            // 
            lsPasswordList.FormattingEnabled = true;
            lsPasswordList.Location = new Point(25, 86);
            lsPasswordList.Name = "lsPasswordList";
            lsPasswordList.Size = new Size(746, 344);
            lsPasswordList.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsPasswordList);
            Controls.Add(btnRemovePassword);
            Controls.Add(btnChangePassword);
            Controls.Add(btnAddPassword);
            Name = "Main";
            Text = "Password Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPassword;
        private Button btnChangePassword;
        private Button btnRemovePassword;
       private ListBox lsPasswordList;
    }
}
