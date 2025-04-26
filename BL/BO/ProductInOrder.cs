

namespace BO
{
    public class ProductInOrder
    {

        public  int   ProdId { get; } 
        public string? ProdName { get; set; }    
        public double  BasePrice { get; set; } 
        public int CountInOrder  { get; set; }  
        public List<SaleInProduct> SalesList { get; set;}
        public double FinalPrice { get; set; }
        public ProductInOrder(int prodId, string prodName, double basePrice,int countInOrder,List<SaleInProduct> salesList,double finalPrice)
        {
            ProdId=prodId; 
            ProdName=prodName;
            BasePrice=basePrice;
            CountInOrder=countInOrder;
            SalesList=salesList;
            FinalPrice=finalPrice;
        }

        public override string ToString() => this.ToStringProperty();


    }
}
