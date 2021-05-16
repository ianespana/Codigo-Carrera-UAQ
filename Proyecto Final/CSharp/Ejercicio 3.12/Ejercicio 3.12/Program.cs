using System;

namespace Ejercicio_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Dame el total de horas trabajadas:");
            float horas = float.Parse(Console.ReadLine());

            if (horas > 50)
            {
                Console.WriteLine("Trabajar más de 50 horas no está permitido");
                return;
            }

            Console.WriteLine("Dame el sueldo por hora:");
            float sueldo = float.Parse(Console.ReadLine());

            for (int x = 1; x <= horas; x++)
            {
                total += CalculatePrice(x, sueldo);
            }

            Console.WriteLine("El pago semanal es de ${0}", total);
        }

        static double CalculatePrice(int horas, float sueldo)
        {
            if (horas > 0 && horas <= 40)
            {
                return sueldo;
            }
            else if (horas > 40 && horas <= 45)
            {
                return sueldo*2;
            }
            else if (horas > 45 && horas <= 50)
            {
                return sueldo*3;
            }
            else
            {
                Console.WriteLine("El número de horas no es válido");
                return 0;
            }
        }
    }
}
