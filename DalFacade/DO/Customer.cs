namespace DO;

public record Customer
(
   int CustomerId,
   string? CustomerName = null,
   string? CustomerAddress = null,
   string? CustomerPhone = null
)
{
    public Customer() : this(0)
    {
    }
}