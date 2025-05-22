using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;
namespace Dal;

internal class ProductImplementation : IProduct
{

    static string xmlFilePath = @"..\xml\products.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    static List<Product> products=new List<Product>();
    public int Create(Product item)
    {
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            serializer.Serialize(fileStream, products);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin create {item.ToString()}");
        item = item with { ProdId = Config.nextProductId };
        products.Add(item);
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
        {
            serializer.Serialize(fileStream, products);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end create {item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return item.ProdId;
    }


    public Product? Read(int id)
    {
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            products = (List<Product>)serializer.Deserialize(fileStream);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Product{id.ToString()}");
        try
        {
            Product productFound = products.Single(p => p.ProdId == id);
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
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            products = (List<Product>)serializer.Deserialize(fileStream);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Product,filter:{filter}");
        try
        {
            Product productFound = products.First(filter);
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
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            products = (List<Product>)serializer.Deserialize(fileStream);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin ReadAll Products,filter:{filter}");
        if (filter == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll Products,filter:{filter}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return new List<Product>(products);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll Products,filter:{filter}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
        return products.Where(filter).ToList();
    }

    public void Update(Product item)
    {
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            products = (List<Product>)serializer.Deserialize(fileStream);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Update Sale:{item.ToString()}");
        Delete(item.ProdId);
        products.Add(item);
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
        {
            serializer.Serialize(fileStream, products);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Update Sale{item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }
    public void Delete(int id)
    {
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            products = (List<Product>)serializer.Deserialize(fileStream);
        }
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Delete Sale:{id.ToString()}");
        Product p = Read(id);
        products.Remove(p);
        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
        {
            serializer.Serialize(fileStream, products);
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Delete Sale{id.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
    }


}
