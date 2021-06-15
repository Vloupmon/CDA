using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.BOL;
using Persistance;
using PersistanceXML;

namespace Bibliotheque.UI.Winforms
{
    static class Program
    {
             
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if ((Global.Sauvegarde.Load<Adherent>(Global.Repertoire)) == null)
            {
                InitializeData();

            }
           
            Application.Run(new FrmAdherent());
        }
        private static void InitializeData()
        {
            HashSet<Adherent> Adherents;
            Adherents = new HashSet<Adherent>()
            {
                new Adherent(){
                   AdherentID = "96GB011",
                   Nom="Bost",
                   Prenom = "Vincent"
                },
                 new Adherent(){
                   AdherentID = "00GT015",
                   Nom="Pouligane",
                   Prenom = "Arnaud"
                },
                new Adherent()
                {
                   AdherentID = "98AC015",
                   Nom="Morillon",
                   Prenom = "Jean"
                }
            };
            Global.Sauvegarde.Save<Adherent>(Global.Repertoire, Adherents);
        }
    }
}
