using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class PermissionSelection : BaseForm
    {
        private Image backgroundImage;

        public PermissionSelection()
        {
            InitializeComponent();
           

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
