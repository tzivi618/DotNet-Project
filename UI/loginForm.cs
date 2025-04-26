using BlApi;

namespace UI
{
    public partial class loginForm : Form
    {
        private static IBl _bl = BlApi.Factory.Get;
        public loginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void checkCustomerBtn_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(customerIdLogin.Text, out customerId))
            {
                MessageBox.Show("מספר זהות לא חוקי");
                return;
            }
            try
            {
               string customerName= _bl.Customer.Read(customerId).CustomerName;
                OrdersForm form = new OrdersForm(true, customerName);
                form.Show();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("מזהה הלקוח לא מופיע, לנסות שוב?",
                                               "אישור ",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    return;
                OrdersForm form = new OrdersForm(false,"לקוח מזדמן");
                form.Show();
            }
               ;
            ;

        }
    }
}
