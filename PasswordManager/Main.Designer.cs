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
            lblPasswordManagerTitle = new Label();
            dataGridView1 = new DataGridView();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPassword
            // 
            btnAddPassword.Location = new Point(12, 402);
            btnAddPassword.Name = "btnAddPassword";
            btnAddPassword.Size = new Size(202, 36);
            btnAddPassword.TabIndex = 0;
            btnAddPassword.Text = "Add a password";
            btnAddPassword.UseVisualStyleBackColor = true;
            btnAddPassword.Click += btnAddPassword_Click;
            // 
            // lblPasswordManagerTitle
            // 
            lblPasswordManagerTitle.AutoSize = true;
            lblPasswordManagerTitle.Font = new Font("Segoe UI", 15F);
            lblPasswordManagerTitle.Location = new Point(284, 30);
            lblPasswordManagerTitle.Name = "lblPasswordManagerTitle";
            lblPasswordManagerTitle.Size = new Size(226, 35);
            lblPasswordManagerTitle.TabIndex = 4;
            lblPasswordManagerTitle.Text = "Password Manager";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 292);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(535, 402);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(236, 36);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(dataGridView1);
            Controls.Add(lblPasswordManagerTitle);
            Controls.Add(btnAddPassword);
            Name = "Main";
            Text = "Password Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPassword;
        private Label lblPasswordManagerTitle;
        private DataGridView dataGridView1;
        private Button btnQuit;
    }
}
