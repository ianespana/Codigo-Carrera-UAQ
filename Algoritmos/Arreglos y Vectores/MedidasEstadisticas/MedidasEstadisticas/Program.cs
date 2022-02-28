using System;

namespace MedidasEstadisticas
{
    internal class Program
    {
        static double Mean(int[] nums) {
            double sum = 0;
            foreach (int num in nums) {
                sum += num;
            }

            sum /= nums.Length;

            return sum;
        }

        static double Median(int[] nums) {
            Array.Sort(nums);
            if (nums.Length % 2 == 0)
            {
                return (nums[(nums.Length / 2) - 1] + nums[nums.Length / 2]) / 2.0;
            }
            else
            {
                return nums[nums.Length / 2];
            }
        }

        static int Mode(int[] nums)
        {
            Array.Sort(nums);

            // Idealmente usaríamos un Dictionary para guardar pares (key,value) en lugar de utilizar arreglos
            int[] counts = new int[nums[nums.Length - 1] + 1];

            foreach (int num in nums)
            {
                counts[num]++;
            }

            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > max)
                {
                    max = counts[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static double Variance(int[] nums)
        {
            Array.Sort(nums);
            double mean = Mean(nums);
            double sum = 0;

            foreach (double num in nums)
            {
                sum += Math.Pow(num - mean, 2);
            }

            return sum / nums.Length;
        }

        static int[] nums = new int[] { 4, 23, 21, 0, 5, 2, 4, 8, 19, 22, 36, 78, 11, 5, 0, 0, 6, 5, 21, 4 };
        static void Main(string[] args)
        {
            Array.Sort(nums);
            Console.WriteLine("Min: " + nums[0]);
            Console.WriteLine("Max: " + nums[nums.Length - 1]);

            Console.WriteLine("Media: " + Mean(nums));
            Console.WriteLine("Mediana: " + Median(nums));
            Console.WriteLine("Moda: " + Mode(nums));

            double variance = Variance(nums);
            Console.WriteLine("Varianza: " + variance);
            Console.WriteLine("Desviación Estándar: " + Math.Sqrt(variance));
        }
    }
}
