using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque;

namespace BanqueConsoleTests {

    internal class Program {

        private static void Main(string[] args) {
            CreerComptes();
            TesterHollerith();
            Modulo();
        }

        private static void TesterHollerith() {
            Console.WriteLine("Test fonction de transcodage Hollerith");
            int equivalent;
            Hollerith.Transcoder('Z', out equivalent);
            Console.WriteLine($"caractere : Z valeur : {equivalent}");

            Console.ReadLine();
        }

        private static void CreerComptes() {
            Comptes comptes = new Comptes();
            Compte compte = new Compte {
                CodeClient = "23456754",
                CodeBanque = "20041",
                CodeGuichet = "01006",
                Numero = "0068875R027",
                CleRIB = "70",
                LibelleCompte = "Mickaël Barrer Banque Postale"
            };
            comptes.Add(compte);
            compte = new Compte {
                CodeClient = "23456754",
                CodeBanque = "10907",
                CodeGuichet = "00237",
                Numero = "44219104266",
                CleRIB = "03",
                LibelleCompte = "Bost Banque Populaire courant"
            };
            comptes.Add(compte);
            compte = new Compte {
                CodeClient = "23456754",
                CodeBanque = "10907",
                CodeGuichet = "00237",
                Numero = "64286104261",
                CleRIB = "20",
                LibelleCompte = "Bost CASDEN"
            };
            comptes.Add(compte);
            compte = new Compte {
                CodeClient = "23456754",
                CodeBanque = "30003",
                CodeGuichet = "00530",
                Numero = "00050662254",
                CleRIB = "66",
                LibelleCompte = "Vrai RIB"
            };
            comptes.Add(compte);
            comptes.Save(Properties.Settings.Default.BanqueAppData);

            comptes = new Comptes();
            comptes.Load(Properties.Settings.Default.BanqueAppData);
            Console.WriteLine($"{comptes.Count} comptes sont présents dans la collection");

            foreach (Compte item in comptes) {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Modulo() {
            Console.WriteLine($"Modulo 100 % 97 : {100 % 97}");
            Console.Read();
        }
    }
}