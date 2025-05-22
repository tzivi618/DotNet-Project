using BlApi;
using BO;
namespace BlTest;

public class Test
{
    public static void Main(string[] args)
    {
        int customerId = 1;
      
        int cnt = 3;
        int prodId, quantity;
        Order o=new Order(true);
        //Initialization.intialize();

        IBl _Ibl = BlApi.Factory.Get;
        _Ibl.Customer.Create(new Customer(11, "jkjk", "uui", "45454545"));
        _Ibl.Customer.Create(new Customer(454, "jkjk", "uui", "45454545"));
    }
}