using System;

namespace OrdenamientoBurbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 8,3,2,5,6,4 };
            PrintArray(nums);
            //Algortimo de ordenacion  burbuja
            int comp = 0;
            int inter = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0; i < nums.Length - 1 - j; i++)
                {
                    comp++;
                    if (nums[i] > nums[i + 1])
                    {
                        int aux = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = aux;
                        inter++;
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
