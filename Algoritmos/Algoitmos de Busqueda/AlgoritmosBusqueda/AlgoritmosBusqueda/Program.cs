using System;

namespace AlgoritmosBusqueda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero base a potenciar:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la potencia máxima a probar:");
            int maxPow = int.Parse(Console.ReadLine());
            
            /*Console.WriteLine("Ingresa la cantiad de numeros a generar:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor mínimo que puede tomar la lista aleatoria:");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor máximo que puede tomar la lista aleatoria:");
            int maxValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor a buscar:");
            int searchFor = int.Parse(Console.ReadLine());*/
            for (int i = 1; i <= maxPow; i++){
                int maxValue = (int) Math.Pow(baseNum, i);
                int[] searchIn = RandomList(maxValue, 0, maxValue);
                //PrintTabe(searchIn);

                Console.WriteLine("Prueba " + i + ". Numero de elementos: " + maxValue + ". Buscando número: " + (maxValue + 1));

                int result = LinealSearch(maxValue + 1, searchIn);
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
            for (int i = 0; i < size; i++) {
                list[i] = rand.Next(minValue, maxValue);
            }
            return list;
        }

        static void PrintTabe(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1) {
                    Console.Write(i + " | " + array[i]);
                } else {
                    Console.Write(i + " | " + array[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }

        static int LinealSearch(int searchFor, int[] searchIn)
        {
            int iters = 0;
            int comps = 0;
            int index = -1;

            DateTime start = DateTime.Now;

            for (int i = 0; i < searchIn.Length; i++)
            {
                iters++;

                comps++;
                if (searchIn[i] == searchFor)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine("Tiempo de ejecución: " + (DateTime.Now - start).TotalMilliseconds + "ms");
            Console.WriteLine("Iteraciones: " + iters);
            Console.WriteLine("Comparaciones: " + comps);

            return index;
        }
    }
}
