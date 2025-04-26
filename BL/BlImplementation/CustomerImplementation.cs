

using BlApi;
using BO;
using DO;
using static BO.Tools;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            int customerId = 0;
            try
            {
                DO.Customer customer = item.ConvertCustomerToDO();
                customerId = _dal.Customer.Create(customer);
            }
            catch (DalExistIdException e)
            {
                throw new BO.BlExistIdException(e.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customerId;
        }

        public void Delete(int id)
        {

            try
            {
                _dal.Customer.Delete(id);
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
        public bool IfCustomerExist(int customerId)
        {
            BO.Customer customer = _dal.Customer.ReadAll().FirstOrDefault(c => c.CustomerId == customerId).ConvertCustomerToBO();
            return customer != null;
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                DO.Customer customer = _dal.Customer.Read(id);
                return customer?.ConvertCustomerToBO();
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

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(doCustomer => filter(doCustomer.ConvertCustomerToBO()))?.ConvertCustomerToBO();
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

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {if (filter == null)
                    return _dal.Customer.ReadAll().Select(s => s.ConvertCustomerToBO()).ToList();
                return _dal.Customer.ReadAll(doCustomer => filter(doCustomer.ConvertCustomerToBO())).Select(s => s.ConvertCustomerToBO()).ToList();
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
       


        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.ConvertCustomerToDO());
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


