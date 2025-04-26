using System.Globalization;
using BlApi;
using BO;

namespace UI
{
    public partial class ProductFormGood : BaseForm
    {
        private static IBl _bl = BlApi.Factory.Get;
        public ProductFormGood()
        {
            InitializeComponent();
                       PrintAllproducts();
            foreach (var e in Enum.GetValues(typeof(Categories)))
            {
                searchProductByCategoryCombo.Items.Add(e);
                chooseCategoryAddComboBox.Items.Add(e);
            }
            searchProductByCategoryCombo.Items.Add("הכל");
        }
        public void PrintAllproducts()
        {
            List<Product> products = _bl.Product.ReadAll();
            PrintProductsToTheListBox(products);
        }

        private int isValidId(string id)
        {
            int productId;
            if (!int.TryParse(id, out productId))
            {
                MessageBox.Show("מספר זהות לא חוקי");
                return -1;
            }
            return productId;
        }


        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameInput.Text) || chooseCategoryAddComboBox.SelectedItem == null || priceNumericUpDown.Value == priceNumericUpDown.Minimum)
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }
            string selectedCategory = chooseCategoryAddComboBox.Text;
            Categories category;
            if (!Enum.TryParse(selectedCategory, true, out category))
            {
                MessageBox.Show("קטגוריה לא תקפה.");
                return;
            }
            Product product = new Product(
    0,
    ProductNameInput.Text,
    category,
    (double)priceNumericUpDown.Value,
    (int)QuantityNumericUpDown.Value
);
            product.Sales = new List<SaleInProduct>();
            try
            {
                _bl.Product.Create(product);
                MessageBox.Show("המוצר נוסף בהצלחה");
                PrintAllProductWithFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void updateBtn_Click(object sender, EventArgs e)
        {
            int productId = isValidId(idInputToUpdateProduct.Text);
            if (productId == -1)
                return;
            try
            {
                Product p = _bl.Product.Read(productId);
                productNameToUpdate.Text = p.ProdName;
                PriceNumericUpDownToUpdate.Value = (decimal)p.Price;
                quantityNumericUpDownToUpdate.Value = p.Quantity;
                idInputToUpdateProduct.Enabled = false;
                categoryComboBoxToUpdate.Items.Clear();
                foreach (var category in Enum.GetValues(typeof(Categories)))
                {
                    categoryComboBoxToUpdate.Items.Add(category);
                }

                categoryComboBoxToUpdate.SelectedItem = p.ProdCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void saveProductUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameToUpdate.Text) || PriceNumericUpDownToUpdate.Value == PriceNumericUpDownToUpdate.Minimum)
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            string selectedCategory = categoryComboBoxToUpdate.Text;
            Categories category;
            if (!Enum.TryParse(selectedCategory, true, out category))
            {
                MessageBox.Show("קטגוריה לא תקפה.");
                return;
            }

            Product product = new Product(
                Convert.ToInt32(idInputToUpdateProduct.Text),
                productNameToUpdate.Text,
                category,
                (double)PriceNumericUpDownToUpdate.Value,
                (int)quantityNumericUpDownToUpdate.Value
            );

            try
            {
                _bl.Product.Update(product);
                MessageBox.Show("המוצר עודכן בהצלחה");
                PrintAllProductWithFilter();
                idInputToUpdateProduct.Enabled = true;

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
                    _bl.Product.Delete(Convert.ToInt32(idInputToDelete.Text));
                    MessageBox.Show("המוצר נמחק בהצלחה");
                    PrintAllProductWithFilter();
                    productDetialsToDelete.Items.Clear();
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

            int prodId = isValidId(idInputToDelete.Text);
            if (prodId == -1)
                return;
            try
            {
                Product p = _bl.Product.Read(prodId);
                productDetialsToDelete.Items.Add("מזהה: " + p.ProdId);
                productDetialsToDelete.Items.Add("שם המוצר: " + p.ProdName);
                productDetialsToDelete.Items.Add("קטגוריה: " + p.ProdCategory);
                productDetialsToDelete.Items.Add("מחיר: " + string.Format(CultureInfo.GetCultureInfo("he-IL"), "{0:C}", p.Price));
                productDetialsToDelete.Items.Add("הכמות במלאי: " + p.Quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            productDetialsToReadOne.Items.Clear();
            int prodId = isValidId(idInputToReadOne.Text);
            if (prodId == -1)
                return;
            try
            {
                Product p = _bl.Product.Read(prodId);
                productDetialsToReadOne.Items.Add("מזהה: " + p.ProdId);
                productDetialsToReadOne.Items.Add("שם המוצר: " + p.ProdName);
                productDetialsToReadOne.Items.Add("קטגוריה: " + p.ProdCategory);
                productDetialsToReadOne.Items.Add("מחיר: " + string.Format(CultureInfo.GetCultureInfo("he-IL"), "{0:C}", p.Price));
                productDetialsToReadOne.Items.Add("הכמות במלאי: " + p.Quantity);
                idInputToReadOne.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchProductByCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchProductByCategoryCombo.Text == "הכל" || searchProductByCategoryCombo.SelectedIndex == -1)
                PrintAllproducts();
            else
                PrintAllProductWithFilter();
        }
        public void PrintAllProductWithFilter()
        {
            allProductsListBox.Items.Clear();
            List<Product> products;

            if (searchProductByCategoryCombo.SelectedIndex == -1)
            {
                products = _bl.Product.ReadAll();
            }
            else
            {
                products = _bl.Product.ReadAll(p => p.ProdCategory == (Categories)Enum.Parse(typeof(Categories), searchProductByCategoryCombo.Text));
            }
            PrintProductsToTheListBox(products);
        }

        private void PrintProductsToTheListBox(List<Product> products)
        {
            foreach (var p in products)
            {
                allProductsListBox.Items.Add("מזהה: " + p.ProdId);
                allProductsListBox.Items.Add("שם המוצר: " + p.ProdName);
                allProductsListBox.Items.Add("קטגוריה: " + p.ProdCategory);
                allProductsListBox.Items.Add("מחיר: " + string.Format(CultureInfo.GetCultureInfo("he-IL"), "{0:C}", p.Price));
                allProductsListBox.Items.Add("הכמות במלאי: " + p.Quantity);
                allProductsListBox.Items.Add("______________________________");
            }
        }

    }

}
