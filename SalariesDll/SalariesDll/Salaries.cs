using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using SalariesDll.Properties;

namespace SalariesDll {

    public class SalariesHash : HashSet<Salarie> {

        public new void Add(Salarie sal) {
            foreach (Salarie sal_item in this) {
                if (sal.GetHashCode() == sal_item.GetHashCode()) {
                    throw new SalarieException(Messages.Salarie_001,
                        String.Format(CultureInfo.GetCultureInfo("en"), Messages.Salarie_001, sal.Matricule));
                }
            }
            base.Add(sal);
        }
    }

    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class Salaries : List<Salarie> {

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

        public bool Remove(string matricule) {
            return base.Remove(Extract(matricule));
        }

        public void DeserializeXML(string path) {
            FileStream fileStream;
            XmlTextReader xmlTR;
            XmlSerializer xmlS;

            fileStream = new(string.Format(CultureInfo.InvariantCulture, @"{0}\Salaries.xml", path),
                FileMode.Open, FileAccess.Read, FileShare.Read);
            xmlTR = new(fileStream);
            xmlS = new(this.GetType());
            base.AddRange(xmlS.Deserialize(xmlTR) as Salaries);
            fileStream.Close();
            xmlTR.Close();
            xmlTR.Dispose();
        }

        public void SerializeXML(string path) {
            FileStream fileStream;
            XmlTextWriter xmlTW;
            XmlSerializer xmlS;

            fileStream = new(string.Format(CultureInfo.InvariantCulture, @"{0}\Salaries.xml", path),
                FileMode.Create, FileAccess.Write, FileShare.None);
            xmlTW = new(fileStream, Encoding.UTF8);
            xmlTW.Formatting = Formatting.Indented;
            xmlS = new(this.GetType());
            xmlS.Serialize(xmlTW, this);
            xmlTW.Close();
            xmlTW.Dispose();
            fileStream.Close();
        }
    }
}