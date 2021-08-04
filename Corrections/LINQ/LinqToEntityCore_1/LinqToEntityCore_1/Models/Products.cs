﻿using System;
using System.Collections.Generic;

namespace LinqToEntityCore_1.Models
{
    public partial class Products
    {
        public Products()
        {
            MouvementDeStock = new HashSet<MouvementDeStock>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int UnitsReserved { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<MouvementDeStock> MouvementDeStock { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
