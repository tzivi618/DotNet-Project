using DO;
using DalApi;
using Tools;
using System.Reflection;
using System.Xml.Linq;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        private const string CUSTOMER = "Customer";
        private const string CUSTOMERID = "CustomerId";
        private const string CUSTOMERNAME = "CustomerName";
        private const string CUSTOMERADDRESS = "CustomerAddress";
        private const string CUSTOMERPHONE = "CustomerPhone";
        static string xmlFilePath = @"..\xml\customers.xml";

        public int Create(Customer item)
        {
            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                LogManager.spaceTabs += "\t";
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Create {item.ToString()}");

                bool customerFound = xml.Elements(CUSTOMER).Any(c => c.Element(CUSTOMERID)?.Value == item.CustomerId.ToString());

                if (customerFound)
                {
                    LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This ID is already in the customer list-----------------");
                    throw new DalExistIdException("This ID is already in the customer list");
                }

                xml.Add(new XElement(CUSTOMER,
                    new XElement(CUSTOMERID, item.CustomerId),
                    new XElement(CUSTOMERNAME, item.CustomerName),
                    new XElement(CUSTOMERADDRESS, item.CustomerAddress),
                    new XElement(CUSTOMERPHONE, item.CustomerPhone)));

                xml.Save(xmlFilePath);
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Create {item.ToString()}");
                return item.CustomerId;
            }
            catch (DalExistIdException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to read customers from XML", ex);
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }

        public void Delete(int id)
        {
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Delete customer {id.ToString()}");
            Customer c = Read(id);
            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                xml.Elements(CUSTOMER).FirstOrDefault(c => (int)c.Element(CUSTOMERID) == id)?.Remove();
                xml.Save(xmlFilePath); 
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Delete customer {id.ToString()}");
            }
            catch
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: xml dont work-----------------");
                throw new DalNotFoundIdException("fail in xml connect the customer xml");
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }

        public Customer? Read(int id)
        {
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Read customer {id.ToString()}");
            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                XElement customerFound = xml.Elements(CUSTOMER)
                   .FirstOrDefault(c => (int)c.Element(CUSTOMERID) == id);
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Read customer {id.ToString()}");
                return new Customer((int)customerFound.Element(CUSTOMERID), (string)customerFound.Element(CUSTOMERNAME), (string)customerFound.Element(CUSTOMERADDRESS), (string)customerFound.Element(CUSTOMERPHONE));
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "-----------------error: This customer is not in the customer list-----------------");
                throw new DalNotFoundIdException("This customer is not in the customer xml");
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin ReadAll customer, filter: {filter}");

            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                List<Customer> listFoundCustomers = xml.Elements(CUSTOMER).Select(customerFound =>
                    new Customer(
                        (int)customerFound.Element(CUSTOMERID),
                        (string)customerFound.Element(CUSTOMERNAME),
                        (string)customerFound.Element(CUSTOMERADDRESS),
                        (string)customerFound.Element(CUSTOMERPHONE)
                    )).ToList();

                Customer foundCustomer = listFoundCustomers.FirstOrDefault(customer => filter(customer));

                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll customer, found: {listFoundCustomers.Count}");
                return foundCustomer;
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"error to load/ write xml file");
                throw new Exception("Unable to read customers from XML", ex);
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin ReadAll customer, filter: {filter}");

            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                List<Customer> listFoundCustomers = xml.Elements(CUSTOMER).Select(customerFound =>
                    new Customer(
                        (int)customerFound.Element(CUSTOMERID),
                        (string)customerFound.Element(CUSTOMERNAME),
                        (string)customerFound.Element(CUSTOMERADDRESS),
                        (string)customerFound.Element(CUSTOMERPHONE)
                    )).ToList();

                if (filter != null)
                {
                    listFoundCustomers = listFoundCustomers.Where(customer => filter(customer)).ToList();
                }

                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end ReadAll customer, found: {listFoundCustomers.Count}");
                return listFoundCustomers;
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"error to load/ write xml file");
                throw new Exception("Unable to read customers from XML", ex);
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }

        public void Update(Customer item)
        {
            LogManager.spaceTabs += "\t";
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"begin Update customer: {item.ToString()}");
            Delete(item.CustomerId);
            try
            {
                XElement xml = XElement.Load(xmlFilePath);
                xml.Add(new XElement(CUSTOMER,
                    new XElement(CUSTOMERID, item.CustomerId),
                    new XElement(CUSTOMERNAME, item.CustomerName),
                    new XElement(CUSTOMERADDRESS, item.CustomerAddress),
                    new XElement(CUSTOMERPHONE, item.CustomerPhone)));
                xml.Save(xmlFilePath); 
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"end Update customer: {item.ToString()}");
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"error to load xml file: {item.ToString()}");
                throw ex;
            }
            finally
            {
                LogManager.spaceTabs = LogManager.spaceTabs.Substring(0, LogManager.spaceTabs.Length - 1);
            }
        }
    }
}
