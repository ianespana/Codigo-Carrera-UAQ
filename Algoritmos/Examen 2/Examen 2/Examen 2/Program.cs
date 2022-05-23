using System;
using System.Linq;

namespace Examen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            /*Console.WriteLine("Ingresa el numero base a potenciar:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la potencia máxima a probar:");
            int maxPow = int.Parse(Console.ReadLine());*/

            for (int i = 1; i <= 1; i++)
            {
                //int maxValue = (int)Math.Pow(baseNum, i);
                int[] searchIn = new int[] {1, 7, 9, 14, 27, 35, 42, 51, 55};//RandomList(maxValue, 0, maxValue);
                PrintTabe(searchIn);

                Console.WriteLine("Prueba " + i + ". Numero de elementos: " + searchIn.Length + ". Buscando número: 99");// + (maxValue + 1));
                var orderedArray = searchIn.OrderBy(x => x);

                Console.WriteLine("\n------ Busqueda Lineal Pivote Central -------");
                int result = BinarySearch(99, orderedArray.ToArray());
                switch (result)
                {
                    case -1:
                        Console.WriteLine("El valor no se encuentra en la lista");
                        break;
                    default:
                        Console.WriteLine("La posición del valor es: " + result);
                        break;
                }

                Console.WriteLine("\n\n------ Busqueda Lineal Pivote Central + 1 -------");
                result = BinarySearchMod(99, orderedArray.ToArray());
                switch (result)
                {
                    case -1:
                        Console.WriteLine("El valor no se encuentra en la lista");
                        break;
                    default:
                        Console.WriteLine("La posición del valor es: " + result);
                        break;
                }
            }
        }

        static int[] RandomList(int size = 4, int minValue = 0, int maxValue = 10)
        {
            int[] list = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list[i] = rand.Next(minValue, maxValue);
            }
            return list;
        }

        static void PrintTabe(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(i + " | " + array[i]);
                }
                else
                {
                    Console.Write(i + " | " + array[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }

        static int BinarySearch(int searchFor, int[] searchIn)
        {
            int iters = 0;
            int comps = 0;
            int index = -1;

            int posI = 0;
            int posF = searchIn.Length - 1;
            int pivot = (int) Math.Floor((posF + posI) / 2.0f);

            DateTime start = DateTime.Now;

            do
            {
                iters++;
                Console.WriteLine("Pivote: " + pivot);
                comps++;
                if (searchIn[pivot] == searchFor)
                {
                    index = pivot;
                }
                else if (searchFor > searchIn[pivot])
                {
                    comps++;
                    posI = pivot + 1;
                }
                else
                {
                    comps++;
                    posF = pivot - 1;
                }
                pivot = (int)Math.Floor((posF + posI) / 2.0f);
            } while (posI <= posF && index == -1);

            Console.WriteLine("Tiempo de ejecución: " + (DateTime.Now - start).TotalMilliseconds + "ms");
            Console.WriteLine("Iteraciones: " + iters);
            Console.WriteLine("Comparaciones: " + comps);

            return index;
        }

        static int BinarySearchMod(int searchFor, int[] searchIn)
        {
            int iters = 0;
            int comps = 0;
            int index = -1;

            int posI = 0;
            int posF = searchIn.Length - 1;
            int pivot = (int)Math.Floor((posF + posI) / 2.0f) + 1;

            DateTime start = DateTime.Now;

            do
            {
                iters++;
                Console.WriteLine("Pivote: " + pivot);
                comps++;
                if (searchIn[pivot] == searchFor)
                {
                    index = pivot;
                }
                else if (searchFor > searchIn[pivot])
                {
                    comps++;
                    posI = pivot + 1;
                }
                else
                {
                    comps++;
                    posF = pivot - 1;
                }
                pivot = (int)Math.Floor((posF + posI) / 2.0f) + 1;
            } while (posI <= posF && index == -1);

            Console.WriteLine("Tiempo de ejecución: " + (DateTime.Now - start).TotalMilliseconds + "ms");
            Console.WriteLine("Iteraciones: " + iters);
            Console.WriteLine("Comparaciones: " + comps);

            return index;
        }
    }
}
