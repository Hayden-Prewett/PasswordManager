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

        private void lstPasswordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when index selected, open LoginInfo Form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // end execution
            System.Windows.Forms.Application.Exit();
        }
    }
}
