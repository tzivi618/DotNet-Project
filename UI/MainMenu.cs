using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainMenu : BaseForm
    {
        static readonly IBl s_bl = Factory.Get;
        public MainMenu()
        {
            InitializeComponent();
           
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
    }
}
