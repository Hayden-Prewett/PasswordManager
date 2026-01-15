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
            AddPassword = new Button();
            ChangePassword = new Button();
            RemovePassword = new Button();
            SuspendLayout();
            // 
            // AddPassword
            // 
            AddPassword.Location = new Point(25, 15);
            AddPassword.Name = "AddPassword";
            AddPassword.Size = new Size(249, 36);
            AddPassword.TabIndex = 0;
            AddPassword.Text = "Add a password";
            AddPassword.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            ChangePassword.Location = new Point(280, 15);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(249, 36);
            ChangePassword.TabIndex = 1;
            ChangePassword.Text = "Change a password";
            ChangePassword.UseVisualStyleBackColor = true;
            // 
            // RemovePassword
            // 
            RemovePassword.Location = new Point(535, 15);
            RemovePassword.Name = "RemovePassword";
            RemovePassword.Size = new Size(249, 36);
            RemovePassword.TabIndex = 2;
            RemovePassword.Text = "Remove a password";
            RemovePassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemovePassword);
            Controls.Add(ChangePassword);
            Controls.Add(AddPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddPassword;
        private Button ChangePassword;
        private Button RemovePassword;
    }
}
