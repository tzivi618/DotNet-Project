using System.Reflection;
using DalApi;
using DO;
using Tools;

namespace Dal;
internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType?.FullName, MethodBase.GetCurrentMethod().Name, $"begin create {item.ToString()}");
        Sale s = item with { SaleId = DataSource.Config.codeSale };
        var product = DataSource.Products.FirstOrDefault(p => p.ProdId == item.ProdId);
        if (product == null)
        {
            throw new Exception($"המוצר עם ProdId {item.ProdId} לא קיים.");
        }
        DataSource.Sales.Add(s);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end create {item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
        return s.SaleId;
    }



    public Sale? Read(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Sale{id.ToString()}");
        try
        {
            Sale saleFound = DataSource.Sales.Single(s => s.SaleId == id);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Sale{id.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
            return saleFound;
        }
        catch
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This sale is not in the customer list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
            throw new DalNotFoundIdException("This sale is not in the customer list");
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Sale,filter:{filter.ToString()}");

        try
        {
            Sale saleFound = DataSource.Sales.First(filter);
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Sale,filter:{filter.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
            return saleFound;
        }

        catch
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This sale is not in the customer list-----------------");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
            throw new DalNotFoundIdException("This sale is not in the customer list");
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
            return new List<Sale>(DataSource.Sales);
        return DataSource.Sales.Where(filter).ToList();
    }
    public void Update(Sale item)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin update Sale:{item.ToString()}");
        Delete(item.SaleId);
        DataSource.Sales.Add(item);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end update Sale{item.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
    }
    public void Delete(int id)
    {
        LogManager.spaceTabs += "\t";
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin delete Sale:{id.ToString()}");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end delete Sale{id.ToString()}");
        LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
    }

  
}

