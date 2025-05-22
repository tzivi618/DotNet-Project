using BlApi;


namespace UI
{
    public partial class MainMenu : Form
    {
        static readonly IBl s_bl = Factory.Get;
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void customersButton_Click_1(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductFormGood form = new ProductFormGood();
            form.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SaleForm form = new SaleForm();
            form.Show();
        }

        private void CleanOldLogDirectories_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.LogManager.CleanOldLogDirectories();
                MessageBox.Show("הקבצים נמחקו בהצלחה");
            }
            catch (Exception ex){
                MessageBox.Show("שגיאה במחיקת הקבצים");
            }



        }
    }
}
