
namespace DO;

public record Product(
   int ProdId,
   string? ProdName = null,
   Categories? ProdCategory = null,
   double Price = 0,
   int Quantity = 0)
{


    public Product()
        : this(-1)
    {

    }



}
