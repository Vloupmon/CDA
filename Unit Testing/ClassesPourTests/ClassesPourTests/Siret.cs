using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesATester
{
    public static class SIRET
    {
        public static bool VerifierSIRET(string siret)
        {
            if (string.IsNullOrEmpty(siret) || siret.Length!=14)
            {
                return false;
            }
                int calcul = 0;
                int chiffre = 0;
                for (int i = 0; i < siret.Length; i++)
                {
                    chiffre = int.Parse(siret[i].ToString()) * (2 - i % 2);
                    calcul += chiffre >= 10 ? chiffre - 9 : chiffre;
                }
                return (calcul % 10 == 0);         
        }
    }
}
