using SalariesDll;
using System;
using System.Threading;

namespace SalarieTest {

    internal class Program {

        private static Salaries Menu(Salaries list, string path) {
            Salarie sal = new();

            list.DeserializeXML(path);

            Console.WriteLine("Nouveau salarié\n");
            for (int i = 1; i != 6;) {
                if (i == 1) {
                    try {
                        Console.WriteLine("Date de naissance :");
                        sal.DateNaissance = DateTime.Parse(Console.ReadLine());
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 2) {
                    try {
                        Console.WriteLine("Matricule :");
                        sal.Matricule = Console.ReadLine();
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 3) {
                    try {
                        Console.WriteLine("Nom :");
                        sal.Nom = Console.ReadLine();
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 4) {
                    try {
                        Console.WriteLine("Prénom :");
                        sal.Prenom = Console.ReadLine();
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 5) {
                    try {
                        Console.WriteLine("Salaire brut :");
                        sal.SalaireBrut = UInt32.Parse(Console.ReadLine());
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
                if (i == 6) {
                    try {
                        Console.WriteLine("Taux de cotisations sociales :");
                        sal.TauxCs = Single.Parse(Console.ReadLine());
                        i++;
                    } catch (FormatException e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            list.Add(sal);
            try {
                path = System.IO.Path.GetFullPath(path);
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            } finally {
                list.SerializeXML(path);
            }
            return (list);
        }

        private static void NewSalCalc(object sender, SalaryEventArgs e) {
            Console.WriteLine("Ancien salaire : {0}\n", e.FormerSalary);
            Console.WriteLine("Nouveau salaire : {0}\n", e.CurrentSalary);
            Console.WriteLine("Différence : {0}%\n", (((int)e.CurrentSalary - (int)e.FormerSalary) / (int)e.FormerSalary) * 100);
        }

        private static void Main(string[] args) {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
            //string path = (string)Path.GetDirectoryName(Assembly.GetAssembly(typeof(Salaries)).Location);

            Salaries list = new();
            Salarie sal = new();
            Salarie sal2 = new();

            sal.Matricule = "11eee22";

            sal2.Matricule = "22qqq33";

            try {
                list.Add(sal);
                list.Add(sal2);
                list.Add(sal2);
            } catch (ApplicationException e) {
                Console.WriteLine(e.Message, e.StackTrace);
            }
        }
    }
}