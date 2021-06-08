using System;
using System.IO;
using System.Text;

namespace SalariesDll {

    public class IO {

        public static object LoadText(string filePath) {
            string[] properties;
            Salarie ret;
            FileStream fsSource = new(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader srSource = new(fsSource, Encoding.UTF8);
            properties = srSource.ReadLine().Split(";");
            ret = new Salarie(DateTime.Parse(properties[0]), properties[1], properties[2], properties[3],
                UInt32.Parse(properties[4]), Single.Parse(properties[6]));
            if (properties.Length == 9) {
                ret = new Commercial(ret, Int32.Parse(properties[7]), Int32.Parse(properties[8]));
            }
            srSource.Close();
            fsSource.Close();
            return ret;
        }

        public static void SaveText(object sal, string filePath) {
            StringToFile(sal.ToString(), filePath);
        }

        public static void StringToFile(string str, string filePath) {
            FileStream fsTarget = new(filePath, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swTarget = new(fsTarget, Encoding.UTF8);

            swTarget.WriteLine(str);
            swTarget.Close();
            fsTarget.Close();
        }

        public static void FileToConsole(string filePath) {
            string nextLine;
            FileStream fsSource = new(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader srSource = new(fsSource, Encoding.UTF8);

            do {
                nextLine = srSource.ReadLine();
                Console.WriteLine(nextLine);
            } while (nextLine != null);
            srSource.Close();
            fsSource.Close();
        }
    }
}