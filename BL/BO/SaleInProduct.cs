

namespace BO
{
    public class SaleInProduct
    {
       public int Id { get; set; }
       public int CountForSale { get; set; }
       public double Price { get; set; }
       public bool ToAllCustomers { get; set; }

      public SaleInProduct(int id,int couountForSale,double price,bool toAllCustomers) 
        {
            Id=id;
            CountForSale=couountForSale;
            Price = price;
            ToAllCustomers = toAllCustomers;
        }
        public override string ToString() => this.ToStringProperty();




    }
}
