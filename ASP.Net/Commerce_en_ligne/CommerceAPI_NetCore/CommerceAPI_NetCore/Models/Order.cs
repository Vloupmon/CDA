using System;
using System.Collections.Generic;

#nullable disable

namespace CommerceAPI_NetCore.Models {

    public partial class Order {

        public Order() {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id {
            get; set;
        }

        public Guid OrderGuid {
            get; set;
        }

        public int CustomerId {
            get; set;
        }

        public int BillingAddressId {
            get; set;
        }

        public int? ShippingAddressId {
            get; set;
        }

        public decimal OrderTotal {
            get; set;
        }

        public bool Deleted {
            get; set;
        }

        public DateTime CreatedOnUtc {
            get; set;
        }

        public virtual Address BillingAddress {
            get; set;
        }

        public virtual Customer Customer {
            get; set;
        }

        public virtual Address ShippingAddress {
            get; set;
        }

        public virtual ICollection<OrderItem> OrderItems {
            get; set;
        }
    }
}