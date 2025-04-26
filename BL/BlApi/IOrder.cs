using BO;
namespace BlApi
{
    public  interface IOrder
    {
      List<SaleInProduct> AddProductToOrder(Order order,int prodId,int quantityToOrder);
      void CalcTotalPriceForProduct(ProductInOrder prodInOrder);

      void CalcTotalPrice(Order order);

      void DoOrder(Order order);
      void SearchSaleForProduct(ProductInOrder product, bool isSpecial);

    }
}
