using System;
using System.Collections.Generic;

namespace LinqToEntityCore_1.Models
{
    public partial class MouvementDeStock
    {
        public int IdMouvement { get; set; }
        public int ProductId { get; set; }
        public int QteMouvement { get; set; }
        public string TypeMouvement { get; set; }
        public string LibelleMouvement { get; set; }
        public DateTime DateMouvement { get; set; }

        public virtual Products Product { get; set; }
    }
}
