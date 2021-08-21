using Extensions;
using System;
using System.Collections.Generic;

namespace Manipulation_d_objets {

    internal class Program {

        private static void Main(string[] args) {
            Func<string, string, int> ConcatSum = (x, y) => x.Length + y.Length;

            Console.WriteLine("Wordcount of \"Hello World!\" : " + "Hello World!".WordCount());
            Console.WriteLine("\nConcatSum of \"Hello\" + \"World!\" : " + ConcatSum("Hello", "World!").ToString());
            Console.WriteLine("\nMedian of \"1, 2, 3, 4, 5, 6, 7, 8, 9\" : " + 
                new double[] {1, 2, 3 ,4 ,5 ,6 ,7 ,8 ,9 }.Median().ToString());
            Console.WriteLine("\nMedian of \"1, 2, 3, 4, 5, 6, 7, 8, 9, 10\" : " + 
                new double[] {1, 2, 3 ,4 ,5 ,6 ,7 ,8 ,9, 10 }.Median().ToString());
            Console.WriteLine("\nMedian of \"1\" : " + 
                new double[] {1}.Median().ToString());
            Console.WriteLine("\nMedian of \"\" : ");
            try {
                Console.WriteLine(Array.Empty<double>().Median().ToString());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}