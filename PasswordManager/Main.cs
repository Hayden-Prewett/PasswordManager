namespace PasswordManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void btnAddPassword_Click(object sender, EventArgs e)
        {
            // When the Add Password button is clicked, open AddPassword form
            var AddPassword = new AddPassword();
            AddPassword.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // When the Change Password button is clicked, open the ChangePassword form
            // coming soon
        }

        private void btnRemovePassword_Click(object sender, EventArgs e)
        {
            // When the remove password button is clicked, open the RemovePassword form
            // coming soon
        }
    }
}
