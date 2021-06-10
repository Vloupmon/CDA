using SalariesDll.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SalariesDll {

    public class SalariesHash : HashSet<Salarie> {

        public new void Add(Salarie sal) {
            foreach (Salarie sal_item in this) {
                if (sal.GetHashCode() == sal_item.GetHashCode()) {
                    throw new SalarieException(Messages.Salarie_001,
                        String.Format(CultureInfo.CurrentCulture, Messages.Salarie_001, sal.Matricule));
                }
            }
            base.Add(sal);
        }
    }

    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class Salaries : List<Salarie>, ISerializeEntities {

        public new void Add(Salarie sal) {
            foreach (Salarie sal_item in this) {
                if (sal_item == sal) {
                    throw new SalarieException(Messages.Salarie_001,
                        String.Format(CultureInfo.GetCultureInfo("en"), Messages.Salarie_001, sal.Matricule));
                }
            }
            base.Add(sal);
        }

        public Salarie Extract(string matricule) {
            return this.Find(sal => sal.Matricule == matricule);
        }

        public IEnumerable Load(ISerializeEntities load, string path) {
            this.AddRange(load.Load(this, path));
        }

        public bool Remove(string matricule) {
            return base.Remove(Extract(matricule));
        }

        public void Save(ISerializeEntities save, string path) {
            save.Save(this, path);
        }
    }
}