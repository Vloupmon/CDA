﻿using System.Collections.Generic;

#nullable disable

namespace CommerceAPI_NetCore.Models {

    public partial class Country {

        public Country() {
            Addresses = new HashSet<Address>();
            StateProvinces = new HashSet<StateProvince>();
        }

        public int Id {
            get; set;
        }

        public string Name {
            get; set;
        }

        public bool AllowsBilling {
            get; set;
        }

        public bool AllowsShipping {
            get; set;
        }

        public string TwoLetterIsoCode {
            get; set;
        }

        public string ThreeLetterIsoCode {
            get; set;
        }

        public int NumericIsoCode {
            get; set;
        }

        public bool SubjectToVat {
            get; set;
        }

        public bool Published {
            get; set;
        }

        public int DisplayOrder {
            get; set;
        }

        public bool LimitedToStores {
            get; set;
        }

        public virtual ICollection<Address> Addresses {
            get; set;
        }

        public virtual ICollection<StateProvince> StateProvinces {
            get; set;
        }
    }
}