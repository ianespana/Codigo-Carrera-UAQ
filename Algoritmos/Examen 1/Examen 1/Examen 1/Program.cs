using System;

namespace Examen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 8, 3, 2, 5, 6, 4 };
            PrintArray(nums);
            //Algortimo de ordenacion  burbuja
            int comp = 0;
            int inter = 0;
            int i = 0;

            do
            {
                int j = 0;
                do
                {
                    comp++;
                    if (nums[j] < nums[j + 1])
                    {
                        int aux = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = aux;
                        inter++;
                        PrintArray(nums);
                    }

                    j++;
                } while (j < nums.Length - 1 - i);

                i++;
            } while (i < nums.Length);
            PrintArray(nums);

            Console.WriteLine();
            Console.WriteLine("Comparaciones: " + comp);
            Console.WriteLine("Intercambios: " + inter);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
