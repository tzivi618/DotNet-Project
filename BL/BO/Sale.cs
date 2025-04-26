

namespace BO
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProdId { get; set; }
        public int QuentityForSale { get; set; }
        public double TotalPriceSale { get; set; }
        public bool IsAllCustomer { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Sale(int saleId, int prodId, int quentityForSale, double totalPriceSale, bool isAllCustomer, DateTime? startDa, DateTime? endDate)
        {
            SaleId = saleId;
            ProdId = prodId;
            StartDate = startDa;
            QuentityForSale = quentityForSale;
            TotalPriceSale = totalPriceSale;
            IsAllCustomer = isAllCustomer;
            EndDate = endDate;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
