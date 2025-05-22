using BO;
namespace BlApi
{
    public  interface IProduct
    {
        int Create(Product item);
        Product? Read(int id); 
        List<Product?> ReadAll(Func<Product, bool>? filter = null); 
        void Update(Product item); 
        void Delete(int id); 
        Product? Read(Func<Product, bool> filter);
        List<SaleInProduct> inExpiry(int prodId, bool isSpecial);
    }
}
