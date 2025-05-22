using DO;
using DalApi;
using System.Linq;
using Tools;
using System.Reflection;
namespace Dal;
internal class CustomerImplementation : ICustomer
{

    public int Create(Customer item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Create {item.ToString()}");
        bool customerFound = DataSource.Customers.Any(c => c.CustomerId == item.CustomerId);

        if (customerFound)
        {

            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This ID is already in the customer list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            throw new DalExistIdException("This ID is already in the customer list");
        }
        DataSource.Customers.Add(item);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Create {item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return item.CustomerId;
    }

    public void Delete(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Delete customer {id.ToString()}");
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Delete customer {id.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }


    public Customer? Read(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read customer{id.ToString()}");
        try
        {
            Customer customerFound = DataSource.Customers.Single(c => c.CustomerId == id);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read customer {id.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return customerFound;
        }
        catch
        {
            
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This customer is not in the customer list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            throw new DalNotFoundIdException("This customer is not in the customer list");
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read customer, filter: {filter.ToString()}");
        try
        {
            Customer customerFound = DataSource.Customers.First(filter);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read customer, filter: {filter.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return customerFound;
        }
        catch
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This customer is not in the customer list-----------------");
            throw new DalNotFoundIdException("This customer is not in the customer list");
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin ReadAll customer, filter: {filter}");
        if (filter == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll customer");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return new List<Customer>(DataSource.Customers);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll customer, filter: {filter}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return DataSource.Customers.Where(filter).ToList();
    }

    public void Update(Customer item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Update customer: {item.ToString()}");
        Delete(item.CustomerId);
        DataSource.Customers.Add(item);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Update customer: {item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }
}
