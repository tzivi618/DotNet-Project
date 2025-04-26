using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class Order
    {
        public bool IsSpecialCustomer { get; set; }
        public List<ProductInOrder> ProductsInOrderList { get; set; }
        public double TotalPrice { get; set; }
        public Order(bool isSpecialCustomer) {
            IsSpecialCustomer = isSpecialCustomer;
            ProductsInOrderList = new List<ProductInOrder>();
            TotalPrice = 0;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
