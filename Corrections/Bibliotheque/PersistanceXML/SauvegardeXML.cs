using Persistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PersistanceXML
{
    public class SauvegardeXML : ISauvegarde
    {
        public IEnumerable<T> Load<T>(string pathRepData) where T : class
        {
            object objet = null;
            string pathXmlDocument = string.Format(@$"{pathRepData}\{typeof(T).Name}.Xml");
            if (File.Exists(pathXmlDocument))
            {
                using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlTextReader xmlTR = new XmlTextReader(fileStream);
                    XmlSerializer xmlS = new XmlSerializer(typeof(List<T>));
                    objet = xmlS.Deserialize(xmlTR);
                    xmlTR.Close();
                    fileStream.Close();
                }
            }
            return objet as IEnumerable<T>;
        }
        /// <summary>
        /// Sauvegarde XML de Liste d'objets
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pathRepData"></param>
        /// <param name="objetASauvegarder"></param>
        public void Save<T>(string pathRepData, IEnumerable<T> objetASauvegarder) where T : class
        {
            string pathXmlDocument = string.Format(@$"{pathRepData}\{typeof(T).Name}.Xml");
            using FileStream fileStream = new(pathXmlDocument, FileMode.Create, FileAccess.Write, FileShare.Read);
            using XmlTextWriter xmlTW = new(fileStream, Encoding.UTF8);
            XmlSerializer xmlS = new(objetASauvegarder.GetType());
            xmlS.Serialize(xmlTW, objetASauvegarder);
            xmlTW.Close();
            fileStream.Close();
        }
    }
}
