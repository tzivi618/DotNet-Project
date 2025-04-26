
using BO;
namespace BlApi
{
    public  interface IProduct
    {
        int Create(Product item); //Creates new entity object in DAL
        Product? Read(int id); //Reads entity object by its ID 
        List<Product?> ReadAll(Func<Product, bool>? filter = null); //stage 1 only, Reads all entity objects
        void Update(Product item); //Updates entity object
        void Delete(int id); //Deletes an object by its Id
        Product? Read(Func<Product, bool> filter);
        List<SaleInProduct> inExpiry(int prodId, bool isSpecial);
    }
}
