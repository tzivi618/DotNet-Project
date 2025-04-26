using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void createProduct()
    {
        s_dal.Product.Create(new Product(0, "תשע לפנות בוקר", Categories.מבוגר, 65, 100));
        s_dal.Product.Create(new Product(0, "אנוכי מבקש", Categories.מבוגר, 50, 10));
        s_dal.Product.Create(new Product(0, "המשגיח", Categories.ביוגרפיה, 80, 15));
        s_dal.Product.Create(new Product(0, "מסומן", Categories.מבוגר, 50, 12));
        s_dal.Product.Create(new Product(0, "נחוחות המאפה", Categories.מתכונים, 30, 0));
        s_dal.Product.Create(new Product(0, "דודי ואודי", Categories.קומיקס, 40, 30));
        s_dal.Product.Create(new Product(0, "חלונות אור", Categories.נוער, 40, 35));
    }

    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(1, "ציבי אינהורן", "נתיבות המשפט 78 מודיעין עילית", "0533187618"));
        s_dal.Customer.Create(new Customer(3, "תמי פל", "נתיבות המשפט 70 מודיעין עילית", "0534193385"));
        s_dal.Customer.Create(new Customer(5, "נחמי קרשינסקי", "הריטבא 6 מודיעין עילית", "0556734722"));
        s_dal.Customer.Create(new Customer(7, "נחמי שורץ", "הרב מפונוביז 9 מודיעין עילית", "0583212449"));
        s_dal.Customer.Create(new Customer(9, "טובי קופרמן", "שערי תשובה 12 מודיעין עילית", "0583230387"));
        s_dal.Customer.Create(new Customer(11, "רבקה גליס", "מסילת יוסף 21 מודיעין עילית", "0527161532"));
    }

    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(0, 4, 1, 20, false, DateTime.Now, new DateTime(2025, 5, 20)));
        s_dal.Sale.Create(new Sale(0, 5, 2, 20, true, DateTime.Now, new DateTime(2025, 5, 20)));
        s_dal.Sale.Create(new Sale(0, 3, 1, 20, true, DateTime.Now, new DateTime(2025, 5, 20)));
        s_dal.Sale.Create(new Sale(0, 6, 3, 40, true, DateTime.Now, new DateTime(2025, 5, 20)));
        s_dal.Sale.Create(new Sale(0, 1, 4, 30, true, DateTime.Now, new DateTime(2025,5,20)));
        s_dal.Sale.Create(new Sale(0, 1, 2, 20, true, DateTime.Now, new DateTime(2025,5,20)));
        s_dal.Sale.Create(new Sale(0, 1, 5, 50, true, DateTime.Now, new DateTime(2025,5,20)));
        s_dal.Sale.Create(new Sale(0, 1, 8, 40, true, DateTime.Now, new DateTime(2025,5,20)));
        s_dal.Sale.Create(new Sale(0, 1, 4, 30, true, DateTime.Now, new DateTime(2025,5,20)));
        s_dal.Sale.Create(new Sale(0, 2, 1, 30, true, DateTime.Now, DateTime.Now));
    }
    public static void intialize()
    { 
        s_dal = DalApi.Factory.Get;
      /* createCustomer();
       createProduct();*/
       createSale();
    }

}
