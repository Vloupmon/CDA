﻿#nullable disable

namespace CommerceAPI_NetCore.Models {

    public partial class CustomerCustomerRoleMapping {

        public int CustomerId {
            get; set;
        }

        public int CustomerRoleId {
            get; set;
        }

        public virtual Customer Customer {
            get; set;
        }

        public virtual CustomerRole CustomerRole {
            get; set;
        }
    }
}