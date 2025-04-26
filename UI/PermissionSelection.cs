
namespace UI
{
    public partial class PermissionSelection : Form
    {
        private Image backgroundImage;

        public PermissionSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void manager_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
        }

        private void shopkeeperBtn_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
        }
    }
}
