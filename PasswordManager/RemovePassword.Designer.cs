namespace PasswordManager
{
    partial class RemovePassword
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
            lstSearchResults = new ListBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            label1 = new Label();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.Location = new Point(12, 129);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new Size(753, 264);
            lstSearchResults.TabIndex = 0;
            lstSearchResults.SelectedIndexChanged += lstSearchResults_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(126, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(584, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(58, 85);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(194, 31);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 3;
            label1.Text = "Select a website from the list below or search";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(645, 412);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 26);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemovePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lstSearchResults);
            Name = "RemovePassword";
            Text = "RemovePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSearchResults;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label label1;
        private Button btnRemove;
    }
}