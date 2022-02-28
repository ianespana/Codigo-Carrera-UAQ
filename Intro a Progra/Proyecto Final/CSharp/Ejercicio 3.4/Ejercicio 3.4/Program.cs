using System;

namespace Ejercicio_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float price = 0;

            Console.WriteLine("Dame el numero de horas:");
            float hours = float.Parse(Console.ReadLine());
            hours = (float) Math.Ceiling(hours);

            for (int x = 1; x <= hours; x++)
            {
                price += CalculatePrice(x);
            }

            Console.WriteLine("El costo final es: " + price);
        }

        static float CalculatePrice(float hour)
        {
            if (hour > 0 && hour <= 2)
            {
                return 5;
            }
            else if (hour > 2 && hour <= 5)
            {
                return 4;
            }
            else if (hour > 5 && hour <= 10)
            {
                return 3;
            }
            else if (hour > 10)
            {
                return 2;
            }
            else
            {
                Console.WriteLine("El número de horas no es válido");
                return 0;
            }
        }
    }
}
