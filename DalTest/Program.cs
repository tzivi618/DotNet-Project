using DalApi;
using DalTest;
using DO;
namespace Dal;

internal class Program
{

    private static IDal s_dal = DalApi.Factory.Get;

    public static void Main(string[] args)

    {
        try
        {
            ManagerProgram();
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            throw error;
        }
    }
    private static void ManagerProgram()
    {

        Initialization.intialize();
        int Choice = PrintBigMenu();

        while (Choice != 0)
        {
            switch (Choice)
            {
                case 1:
                    Icrud<Customer> TypeRefernce1 = s_dal.Customer;
                    MinMenu(TypeRefernce1, Classes.Customer);
                    break;
                case 2:
                    Icrud<Product> TypeRefernce2 = s_dal.Product;
                    MinMenu(TypeRefernce2, Classes.Product);
                    break;
                case 3:
                    Icrud<Sale> TypeRefernce3 = s_dal.Sale;
                    MinMenu(TypeRefernce3, Classes.Sale);
                    break;
                default:
                    Console.WriteLine("error, try again");
                    break;
            }

            Choice = PrintBigMenu();
        }
    }

    private static int PrintBigMenu()
    {
        Console.WriteLine("Customer prees 1, " +
                          "Product prees 2, " +
                           "Sale press 3, " +
                           "exit 0");
        int Choice = 1;
        string s = Console.ReadLine();
        if (!int.TryParse(s, out Choice))
            Choice = -1;
        return Choice;
    }

    private static void MinMenu<T>(Icrud<T> icrud, Classes title)
    {
        int Choice = PrintMinMenu(title);

        while (Choice != 0)
        {
            switch (Choice)
            {
                case 1:
                    JointCreate(title);
                    break;
                case 2:
                    JointRead(icrud, title);
                    break;
                case 3:
                    List<T> L = icrud.ReadAll();
                    foreach (T item in L)
                        Console.WriteLine(item);
                    break;
                case 4:
                    switch (title)
                    {
                        case Classes.Customer:
                            UpdateCustomer();
                            break;
                        case Classes.Product:
                            UpdateProduct();
                            break;
                        case Classes.Sale:
                            UpdateSale();
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine($"entre id for {title} to delete");
                    int IdDelete;
                    int.TryParse(Console.ReadLine(), out IdDelete);
                    icrud.Delete(IdDelete);
                    break;
                default:
                    throw new DalWrongOptionException("error option");

            }

            Choice = PrintMinMenu(title);
        }
    }

    private static int PrintMinMenu(Classes title)
    {
        Console.WriteLine($"to add {title} press 1," +
            $" to read {title} press 2," +
            $"to readall {title} press 3, " +
            $"to update {title} press 4, " +
            $"to delete {title} press 5");
        int Choice = 1;
        string s = Console.ReadLine();
        if (!int.TryParse(s, out Choice))
            Choice = -1;
        return Choice;
    }

    private static void CreateCustomer()
    {

        s_dal.Customer.Create(NewCustomer());
    }
    private static void CreateProduct()
    {

        s_dal.Product.Create(NewProduct());
    }
    private static void CreateSale()
    {
        s_dal.Sale.Create(NewSale());
    }

    private static void UpdateCustomer()
    {
        s_dal.Customer.Update(NewCustomer());
    }
    private static void UpdateProduct()
    {
        Console.WriteLine("Enter product update ID");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        s_dal.Product.Update(NewProduct(id));
    }

    private static void UpdateSale()
    {
        Console.WriteLine("Enter sale update ID");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        s_dal.Sale.Update(NewSale(id));
    }


    private static Customer NewCustomer()
    {
        Console.WriteLine("id,name,address,phone");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phone = Console.ReadLine();
        return new Customer(id, name, address, phone);
    }
    private static Product NewProduct(int id = 0)
    {
        Console.WriteLine("name,category,price,quantity");
        string name = Console.ReadLine();
        Categories category;
        Categories.TryParse(Console.ReadLine(), out category);
        int price;
        int.TryParse(Console.ReadLine(), out price);
        int quantity;
        int.TryParse(Console.ReadLine(), out quantity);
        return new Product(id, name, category, price, quantity);
    }
    private static Sale NewSale(int id = 0)
    {
        Console.WriteLine("ProdId,QuentityForSale,TotalPriceSale,IsAllCustomer,StartDate,EndDate");
        int ProdId;
        int.TryParse(Console.ReadLine(), out ProdId);
        int QuentityForSale;
        int.TryParse(Console.ReadLine(), out QuentityForSale);
        double TotalPriceSale;
        double.TryParse(Console.ReadLine(), out TotalPriceSale);
        bool IsAllCustomer;
        bool.TryParse(Console.ReadLine(), out IsAllCustomer);
        DateTime StartDate;
        DateTime.TryParse(Console.ReadLine(), out StartDate);
        DateTime EndDate;
        DateTime.TryParse(Console.ReadLine(), out EndDate);
        return new Sale(id, ProdId, QuentityForSale, TotalPriceSale, IsAllCustomer, StartDate, EndDate);
    }

    private static void JointCreate(Classes title)
    {
        switch (title)
        {
            case Classes.Customer:
                CreateCustomer();
                break;
            case Classes.Product:
                CreateProduct();
                break;
            case Classes.Sale:
                CreateSale();
                break;
        }
    }

    private static void JointRead<T>(Icrud<T> icrud, Classes title)
    {
        Console.WriteLine($"entre id for {title}");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Console.WriteLine(icrud.Read(id));
    }


}






