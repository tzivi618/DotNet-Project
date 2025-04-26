

using System.Collections;
using System.Reflection;
using System.Text;

namespace BO
{
    internal static class Tools
    {
        public static string toStringProperty<T>(this T obj, string prefix = "")
        {
            
            StringBuilder sb = new StringBuilder();
            Type t = obj?.GetType() ??
                throw new Exception("Obj is NULL");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                if (prop.PropertyType.IsPrimitive || prop.PropertyType == typeof(string) || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                else { 
                    Console.WriteLine(sb);
                sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).toStringProperty(prefix + "\t")}");}
            }
            return sb.ToString();
        }
        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type Ttype = t.GetType();
            PropertyInfo[] info = Ttype.GetProperties();
            foreach (PropertyInfo item in info)
            {
                if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
                {
                    IEnumerable collection = item.GetValue(t) as IEnumerable;
                    foreach (var x in collection)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                    str += string.Format("name: {0,-15} value: {1,-15}\n", item.Name, item.GetValue(t, null));

            }
            return str;
        }


        public static DO.Sale ConvertSaleToDo(this BO.Sale saleBO)
        {
            DO.Sale saleDO = new DO.Sale()
            {
                SaleId = saleBO.SaleId,
                ProdId = saleBO.ProdId,
                QuentityForSale = saleBO.QuentityForSale,
                TotalPriceSale = saleBO.TotalPriceSale,
                IsAllCustomer = saleBO.IsAllCustomer,
                StartDate = saleBO.StartDate,
                EndDate = saleBO.EndDate
            };
            return saleDO;
        }

        public static BO.Sale ConvertSaleToBo(this DO.Sale saleDO)
        {
            BO.Sale saleBO = new BO.Sale(saleDO.SaleId, saleDO.ProdId, saleDO.QuentityForSale, saleDO.TotalPriceSale, saleDO.IsAllCustomer, saleDO.StartDate, saleDO.EndDate);
            return saleBO;
        }

        public static DO.Product ConvertProductToDo(this BO.Product ProductBO)
        {
            DO.Product ProductDO = new DO.Product()
            {
                ProdId = ProductBO.ProdId,
                ProdName = ProductBO.ProdName,
                ProdCategory = (DO.Categories?)ProductBO.ProdCategory,
                Price = ProductBO.Price,
                Quantity = ProductBO.Quantity,
            };
            return ProductDO;
        }

        public static BO.Product ConvertProductToBo(this DO.Product ProductDO)
        {

            BO.Product ProductBO = new BO.Product(ProductDO.ProdId, ProductDO.ProdName, (BO.Categories?)ProductDO.ProdCategory, ProductDO.Price, ProductDO.Quantity);
            return ProductBO;
        }
        public static DO.Customer ConvertCustomerToDO(this BO.Customer customerBO)
        {
            DO.Customer customerDO = new DO.Customer()
            {
                CustomerId = customerBO.CustomerId,
                CustomerName = customerBO.CustomerName,
                CustomerAddress = customerBO.CustomerAddress,
                CustomerPhone = customerBO.CustomerPhone,
            };
            return customerDO;
        }
        public static BO.Customer ConvertCustomerToBO(this DO.Customer customerDO)
        {
            BO.Customer customerBO = new BO.Customer(customerDO.CustomerId, customerDO.CustomerName, customerDO.CustomerAddress, customerDO.CustomerPhone);
            return customerBO;
        }

        public static BO.SaleInProduct ConvertSaleToSaleInProduct(this DO.Sale saleDO)
        {
            BO.SaleInProduct saleInProduct = new BO.SaleInProduct(saleDO.SaleId, saleDO.QuentityForSale, saleDO.TotalPriceSale, saleDO.IsAllCustomer);
            return saleInProduct;
        }
        public static BO.ProductInOrder ConvertProductToProductInOrder(this DO.Product productDO)
        {
            return new BO.ProductInOrder(productDO.ProdId, productDO.ProdName, productDO.Price, productDO.Quantity, new List<SaleInProduct>(), productDO.Quantity * productDO.Price);
        }
        public static DO.Product ConvertProductInOrderToProduct(this BO.ProductInOrder productInOrder)
        {
            return new DO.Product(productInOrder.ProdId, productInOrder.ProdName, DO.Categories.מבוגר, productInOrder.BasePrice, productInOrder.CountInOrder);
        }
        public static DO.Product UpdateQuantityForProduct(this DO.Product product, int quantity)
        {
          return  new DO.Product(product.ProdId,product.ProdName,product.ProdCategory, product.Price,quantity);
        }
    }
}
