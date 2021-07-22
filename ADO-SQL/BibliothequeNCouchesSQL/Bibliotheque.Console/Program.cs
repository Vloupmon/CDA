using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.BOL;
using Bibliotheque.DAL;

namespace Bibliotheque.ConsoleWindows {

    internal class Program {

        private static void Main(string[] args) {
            // Initialiser Paramètres DB Connexion
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            TesterAdherent();
        }

        private static void TesterAdherent() {
            // Liste
            foreach (Adherent item in AdherentDAO.Instance.GetAll()) {
                Console.WriteLine($"ID : {item.AdherentID} Prénom : {item.Prenom} Nom : {item.Nom}");
            }

            // Extraction 1 Adherent

            Adherent adherent = AdherentDAO.Instance.GetByID("A9087");
            Console.WriteLine($"ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");

            // Modification 1 Adherent

            try {
                adherent.Prenom = "Anatole";
                AdherentDAO.Instance.Update(adherent);
                Console.WriteLine($"Modifié ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            } catch (Exception ex) {
                Console.WriteLine($"Erreur {ex.Message}");
            }

            // demande de Modification d'un adhérent inexistant
            adherent.AdherentID = "9999";
            adherent.Prenom = "Anatole";

            try {
                Console.WriteLine("Demande de modif avec clé erronée");
                AdherentDAO.Instance.Update(adherent);
                Console.WriteLine($"Modifié ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            } catch (Exception ex) {
                Console.WriteLine($"Erreur {ex.Message}");
            }

            adherent = new Adherent() {
                AdherentID = "A201954",
                Nom = "Restoueix",
                Prenom = "Sacha"
            };
            try {
                AdherentDAO.Instance.Create(adherent);
                Console.WriteLine($"Adhérent ajouté: {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            } catch (Exception ex) {
                Console.WriteLine($"Erreur ajout {ex.Message}");
            }

            Console.Read();
        }
    }
}