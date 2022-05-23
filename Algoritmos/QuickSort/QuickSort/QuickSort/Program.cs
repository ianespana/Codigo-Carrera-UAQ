using System;
using System.Collections.Generic;

namespace QuickSort
{
    internal class Program
    {
        public static int iters = 0;
        public static int comps = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero base a potenciar:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la potencia máxima a probar:");
            int maxPow = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxPow; i++)
            {
                int maxValue = (int)Math.Pow(baseNum, i);
                List<int> numArray = RandomList(maxValue, 0, maxValue);

                Console.WriteLine("Prueba " + i + ". Numero de elementos: " + maxValue);

                if (i <= 2)
                {
                    PrintTable(numArray);
                }

                Console.WriteLine();

                Console.WriteLine("------- Quicksort -------");
                DateTime start = DateTime.Now;
                List<int> sortedQs = QuickSort(numArray);
                DateTime end = DateTime.Now;

                if (i <= 2)
                {
                    PrintTable(sortedQs);
                }

                Console.WriteLine("Iteraciones: " + iters);
                Console.WriteLine("Comparaciones: " + comps);
                Console.WriteLine("Tiempo de procesamiento: " + (end - start).TotalMilliseconds + "(ms)");
                Console.WriteLine();
                iters = 0;
                comps = 0;

                Console.WriteLine("------- Burbuja -------");
                List<int> sortedBs = numArray;
                start = DateTime.Now;
                BubbleSort(sortedBs);
                end = DateTime.Now;

                if (i <= 2)
                {
                    PrintTable(sortedBs);
                }

                Console.WriteLine("Iteraciones: " + iters);
                Console.WriteLine("Comparaciones: " + comps);
                Console.WriteLine("Tiempo de procesamiento: " + (end - start).TotalMilliseconds + "(ms)");
                Console.WriteLine();
            }
        }

        static List<int> RandomList(int size = 4, int minValue = 0, int maxValue = 10)
        {
            List<int> list = new();
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(minValue, maxValue));
            }
            return list;
        }

        static void PrintTable(List<int> array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Count; i++)
            {
                if (i == array.Count - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }

        static List<int> QuickSort(List<int> numArray)
        {
            comps++;
            if (numArray.Count == 1)
            {
                return new List<int> { numArray[0] };
            }
            else if (numArray.Count == 2)
            {
                comps++;
                if (numArray[0] <= numArray[1])
                {
                    return new List<int>() { numArray[0], numArray[1] };
                }
                else
                {
                    return new List<int>() { numArray[1], numArray[0] };
                }
            }
            else if (numArray.Count > 2)
            {
                int pivotIndex = (int)Math.Floor(numArray.Count / 2.0);
                int pivot = numArray[pivotIndex];
                List<int> leftArray = new();
                List<int> rightArray = new();

                for (int i = 0; i < numArray.Count; i++)
                {
                    iters++;

                    comps++;
                    if (i == pivotIndex) continue;

                    comps++;
                    if (numArray[i] <= pivot)
                    {
                        leftArray.Add(numArray[i]);
                    }
                    else
                    {
                        rightArray.Add(numArray[i]);
                    }
                }

                List<int> sortedArray = new();
                sortedArray.AddRange(QuickSort(leftArray));
                sortedArray.Add(pivot);
                sortedArray.AddRange(QuickSort(rightArray));
                return sortedArray;
            }
            else
            {
                return new List<int>();
            }
        }

        static void BubbleSort(List<int> numArray)
        {
            for (int j = 0; j < numArray.Count; j++)
            {
                iters++;
                for (int i = 0; i < numArray.Count - 1 - j; i++)
                {
                    iters++;
                    comps++;
                    if (numArray[i] > numArray[i + 1])
                    {
                        int aux = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = aux;
                    }
                }
            }
        }
    }
}