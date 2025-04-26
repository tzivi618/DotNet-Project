

namespace BO
{

    public class Customer
    {
        public int CustomerId { get; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerPhone { get; set; }

        public Customer(int customerId, string? CustomerName, string? CustomerAddress, string? CustomerPhone)
        {
            this.CustomerId = customerId;
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.CustomerPhone = CustomerPhone;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
