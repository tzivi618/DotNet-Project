using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class loginForm : BaseForm
    {
        private static IBl _bl = BlApi.Factory.Get;
        public loginForm()
        {
            InitializeComponent();
            
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
