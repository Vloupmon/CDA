using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace DictionnaireDLL
{
    /// <summary>
    /// 
    /// </summary>
    public class MotDictionnaire
    {
        string _mot = string.Empty;
        string _definition = string.Empty;

        public string Definition
        {
            get => _definition;
            set => _definition = value;
        }
        /// <summary>
        /// Le mot du dictionnaire
        /// </summary>
        public string Mot
        {
            get => _mot;
            set => _mot = value;
        }

    }
    /// <summary>
    /// Comparateur pour méthode de tri des mots
    /// </summary>
    public class MotDictionnaireComparateur : IComparer<MotDictionnaire>
    {

        #region IComparer<MotDictionnaire> Membres

        public int Compare(MotDictionnaire x, MotDictionnaire y)
        {
            return string.Compare(x.Mot, y.Mot);
        }

        #endregion


    }
    public class Dictionnaire
    {
        private string __cultureName = string.Empty;
        private readonly StringComparer _comparateurChaine = StringComparer.OrdinalIgnoreCase;

        private readonly SortedList<string, MotDictionnaire> _listeMots;

        public string CultureName
        {
            get => __cultureName;
            set => __cultureName = value;
        }

        public bool AjouterMot(MotDictionnaire mot)
        {
            if (!_listeMots.ContainsKey(mot.Mot))
            {
                _listeMots.Add(mot.Mot, mot);
                return true;
            }

            return false;
        }
        #region Constructeurs

        /// <summary>
        /// Création d'un nouveau dictionnaire vide
        /// </summary>
        public Dictionnaire()
        {
            this._listeMots = new SortedList<string, MotDictionnaire>(_comparateurChaine);
        }
        /// <summary>
        /// Création d'un dictionnaire à partir d'un fichier XML
        /// </summary>
        /// <param name="path"></param>
        public Dictionnaire(string path)
        {
            this._listeMots = new SortedList<string, MotDictionnaire>(_comparateurChaine);
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(path);
                XmlNode nodeRoot = document.DocumentElement;
                XmlNodeList nodeListRoot = nodeRoot.ChildNodes;

                this.CultureName = document.GetElementsByTagName("CultureName").Item(0).Value;

                XmlNode ListeMotsNode = document.GetElementsByTagName("ListeMots").Item(0);

                foreach (XmlNode item in ListeMotsNode.ChildNodes)
                {
                    MotDictionnaire motDictionnaire = new MotDictionnaire
                    {
                        Mot = item.Attributes["Mot"].Value,
                        Definition = item.Attributes["Definition"].Value
                    };
                    this._listeMots.Add(motDictionnaire.Mot, motDictionnaire);

                }

                // Pour indiquer au GC que la ressource est libérée
                document = null;


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Extraction des mots
      
              
        /// <summary>
        /// Extrait un mot aléatoirement
        /// </summary>
        /// <returns>Mot du dictionnaire</returns>
        public MotDictionnaire ExtraireMot()
        {
            return _listeMots.Values[new Random((int)DateTime.Now.Ticks).Next(0, _listeMots.Count - 1)];
        }
        /// <summary>
        /// Extrait une liste de mots aléatoirement
        /// </summary>
        /// <param name="nombreMots">Le nombre de mots à extraire</param>
        /// <returns>La liste de mots extrait du dictionnaire</returns>
        public List<MotDictionnaire> ExtraireMots(int nombreMots)
        {
            if (nombreMots >= this._listeMots.Count) return this._listeMots.Values.ToList();

            Random alea = new Random((int)DateTime.Now.Ticks);
            List<MotDictionnaire> listeMots = new List<MotDictionnaire>();
            for (int i = 0; i < nombreMots; i++)
            {
                listeMots.Add(_listeMots.Values[alea.Next(0, _listeMots.Count - 1)]);
            }
            return listeMots;
        }

        #endregion
        #region Gestion de la persistance
        public void Save(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);
                XmlNode DictionnaireNode = doc.CreateElement("Dictionnaire");
                doc.AppendChild(DictionnaireNode);
                //  Paramètres de la langue
                XmlNode cultureNode = doc.CreateElement("CultureName");
                cultureNode.AppendChild(doc.CreateTextNode(this.CultureName));
                DictionnaireNode.AppendChild(cultureNode);
                XmlNode ListeMotsNode = doc.CreateElement("ListeMots");
                DictionnaireNode.AppendChild(ListeMotsNode);

                foreach (System.Collections.Generic.KeyValuePair<string, MotDictionnaire> cleValeur in this._listeMots)
                {
                    XmlNode motDictionnaire;
                    XmlAttribute mot;
                    XmlAttribute definition;
                    motDictionnaire = doc.CreateElement("MotDictionnaire");
                    ListeMotsNode.AppendChild(motDictionnaire);
                    mot = doc.CreateAttribute("Mot");
                    mot.Value = cleValeur.Key;
                    definition = doc.CreateAttribute("Definition");
                    definition.Value = cleValeur.Value.Definition;
                    motDictionnaire.Attributes.Append(mot);
                    motDictionnaire.Attributes.Append(definition);
                    ListeMotsNode.AppendChild(motDictionnaire);
                }
                doc.Save(path);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        #endregion

    }
}
