using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PersistanceIService;

namespace PersistanceServiceJSON
{
    public class SauvegardeJSON : ISauvegarde
    {
        public IEnumerable<T> Load<T>(string pathRepData) where T:class
        {
            object objet = null;
            string pathDocument = string.Format(@"{0}\{1}.json", pathRepData, typeof(T).Name);
            if (File.Exists(pathDocument))
            {
                using (FileStream fs = new FileStream(pathDocument,
                    FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                        objet = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
                }
        }
            return objet as IEnumerable<T>;
        }

        public void Save<T>(string pathRepData, IEnumerable<T> objetASauvegarder) where T : class
        {
            string fluxJson = JsonConvert.SerializeObject(objetASauvegarder, typeof(List<T>), new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.None });
            using (FileStream fs = new FileStream(string.Format(@"{0}\{1}.json", pathRepData, typeof(T).Name),
                  FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter txtWriter = new StreamWriter(fs))
                    txtWriter.Write(fluxJson);
            }
        }
    }
}
