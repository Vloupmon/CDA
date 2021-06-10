using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SalariesDll {

    public class IOXml : ISerializeEntities {

        public void Save(IEnumerable item, string path) {
            FileStream fileStream;
            XmlTextWriter xmlTW;
            XmlSerializer xmlS;

            using (fileStream = new(string.Format(CultureInfo.InvariantCulture, @"{0}\Salaries.xml", path),
                FileMode.Create, FileAccess.Write, FileShare.None)) {
                xmlTW = new(fileStream, Encoding.UTF8);
                xmlTW.Formatting = Formatting.Indented;
                xmlS = new(item.GetType());
                xmlS.Serialize(xmlTW, item);
                xmlTW.Close();
                fileStream.Close();
            }
        }

        public IEnumerable Load(Type item, string path) {
            FileStream fileStream;
            XmlTextReader xmlTR;
            XmlSerializer xmlS;

            using (fileStream = new(string.Format(CultureInfo.InvariantCulture, @"{0}\Salaries.xml", path),
                FileMode.Open, FileAccess.Read, FileShare.Read)) {
                xmlTR = new(fileStream);
                xmlS = new(item.GetType());
                item.AddRange(xmlS.Deserialize(xmlTR) as Salaries);
                fileStream.Close();
                xmlTR.Close();
            }
            return item;
        }
    }

    public class IOMethods {

        public static object LoadText(string filePath) {
            string[] properties;
            Salarie ret;
            FileStream fsSource = new(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader srSource = new(fsSource, Encoding.UTF8);
            properties = srSource.ReadLine().Split(";");
            ret = new Salarie(DateTime.Parse(properties[0]), properties[1], properties[2], properties[3],
                UInt32.Parse(properties[4]), Single.Parse(properties[6]));
            if (properties.Length == 9) {
                ret = new Commercial(ret, Int32.Parse(properties[7]), Int32.Parse(properties[8]));
            }
            srSource.Close();
            fsSource.Close();
            return ret;
        }

        public static void SaveText(object sal, string filePath) {
            StringToFile(sal.ToString(), filePath);
        }

        public static void StringToFile(string str, string filePath) {
            FileStream fsTarget = new(filePath, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swTarget = new(fsTarget, Encoding.UTF8);

            swTarget.WriteLine(str);
            swTarget.Close();
            fsTarget.Close();
        }

        public static void FileToConsole(string filePath) {
            string nextLine;
            FileStream fsSource = new(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader srSource = new(fsSource, Encoding.UTF8);

            do {
                nextLine = srSource.ReadLine();
                Console.WriteLine(nextLine);
            } while (nextLine != null);
            srSource.Close();
            fsSource.Close();
        }
    }
}