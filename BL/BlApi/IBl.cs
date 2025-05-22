namespace BlApi
{
    public interface IBl
    {
        IProduct Product { get; }
        ICustomer Customer { get; }
        ISale Sale { get; }
        IOrder Order { get; } 
    }
}
