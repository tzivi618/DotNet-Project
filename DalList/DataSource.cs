using DO;
namespace Dal
{
    internal static class DataSource
    {
        internal static List<Customer? > Customers = new List<Customer?>();
        internal static List<Product?> Products = new List<Product?>();
        internal static List<Sale?> Sales = new List<Sale?>();
        internal static class Config
        {
          
            internal const int InitialValueProducts = 1;
            private static int RunningFieldProducts = InitialValueProducts;
            public static int codeProduct
            {
                get { return RunningFieldProducts++; }
            }

            internal const int InitialValueSales = 1;
            private static int RunningFieldSales = InitialValueSales;
            public static int codeSale
            {
                get { return RunningFieldSales++; }
            }


        }
    }
}
