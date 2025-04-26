

using BlApi;
using DO;
using static BO.Tools;

namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            int saleId = 0;
            try
            {
                _dal.Product.Read(item.ProdId);
                DO.Sale sale = item.ConvertSaleToDo();
                saleId = _dal.Sale.Create(sale);
            }
            catch (DalExistIdException e)
            {
                throw new BO.BlExistIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saleId;
        }

        public void Delete(int id)
        {

            try
            {
                _dal.Sale.Delete(id);
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


        public BO.Sale? Read(int id)
        {
            try
            {
                DO.Sale sale = _dal.Sale.Read(id);
                return sale?.ConvertSaleToBo();
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

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
               return _dal.Sale.Read(doSale => filter(doSale.ConvertSaleToBo()))?.ConvertSaleToBo();
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

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.ConvertSaleToBo()).ToList();
                return _dal.Sale.ReadAll(doSale=> filter(doSale.ConvertSaleToBo())).Select(s => s.ConvertSaleToBo()).ToList();
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

        public void Update(BO.Sale item)
        {
            try
            {
                _dal.Sale.Update(item.ConvertSaleToDo());
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
