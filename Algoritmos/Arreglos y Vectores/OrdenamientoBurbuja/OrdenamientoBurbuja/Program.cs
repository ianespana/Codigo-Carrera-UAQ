using System;

namespace OrdenamientoBurbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 7, 3, 4, 6, 9 };
            PrintArray(nums);
            //Algortimo de ordenacion  burbuja
            int comp = 0;
            int inter = 0;
            bool flag;
            for (int j = 0; j < nums.Length; j++)
            {
                flag = true;
                for (int i = 0; i < nums.Length - 1 - j; i++)
                {
                    comp++;
                    if (nums[i] > nums[i + 1])
                    {
                        int aux = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = aux;
                        inter++;
                        flag = false;
                        PrintArray(nums);
                    }
                }
                if (flag) break;
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
