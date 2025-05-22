using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        static string xmlFilePath = @"..\xml\sales.xml";
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        static List<Sale> sales=new List<Sale>();
        public int Create(Sale item)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin create {item.ToString()}");
            item = item with { SaleId = Config.nextSaleId };
            sales.Add(item);
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end create {item.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            return item.SaleId;
        }



        public Sale? Read(int id)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                sales = (List<Sale>)serializer.Deserialize(fileStream);
            }
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Sale{id.ToString()}");
            try
            {
                Sale saleFound = sales.Single(s => s.SaleId == id);
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Sale{id.ToString()}");
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
                return saleFound;
            }
            catch
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This sale is not in the customer list-----------------");
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
                throw new DalNotFoundIdException("This sale is not in the sale list");
            }
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                sales = (List<Sale>)serializer.Deserialize(fileStream);
            }

            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read Sale,filter:{filter.ToString()}");

            try
            {
                Sale saleFound = sales.First(filter);
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read Sale,filter:{filter.ToString()}");
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
                return saleFound;
            }

            catch
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This sale is not in the customer list-----------------");
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
                throw new DalNotFoundIdException("This sale is not in the sale list");
            }
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                sales = (List<Sale>)serializer.Deserialize(fileStream);
            }
            if (filter == null)
                return new List<Sale>(sales);
            return sales.Where(filter).ToList();
        }
        public void Update(Sale item)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                sales = (List<Sale>)serializer.Deserialize(fileStream);
            }
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin update Sale:{item.ToString()}");
            Delete(item.SaleId);
            sales.Add(item);
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end update Sale{item.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);

        }
        public void Delete(int id)
        {
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                sales = (List<Sale>)serializer.Deserialize(fileStream);
            }
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin delete Sale:{id.ToString()}");
            Sale s = Read(id);
            sales.Remove(s);
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end delete Sale{id.ToString()}");
            LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, 1);
        }
    }
}
