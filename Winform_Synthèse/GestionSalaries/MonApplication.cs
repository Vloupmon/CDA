using SalariesDll;
using Utilitaires;

namespace GestionSalaraies {

    internal static class MonApplication {
        private static Utilisateur _utilisateurConnecte;
        private static ISauvegarde _dispositifSauvegarde = new SauvegardeXML();

        public static ISauvegarde DispositifSauvegarde {
            get {
                return MonApplication._dispositifSauvegarde;
            }
        }

        static public Utilisateur UtilisateurConnecte {
            get {
                return _utilisateurConnecte;
            }
            set {
                _utilisateurConnecte = value;
            }
        }
    }
}