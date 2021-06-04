using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesDll {

    public class Salaries : List<Salarie> {

        public new void Add(Salarie sal) {
            foreach (Salarie i in this) {
                if (i.Equals(sal)) {
                    return;
                }
                base.Add(sal);
            }
        }

        public Salarie Extract(string matricule) {
            return this.Find(sal => sal.Matricule == matricule);
        }
    }
}