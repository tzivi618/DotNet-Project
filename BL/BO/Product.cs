

namespace BO
{
    public class Product
    {
        public int ProdId { get; }
        public string? ProdName { get; set; }
        public Categories? ProdCategory { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public List<SaleInProduct>? Sales { get; set; }
        public Product(int ProdId, string? ProdName, Categories? ProdCategory, double Price, int Quantity) 
        {
            this.ProdId = ProdId;
            this.ProdName = ProdName;
            this.ProdCategory = ProdCategory;
            this.Price= Price;
            this.Quantity = Quantity;
            this.Sales = new List<SaleInProduct>();
        }
        public override string ToString() => this.ToStringProperty();
    }
}
