using BO;
namespace BlApi
{
    public interface ICustomer
    {
        int Create(Customer item);
        Customer? Read(int id); 
        List<Customer?> ReadAll(Func<Customer, bool>? filter = null);
        void Update(Customer item);
        void Delete(int id); 
        Customer? Read(Func<Customer, bool> filter);
        bool IfCustomerExist(int customerId);
    }
}
