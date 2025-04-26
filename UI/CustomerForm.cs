using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class CustomerForm : BaseForm
    {
        private static IBl _bl = BlApi.Factory.Get;
        public CustomerForm()
        {
            InitializeComponent();
            PrintAllCustomers();

        }
        public void PrintAllCustomers()
        {
            List<Customer> customers = _bl.Customer.ReadAll();
            PrintCustomersToTheListBox(customers);
        }

        private int isValidId(string id)
        {
            int customerId;
            if (!int.TryParse(id, out customerId))
            {
                MessageBox.Show("מספר זהות לא חוקי");
                return -1;
            }
            return customerId;
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            int customerId = isValidId(CustomerIdInput.Text);
            if (customerId == -1)
                return;
            if (string.IsNullOrWhiteSpace(CustomerAddressInput.Text) || string.IsNullOrWhiteSpace(CustomerNameInput.Text) || string.IsNullOrWhiteSpace(CustomerTelInput.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }
            Customer c = new Customer
            (
                customerId,
                CustomerNameInput.Text,
                CustomerAddressInput.Text,
                CustomerTelInput.Text
            );

            try
            {
                _bl.Customer.Create(c);
                MessageBox.Show("הלקוח נוסף בהצלחה");
                PrintAllCustomerWithFilter();

            }
            catch (Exception ex)
            {
                //errorProvider1.GetError(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int customerId = isValidId(idInputToUpdate.Text);
            if (customerId == -1)
                return;
            try
            {
                Customer c = _bl.Customer.Read(customerId);
                customerNameToUpdate.Text = c.CustomerName;
                customerPhoneToUpdate.Text = c.CustomerPhone;
                customerAddressToUpdate.Text = c.CustomerAddress;
                idInputToUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameToUpdate.Text) || string.IsNullOrWhiteSpace(customerAddressToUpdate.Text) || string.IsNullOrWhiteSpace(customerPhoneToUpdate.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }
            Customer c = new Customer
            (
               Convert.ToInt32(idInputToUpdate.Text),
               customerNameToUpdate.Text,
                customerAddressToUpdate.Text,
                customerPhoneToUpdate.Text
            );

            try
            {
                _bl.Customer.Update(c);
                MessageBox.Show("הלקוח עודכן בהצלחה");
                PrintAllCustomerWithFilter();
                idInputToUpdate.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("האם אתה בטוח?", "אישור", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _bl.Customer.Delete(Convert.ToInt32(idInputToDelete.Text));
                    MessageBox.Show("הלקוח נמחק בהצלחה");
                    PrintAllCustomerWithFilter();
                    userDetialsToDelete.Items.Clear();
                    idInputToDelete.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idBottonToDelete_Click(object sender, EventArgs e)
        {

            int customerId = isValidId(idInputToDelete.Text);
            if (customerId == -1)
                return;
            try
            {
                Customer c = _bl.Customer.Read(customerId);
                userDetialsToDelete.Items.Add("שם הלקוח: " + c.CustomerName);
                userDetialsToDelete.Items.Add("מספר טלפון: " + c.CustomerPhone);
                userDetialsToDelete.Items.Add("כתובת: " + c.CustomerAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            userDetailInReadOne.Items.Clear();
            int customerId = isValidId(idInputToReadOne.Text);
            if (customerId == -1)
                return;
            try
            {
                Customer c = _bl.Customer.Read(customerId);
                userDetailInReadOne.Items.Add("שם הלקוח: " + c.CustomerName);
                userDetailInReadOne.Items.Add("מספר טלפון: " + c.CustomerPhone);
                userDetailInReadOne.Items.Add("כתובת: " + c.CustomerAddress);
                idInputToReadOne.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchCustomerInputBtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            PrintAllCustomerWithFilter();


        }
        public void PrintAllCustomerWithFilter()
        {
            allCustomerListBox.Items.Clear();
            List<Customer> customers = _bl.Customer.ReadAll(c => c.CustomerPhone.Contains(searchCustomerInputBtPhoneNumber.Text));
            PrintCustomersToTheListBox(customers);

        }

        private void PrintCustomersToTheListBox(List<Customer> customers)
        {
            foreach (var c in customers)
            {
                allCustomerListBox.Items.Add("מספר זהות: "+c.CustomerId);
                allCustomerListBox.Items.Add("שם הלקוח: " + c.CustomerName);
                allCustomerListBox.Items.Add("מספר טלפון: " + c.CustomerPhone);
                allCustomerListBox.Items.Add("כתובת: " + c.CustomerAddress);
                                allCustomerListBox.Items.Add("________________________________");

            }
        }
    }

}
