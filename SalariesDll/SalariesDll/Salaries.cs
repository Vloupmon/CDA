using System.Collections.Generic;

namespace SalariesDll {

    public class SalariesHash : HashSet<Salarie> {

        public new void Add(Salarie sal) {
            foreach (Salarie sal_item in this) {
                if (sal.GetHashCode() == sal_item.GetHashCode()) {
                    return;
                }
            }
            base.Add(sal);
        }
    }

    public class Salaries : List<Salarie> {

        public new void Add(Salarie sal) {
            foreach (Salarie sal_item in this) {
                if (sal_item.Equals(sal)) {
                    return;
                }
            }
            base.Add(sal);
        }

        public Salarie Extract(string matricule) {
            return this.Find(sal => sal.Matricule == matricule);
        }

        public bool Remove(string matricule) {
            return base.Remove(Extract(matricule));
        }
    }
}