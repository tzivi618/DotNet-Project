using BlApi;
using BO;

namespace UI
{
    public partial class SaleForm : Form
    {
        private static IBl _bl = BlApi.Factory.Get;
        public SaleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            PrintAllCustomers();
        }
        public void PrintAllCustomers()
        {
            List<Sale> sales = _bl.Sale.ReadAll();
            PrintSaleToTheListBox(sales);
        }
        private void tabControlSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkIsAllCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            if (QuentityForSale.Value == QuentityForSale.Minimum || TotalPriceSale.Value == TotalPriceSale.Minimum || string.IsNullOrWhiteSpace(prodIdInput.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }
            Sale s = new Sale
            (
                 1,
                 Convert.ToInt32(prodIdInput.Text),
                 Convert.ToInt32(QuentityForSale.Value),
                 Convert.ToInt32(TotalPriceSale.Value),
                 checkIsAllCustomer.Checked,
                 StartDateCheck.Value,
                 EndDateCheck.Value
            );

            try
            {
                _bl.Sale.Create(s);
                MessageBox.Show("המבצע נוסף בהצלחה");
                prodIdInput.Text = "";
                quantityForSale.Value = quantityForSale.Minimum;
                totalPriceForSale.Value = totalPriceForSale.Minimum;
                isAllCustomer.Checked = false;
                startDate.Value = (DateTime)s.StartDate;
                endDate.Value = (DateTime)s.EndDate;
                PrintAllSalesWithFilter();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
       
        private void userDetialsToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void PrintAllSalesWithFilter()
        {
            allSaleListBox.Items.Clear();
            allSaleListBox.Items.Clear();
            int searchProdId;
            List<Sale> sales;
            if (int.TryParse(searchInput.Text, out searchProdId)|| searchInput.Text== string.Empty)
            {
                if (searchInput.Text == string.Empty)
                   sales = _bl.Sale.ReadAll();
                else
                   sales = _bl.Sale.ReadAll(s => s.ProdId == searchProdId);
                PrintSaleToTheListBox(sales);  
            }
            else
            {
                MessageBox.Show("הכנס מספר תקין לחיפוש.");
            }
          

        }
        private void PrintSaleToTheListBox(List<Sale> sales)
        {
            foreach (var s in sales)
            {
                allSaleListBox.Items.Add("מזהה מבצע: " + s.SaleId);
                allSaleListBox.Items.Add("מזהה מוצר: " + s.ProdId);
                allSaleListBox.Items.Add("כמות למבצע: " + s.QuentityForSale);
                allSaleListBox.Items.Add("מחיר כולל: " + s.TotalPriceSale);
                if (s.IsAllCustomer)
                    allSaleListBox.Items.Add("מיועד לכלל הלקוחות");
                else
                    allSaleListBox.Items.Add("מיועד ללקוחות מועדון בלבד");
                allSaleListBox.Items.Add("תאריך התחלת המבצע: " + s.StartDate);
                allSaleListBox.Items.Add("תאריך סיום המבצע: " + s.EndDate);
                allSaleListBox.Items.Add("______________________________________________________");

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int saleId = isValidId(idInputToUpdate.Text);
            if (saleId == -1)
                return;
            try
            {
                Sale s = _bl.Sale.Read(saleId);
                prodId.Text = Convert.ToString(s.ProdId);
                quantityForSale.Value = s.QuentityForSale;
                totalPriceForSale.Value = (decimal)s.TotalPriceSale;
                isAllCustomer.Checked = s.IsAllCustomer;
                startDate.Value = (DateTime)s.StartDate;
                endDate.Value = (DateTime)s.EndDate;
                idInputToUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (QuentityForSale.Value == QuentityForSale.Minimum || TotalPriceSale.Value == TotalPriceSale.Minimum || string.IsNullOrWhiteSpace(prodIdInput.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }
            Sale s = new Sale
            (
                 1,
                 Convert.ToInt32(prodIdInput.Text),
                 Convert.ToInt32(QuentityForSale.Value),
                 Convert.ToInt32(TotalPriceSale.Value),
                 checkIsAllCustomer.Checked,
                 StartDateCheck.Value,
                 EndDateCheck.Value
            );

            try
            {
                _bl.Sale.Update(s);
                MessageBox.Show("המבצע עודכן בהצלחה");
                PrintAllSalesWithFilter();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idBottonToDelete_Click_1(object sender, EventArgs e)
        {
            int saleId = isValidId(idInputToDelete.Text);
            if (saleId == -1)
                return;
            try
            {
                Sale s = _bl.Sale.Read(saleId);
                saleDetialsToDelete.Items.Add("מזהה מבצע: " + s.SaleId);
                saleDetialsToDelete.Items.Add("מזהה מוצר: " + s.ProdId);
                saleDetialsToDelete.Items.Add("כמות למבצע: " + s.QuentityForSale);
                saleDetialsToDelete.Items.Add("מחיר כולל: " + s.TotalPriceSale);
                if (s.IsAllCustomer)
                    saleDetialsToDelete.Items.Add("מיועד לכלל הלקוחות");
                else
                    saleDetialsToDelete.Items.Add("מיועד ללקוחות מועדון בלבד");
                saleDetialsToDelete.Items.Add("תאריך התחלת המבצע: " + s.StartDate);
                saleDetialsToDelete.Items.Add("תאריך סיום המבצע: " + s.EndDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("האם אתה בטוח?", "אישור", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _bl.Sale.Delete(Convert.ToInt32(idInputToDelete.Text));
                    MessageBox.Show("המבצע נמחק בהצלחה");
                    PrintAllSalesWithFilter();
                    saleDetialsToDelete.Items.Clear();
                    idInputToDelete.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            saleDetailInReadOne.Items.Clear();
            int saleId = isValidId(idInputToReadOne.Text);
            if (saleId == -1)
                return;
            try
            {
                Sale s = _bl.Sale.Read(saleId);
                saleDetailInReadOne.Items.Add("מזהה מבצע: " + s.SaleId);
                saleDetailInReadOne.Items.Add("מזהה מוצר: " + s.ProdId);
                saleDetailInReadOne.Items.Add("כמות למבצע: " + s.QuentityForSale);
                saleDetailInReadOne.Items.Add("מחיר כולל: " + s.TotalPriceSale);
                if (s.IsAllCustomer)
                    saleDetailInReadOne.Items.Add("מיועד לכלל הלקוחות");
                else
                    saleDetailInReadOne.Items.Add("מיועד ללקוחות מועדון בלבד");
                saleDetailInReadOne.Items.Add("תאריך התחלת המבצע: " + s.StartDate);
                saleDetailInReadOne.Items.Add("תאריך סיום המבצע: " + s.EndDate);
                saleDetailInReadOne.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrintAllSalesWithFilter();
        }
    }
}
