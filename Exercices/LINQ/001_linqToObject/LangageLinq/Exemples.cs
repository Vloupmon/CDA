using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LangageLinq
{
    public static class Exemples
    {
        public static void PartitionTri()
        {
            
            int[] entiers = new int[] { 1, 3, 8, 9, 12, 256, -25, -30 };
            int a = 2;
            int b = a.Carre();
           
            entiers.OrderBy(e => e).
                TakeWhile(e => e < 5).
                ToList().ForEach(e => Console.Write($"{e};"));

            Console.WriteLine();
            entiers.TakeWhile(e => e < 5).
               OrderBy(e => e).
               ToList().ForEach(e => Console.Write($"{e};"));

        }

       
    }
}
