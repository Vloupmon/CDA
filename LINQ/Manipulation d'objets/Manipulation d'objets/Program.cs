using System;
using System.Linq;
using Extensions;

namespace Manipulation_d_objets {

    internal class Program {
        private Func<string, string, int> ConcatSum = (x, y) => x.Length + y.Length;

        private static void Main(string[] args) {
            Console.WriteLine("Hello World!".WordCount());
        }
    }
}