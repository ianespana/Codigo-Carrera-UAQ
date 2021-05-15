using System;

namespace Ejemplo_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] nums = new float[3];

            Console.WriteLine("Dame la primer cantidad:");
            nums[0] = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la segunda cantidad:");
            nums[1] = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la tercera cantidad:");
            nums[2] = float.Parse(Console.ReadLine());

            float may = float.MinValue;

            foreach (float num in nums)
            {
                if (num > may)
                {
                    may = num;
                }
            }

            Console.WriteLine("La cantidad mas gande es: " + may);
        }
    }
}
