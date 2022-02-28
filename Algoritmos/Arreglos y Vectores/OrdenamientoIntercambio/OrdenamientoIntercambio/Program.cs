using System;

namespace OrdenamientoIntercambio
{
    internal class Program
    {
        static int comp = 0;
        static int inter = 0;

        static void Swap(int[] nums, int indexA, int indexB)
        {
            int aux = nums[indexA];
            nums[indexA] = nums[indexB];
            nums[indexB] = aux;
            inter++;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 8, 4, 6, 2 };
            PrintArray(nums);

            //Algortimo de ordenacion burbuja
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    comp++;
                    if (nums[i] > nums[j])
                    {
                        Swap(nums, i, j);
                        PrintArray(nums);
                    }
                }
            }
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
