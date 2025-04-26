using DalApi;
using DO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Tools;
namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin create {item.ToString()}");
        Product p = item with { ProdId = DataSource.Config.codeProduct };
        DataSource.Products.Add(p);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end create {item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return p.ProdId;
    }


    public Product? Read(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Product{id.ToString()}");
        try
        {
            Product productFound = DataSource.Products.Single(p => p.ProdId == id);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Sale{id.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return productFound;
        }
        catch
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This product is not in the prducts list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            throw new DalNotFoundIdException("This product is not in the product list");
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Product,filter:{filter}");
        try
        {
            Product productFound = DataSource.Products.First(filter);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Product,filter:{filter}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return productFound;
        }
        catch
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This product is not in the products list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            throw new DalNotFoundIdException("This product is not in the product list");
        }
    }


    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin ReadAll Products,filter:{filter}");
        if (filter == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll Products,filter:{filter}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return new List<Product>(DataSource.Products);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll Products,filter:{filter}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return DataSource.Products.Where(filter).ToList();
    }

    public void Update(Product item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Update Sale:{item.ToString()}");
        Delete(item.ProdId);
        DataSource.Products.Add(item);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Update Sale{item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }
    public void Delete(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Delete Sale:{id.ToString()}");
        Product s = Read(id);
        DataSource.Products.Remove(s);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Delete Sale{id.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }

  
}
