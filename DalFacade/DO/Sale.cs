
namespace DO;

public record Sale
    (
     int SaleId,
     int ProdId = 0,
     int QuentityForSale = 0,
     double TotalPriceSale = 0,
     bool IsAllCustomer = false,
     DateTime? StartDate = null,
     DateTime? EndDate = null
     
    )
{

    public Sale() : this(0)
    {

    }
}
