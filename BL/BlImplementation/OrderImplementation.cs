

using BlApi;
using BO;
using DO;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<SaleInProduct> AddProductToOrder(Order order, int prodId, int quantityToOrder)
        {
            try
            {
                DO.Product p = _dal.Product.Read(prodId);
                ProductInOrder prod = order.ProductsInOrderList.FirstOrDefault(p => p.ProdId == prodId);
                int newQuantity = quantityToOrder;
                if ((prod != null && quantityToOrder + prod.CountInOrder < 0) || (prod == null && quantityToOrder < 0))
                    throw new Exception("כמות המוצרים בהזמנה קטנה מכמות זו");
                if (prod != null) newQuantity += prod.CountInOrder;
                if (p.Quantity - newQuantity < 0)
                {
                    throw new BlNotInEnoughInStockException("חסר במלאי");
                }
                if (prod == null)
                {
                    prod = p.ConvertProductToProductInOrder();
                    prod.CountInOrder = quantityToOrder;
                    order.ProductsInOrderList.Add(prod);
                }
                else
                {
                    prod.CountInOrder = prod.CountInOrder + quantityToOrder;
                }
                SearchSaleForProduct(prod, order.IsSpecialCustomer);
                CalcTotalPriceForProduct(prod);
                CalcTotalPrice(order);
                return prod.SalesList;
            }

            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException("error in AddProductToOrder ", e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CalcTotalPrice(Order order)
        {
            order.TotalPrice = order.ProductsInOrderList.Sum(p => p.FinalPrice);
        }

        public void CalcTotalPriceForProduct(ProductInOrder prodInOrder)
        {

            try
            {
                List<SaleInProduct> tempSales = new List<SaleInProduct>();
                if (prodInOrder.SalesList.Count() == 0)
                    prodInOrder.FinalPrice = prodInOrder.BasePrice * prodInOrder.CountInOrder;
                else
                {
                    int count = prodInOrder.CountInOrder;
                    double sum = 0;
                    foreach (var sale in prodInOrder.SalesList)
                    {
                        if (count == 0)
                            break;
                        if (count >= sale.CountForSale)
                        {
                            sum += count / sale.CountForSale * sale.Price;
                            count -= sale.CountForSale * (count / sale.CountForSale);
                            tempSales.Add(sale);
                        }
                    }

                    sum += prodInOrder.BasePrice * count;
                    prodInOrder.FinalPrice = sum;
                    prodInOrder.SalesList = tempSales;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DoOrder(Order order)
        {
            try
            {
                foreach (ProductInOrder p in order.ProductsInOrderList)
                {
                    DO.Product p1 = _dal.Product.Read(p.ProdId);
                    p1 = p1.UpdateQuantityForProduct(p1.Quantity - p.CountInOrder);
                    _dal.Product.Update(p1);
                }
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException("error in DoOrder", e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SearchSaleForProduct(ProductInOrder product, bool isSpecial)
        {
            try
            {
                var linq = _dal.Sale.ReadAll(s => s.ProdId == product.ProdId && s.StartDate <= DateTime.Now && s.EndDate >= DateTime.Now && s.QuentityForSale <= product.CountInOrder);

                if (!isSpecial)
                {
                    linq = linq?.Where(s => !s.IsAllCustomer).ToList();
                }
                product.SalesList = linq?.OrderBy(s => s.TotalPriceSale / s.QuentityForSale)
                                         .Select(s => s.ConvertSaleToSaleInProduct())
                                         .ToList() ?? new List<SaleInProduct>();
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException("error in SearchSaleForProduct", e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
/*        public void SearchSaleForProduct(ProductInOrder product, bool isSpecial)
        {
            try
            {
                var linq = _dal.Sale.ReadAll(s => s.ProdId == product.ProdId && s.StartDate <= DateTime.Now && s.EndDate >= DateTime.Now && s.QuentityForSale <= product.CountInOrder);

                if (!isSpecial)
                {
                    linq = (linq ?? Enumerable.Empty<DO.Sale>()).Where(s => !s.IsAllCustomer);
                }

                product.SalesList = linq?.OrderBy(s => s.TotalPriceSale / s.QuentityForSale)
                                          .Select(s => s.ConvertSaleToSaleInProduct())
                                          .ToList() ?? new List<SaleInProduct>();
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException("error in SearchSaleForProduct", e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/



    }
}
