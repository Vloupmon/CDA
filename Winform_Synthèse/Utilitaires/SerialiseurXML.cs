using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Utilitaires {

    public class SauvegardeXML : ISauvegarde {

        /// <summary>
        /// Sauvegarder par sérialisation Xml
        /// </summary>
        /// <param name="pathRepData"></param>
        /// <param name="objetASauvegarder"></param>
        public void Save(string pathRepData, IEnumerable objetASauvegarder) {
            Type type = objetASauvegarder.GetType();

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, type.FullName);
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Create, FileAccess.Write, FileShare.Read)) {
                XmlTextWriter xmlTW = new XmlTextWriter(fileStream, Encoding.UTF8);
                xmlTW.Formatting = Formatting.Indented;
                xmlTW.Indentation = 4;
                XmlSerializer xmlS = new XmlSerializer(type);
                xmlS.Serialize(xmlTW, objetASauvegarder);
                xmlTW.Close();
                fileStream.Close();
            }
        }

        /// <summary>
        /// Extraire les données par désérialisation XML
        /// </summary>
        /// <param name="pathRepData"></param>
        /// <param name="typeACharger"></param>
        /// <returns></returns>
        public IEnumerable Load(string pathRepData, Type typeACharger) {
            Object objet = null;

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, typeACharger.FullName);
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read)) {
                XmlTextReader xmlTR = new XmlTextReader(fileStream);
                XmlSerializer xmlS = new XmlSerializer(typeACharger);

                objet = xmlS.Deserialize(xmlTR);
                xmlTR.Close();
                fileStream.Close();
            }
            return objet as IEnumerable;
        }
    }

    internal sealed class BinderType : SerializationBinder {

        public override Type BindToType(string assemblyName, string typeName) {
            Type typeToDeserialize = null;
            typeToDeserialize = Type.GetType(assemblyName);

            return typeToDeserialize;
        }
    }
}