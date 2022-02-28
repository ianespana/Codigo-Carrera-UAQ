using System;

namespace Ejercicio_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 0;
            Console.WriteLine("Ingresa un destino:\n\t1. México\n\t2. Puerto Vallarta\n\t3. Acapulco\n\t4. Cancún");
            byte destination = byte.Parse(Console.ReadLine());

            switch (destination)
            {
                case 1:
                    distance = 750;
                    break;
                case 2:
                    distance = 800;
                    break;
                case 3:
                    distance = 1200;
                    break;
                case 4:
                    distance = 1800;
                    break;
                default:
                    Console.WriteLine("El destino seleccionado no es válido");
                    return;
            }

            Console.WriteLine("Ingresa el costo por kilometro:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu presupuesto:");
            double budget = double.Parse(Console.ReadLine());

            if (distance*2*price > budget)
            {
                Console.WriteLine("El precio es muy alto, deberás quedarte en casa :(");
            }
            else
            {
                Console.WriteLine("¡Tu presupuesto es suficiente!¡Buen viaje!");
            }
        }
    }
}
