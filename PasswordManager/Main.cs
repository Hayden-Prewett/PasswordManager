namespace PasswordManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void AddPassword_Click(object sender, EventArgs e)
        {
            // When the AddPassword button is clicked
            var AddPassword = new AddPassword();
            AddPassword.Show();
        }

        private void buttonRemovePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
