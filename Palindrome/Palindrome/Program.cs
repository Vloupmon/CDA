using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static bool palindromeCheck(string input)
        {
            Console.WriteLine(input + "\n");
            int i, j;

            for (i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (!Char.IsLetter(input[i]))
                {
                    i++;
                }
                if (!Char.IsLetter(input[j]))
                {
                    j--;
                }
                if (input[i] != input[j])
                {
                    return (false);
                }
            }
            return (true);
        }
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Entrez un plaindrome");
            input = Console.ReadLine().ToLower().Normalize(NormalizationForm.FormD);
            if (palindromeCheck(input))
            {
                Console.WriteLine("Ceci est un palindrome !");
            }
            else
            {
                Console.WriteLine("Ceci n'est pas un palindrome !");
            }
        }
    }
}
