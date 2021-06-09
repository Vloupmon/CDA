using SalariesDll;
using System;

namespace SalarieTest {

    internal class Program {

        private static void Menu(string path) {
            Salarie sal = new();
            Salaries list = new();

            list.DeserializeXML(path);

            Console.WriteLine("Nouveau salarié\n");
            for (int i = 1; i != 6;) {
                if (i == 1) {
                    try {
                        Console.WriteLine("Date de naissance :");
                        sal.DateNaissance = DateTime.Parse(Console.ReadLine());
                        i++;
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 2) {
                    try {
                        Console.WriteLine("Matricule :");
                        sal.Matricule = Console.ReadLine();
                        i++;
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 3) {
                    try {
                        Console.WriteLine("Nom :");
                        sal.Nom = Console.ReadLine();
                        i++;
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 4) {
                    try {
                        Console.WriteLine("Prénom :");
                        sal.Prenom = Console.ReadLine();
                        i++;
                    }
                    catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 5) {
                    try {
                        Console.WriteLine("Salaire brut :");
                        sal.SalaireBrut = UInt32.Parse(Console.ReadLine());
                        i++;
                    }
                    catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 6) {
                    try {
                        Console.WriteLine("Taux de cotisations sociales :");
                        sal.TauxCs = Single.Parse(Console.ReadLine());
                        i++;
                    }
                    catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            list.Add(sal);
            list.SerializeXML(path);
        }

        private static void NewSalCalc(object sender, SalaryEventArgs e) {
            Console.WriteLine("Ancien salaire : {0}\n", e.FormerSalary);
            Console.WriteLine("Nouveau salaire : {0}\n", e.CurrentSalary);
            Console.WriteLine("Différence : {0}%\n", e.RaisePercentage);
        }

        private static void Main(string[] args) {
            //string path = (string)Path.GetDirectoryName(Assembly.GetAssembly(typeof(Salaries)).Lecation);
            Salarie sal = new();
            sal.ChangeSalary += NewSalCalc;
            sal.SalaireBrut = 1222;
            sal.SalaireBrut = 2000;
        }
    }
}