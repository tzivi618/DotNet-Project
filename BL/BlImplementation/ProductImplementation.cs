using BlApi;
using BO;
using DO;
using static BO.Tools;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            int productId = 0;
            try
            {
                DO.Product product = item.ConvertProductToDo();
                productId = _dal.Product.Create(product);
            }
            catch (DalExistIdException e)
            {
                throw new BO.BlExistIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productId;
        }

        public void Delete(int id)
        {

            try
            {
                _dal.Product.Delete(id);
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BO.SaleInProduct> inExpiry(int prodId, bool isSpecial)
        {
            var linq = _dal.Sale.ReadAll(s => s.ProdId == prodId && s.StartDate <= DateTime.Now && s.EndDate >= DateTime.Now);

            if (!isSpecial)
                linq?.Where(s => s.IsAllCustomer);
           return  linq?.OrderBy(s => s.TotalPriceSale / s.QuentityForSale).Select(s => s.ConvertSaleToSaleInProduct()).ToList();

        }

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product product = _dal.Product.Read(id);
                return product?.ConvertProductToBo();
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try

            {
                return _dal.Product.Read(doProduct => filter(doProduct.ConvertProductToBo()))?.ConvertProductToBo();
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(p => p.ConvertProductToBo()).ToList();
                return _dal.Product.ReadAll(doProduct => filter(doProduct.ConvertProductToBo())).Select(p => p.ConvertProductToBo()).ToList();
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ConvertProductToDo());
            }
            catch (DalNotFoundIdException e)
            {
                throw new BO.BlNotFoundIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
