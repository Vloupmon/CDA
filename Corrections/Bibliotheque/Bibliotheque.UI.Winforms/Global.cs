using Persistance;
using PersistanceXML;
using PersistanceJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.UI.Winforms
{
    /// <summary>
    /// Expose des mécanismes globaux 
    /// </summary>
    static class Global
    {
        public static readonly ISauvegarde Sauvegarde =  new SauvegardeXML();
        public static readonly string Repertoire = Properties.Settings.Default.PathSauvegarde;
    }
}
