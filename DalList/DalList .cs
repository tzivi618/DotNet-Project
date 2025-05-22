using DalApi;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        public static readonly DalList instance = new DalList();
        public static DalList Instance { get { return instance; } }
        private DalList() { }
        public IProduct Product => new ProductImplementation();
        
        public ICustomer Customer => new CustomerImplementation();

        public ISale Sale =>  new SaleImplementation();
    }
}
