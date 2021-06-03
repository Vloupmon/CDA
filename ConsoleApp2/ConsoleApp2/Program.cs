using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        public static byte[] CombSort(byte[] array, double shrinkFactor)
        {
            int i, gap;
            bool flag;
            byte tmp;

            gap = array.Length - 1;
            flag = false;
            while (flag == false)
            {
                if (gap <= 1)
                {
                    gap = 1;
                    flag = true;
                }
                for (i = 0; i + gap < array.Length; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        tmp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = tmp;
                    }
                }
                gap = Convert.ToInt32(Math.Floor(gap / shrinkFactor));
            }
            return (array);
        }

        public static byte[] CountingSort(byte[] array)
        {
            int i, j;
            bool flag;
            byte[] weight;
            byte[] sorted;
            byte tmp;

            weight = new byte[array.Length];
            sorted = new byte[array.Length];
            Array.Clear(weight, 0, array.Length);
            for (i = 0; i < array.Length; i++)
            {
                for (j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        weight[i]++;
                    }
                }
            }
            for (i = 0, j = 0, flag = false; i < array.Length; i++)
            {
                if (i > 0)
                {
                    for (j = i - 1; j > 0; j--)
                    {
                       if (array[i] == array[j])
                        {
                            weight[i] += 2;
                            flag = true;
                        } 
                    }
                }
                if (flag == false)
                {
                    weight[i]++;
                }
            }
            for (i = 0; i < array.Length; i++)
            {
                sorted[weight[i] - 1] = array[i];
            }
            return (sorted);
        }

        public static byte[] SwapSort(byte[] array)
        {
            int i, j;
            byte tmp;

            for (i = 0, j = 0; i < array.Length; i = j + 1)
            {
                for (j = i; i != 0 && array[i - 1] > array[i]; i--)
                {
                    tmp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = tmp;
                }
            }
            return (array);
        }

        public static byte[] SelectionSort(byte[] array)
        {
            int i, j, min;
            byte tmp;

            min = 0;
            tmp = 0;
            for (i = 0; i < array.Length; i++)
            {
                for (j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        min = j;
                    }
                }
                array[min] = tmp;
            }
            return (array);
        }

        public static byte[] BubbleSort(byte[] array)
        {
            int i;
            bool flag;
            byte tmp;

            flag = false;
            while (flag == false)
            {
                tmp = 0;
                for (i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
                if (tmp == 0)
                {
                    flag = true;
                }
            }
            return (array);
        }

        public static byte[] RandomArrayGenerator(int seed, int arraySize)
        {
            byte[] array;
            Random rnd;

            array = new byte[arraySize];
            rnd = new Random(seed);

            rnd.NextBytes(array);

            return (array);
        }

        static int Main(string[] args)
        {
            string inputList;
            int randomSeed;
            int arraySize;
            byte[] array;
            char input;
            Stopwatch chrono;

            inputList = "12345TS";
            randomSeed = 1337;
            arraySize = 100;
            array = RandomArrayGenerator(randomSeed, arraySize);
            chrono = new Stopwatch();
            do
            {
                Console.WriteLine("Tapez 1 pour effectuer le tri à bulles\n" +
                               "Tapez 2 pour effectuer le tri par sélection\n" +
                               "Tapez 3 pour effectuer le tri par permutation\n" +
                               "Tapez 4 pour effectuer le tri par comptage\n" +
                               "Tapez 5 pour effectuer le tri peigne\n" +
                               "Tapez T pour effectuer tous les tris disponibles\n" +
                               "Tapez S pour sortir du programme\n");


                input = Console.ReadLine()[0];
                if (input == '1')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié :\n{0}\n", string.Join(", ", BubbleSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié :\n{0}\n", string.Join(", ", SelectionSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }
                if (input == '3')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié :\n{0}\n", string.Join(", ", SwapSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }
                if (input == '4')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié :\n{0}\n", string.Join(", ", CountingSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }
                if (input == '5')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié :\n{0}\n", string.Join(", ", CombSort(array, 1.3)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }
                 if (input == 'T')
                {
                    Console.WriteLine("\nTableau non trié :\n{0}\n", string.Join(", ", array));
                    chrono.Start();
                    Console.WriteLine("Tableau trié par tri bulles :\n{0}\n", string.Join(", ", BubbleSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                    chrono.Reset();
                    chrono.Start();
                    Console.WriteLine("Tableau trié par tri a selection :\n{0}\n", string.Join(", ", SelectionSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                    chrono.Reset();
                    chrono.Start();
                    Console.WriteLine("Tableau trié par tri a permutation :\n{0}\n", string.Join(", ", SwapSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                    chrono.Reset();
                    chrono.Start();
                    Console.WriteLine("Tableau trié par tri a comptage :\n{0}\n", string.Join(", ", CountingSort(array)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                    chrono.Reset();
                    chrono.Start();
                    Console.WriteLine("Tableau trié par tri a peigne :\n{0}\n", string.Join(", ", CombSort(array, 1.3)));
                    chrono.Stop();
                    Console.WriteLine("Temps passé à trier : {0}ms\n", chrono.Elapsed.TotalMilliseconds);
                }      
                if (input == 'S')
                {
                    return (0);
                }
                if (!inputList.Contains(input))
                {
                    Console.WriteLine("\nSélection invalide\n");
                }
                chrono.Reset();
            } while (true);
        }
    }
}
