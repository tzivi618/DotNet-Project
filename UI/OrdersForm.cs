using System.Globalization;
using BlApi;
using BO;

namespace UI
{
    public partial class OrdersForm : Form
    {
        private static IBl _bl = BlApi.Factory.Get;
        Order order;
        string name;
        bool isSpecialCustomer;

        public OrdersForm(bool _isSpecialCustomer, string? _name)
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProducts();
            name = _name;
            isSpecialCustomer = _isSpecialCustomer;
            order = new Order(isSpecialCustomer);
            helloCustomer.Text = "שלום " + name;
            totalPriceToDisplay.Text = "המחיר לתשלום " + string.Format(CultureInfo.GetCultureInfo("he-IL"), "{0:C}", order.TotalPrice);


        }
        private void LoadProducts()
        {


            var products = _bl.Product.ReadAll();
            if (products == null || !products.Any())
            {
                MessageBox.Show("לא הצלחנו לטעון מוצרים.");
                return;
            }


            chooseProducts.DisplayMember = "ProdName";
            chooseProducts.ValueMember = "ProdId";


            chooseProducts.DataSource = products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chooseProducts.SelectedValue == null)
            {
                MessageBox.Show("אנא בחר מוצר.");
                return;

            }
            try
            {
                int selectedProductId = (int)chooseProducts.SelectedValue;

                List<SaleInProduct> saleInProductsList = _bl.Order.AddProductToOrder(order, selectedProductId, (int)quantityForSaleUpDown.Value);
                allProductInOrderTbl.Rows.Clear();
                quantityForSaleUpDown.Value = 1;
                foreach (var productInOrder in order.ProductsInOrderList)
                {
                    allProductInOrderTbl.Rows.Add(productInOrder.ProdId, productInOrder.ProdName, productInOrder.CountInOrder, productInOrder.BasePrice, productInOrder.FinalPrice);
                }
                totalPriceToDisplay.Text = "המחיר לתשלום " + string.Format(CultureInfo.GetCultureInfo("he-IL"), "{0:C}", order.TotalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void payOrderBtn_Click(object sender, EventArgs e)
        {
            string message = string.Format(CultureInfo.GetCultureInfo("he-IL"),
                "האם אתה מאשר ביצוע ההזמנה ותשלום על סך {0:C}?", order.TotalPrice);

            string title = "אישור תשלום";

            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _bl.Order.DoOrder(order);
                ShowThankYouMessage();
                this.Close();
            }
        }
        private async void ShowThankYouMessage()
        {
            ThankYouForm thankYouForm = new ThankYouForm();
            thankYouForm.Show();

            await Task.Delay(2500);

            thankYouForm.Close();
        }


    }




}
