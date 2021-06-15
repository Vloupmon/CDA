using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Persistance;

namespace PersistanceJSON
{
    public class SauvegardeJSON : ISauvegarde
    {
        public IEnumerable<T> Load<T>(string pathRepData) where T:class
        {
            object objet = null;
            string pathDocument = string.Format(@$"{pathRepData}\{typeof(T).Name}.json");
            if (File.Exists(pathDocument))
            {
                using FileStream fs = new(@$"{pathRepData}\{typeof(T).Name}.json",
                    FileMode.Open, FileAccess.Read, FileShare.Read);
                using StreamReader sr = new(fs);
                objet = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()) ;
            }
            return objet as IEnumerable<T>;
        }

        public void Save<T>(string pathRepData, IEnumerable<T> objetASauvegarder) where T : class
        {
            string fluxJson = JsonConvert.SerializeObject(objetASauvegarder, typeof(List<T>), new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.None });
            using FileStream fs = new FileStream(@$"{pathRepData}\{typeof(T).Name}.json",
                  FileMode.Create, FileAccess.Write, FileShare.Read);
            using StreamWriter txtWriter = new(fs);
            txtWriter.Write(fluxJson);
        }
    }
}
