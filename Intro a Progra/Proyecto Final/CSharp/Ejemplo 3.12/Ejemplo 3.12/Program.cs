using System;

namespace Ejemplo_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            Console.WriteLine("Ingresa el número de cita");
            int appointment = int.Parse(Console.ReadLine());

            for (int x = 1; x <= appointment; x++)
            {
                price += CalculatePrice(x);
            }

            Console.WriteLine("El costo de la cita es de ${0}", CalculatePrice(appointment));
            Console.WriteLine("El total gastado es de ${0}", price);
        }

        static double CalculatePrice(int appointment)
        {
            if (appointment > 0 && appointment <= 3)
            {
                return 200;
            }
            else if (appointment > 3 && appointment <= 5)
            {
                return 150;
            }
            else if (appointment > 5 && appointment <= 8)
            {
                return 100;
            }
            else if (appointment > 8)
            {
                return 50;
            }
            else
            {
                Console.WriteLine("El número de cita no es válido");
                return 0;
            }
        }
    }
}
