using System;

namespace Ejemplo_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de alumnos:");
            int people = int.Parse(Console.ReadLine());

            int price;

            if (people >= 30 && people < 50)
            {
                price = 95;
            }
            else if (people >= 50 && people < 100)
            {
                price = 70;
            }
            else if (people >= 100)
            {
                price = 65;
            }
            else
            {
                Console.WriteLine("El costo total es: " + 4000);
                Console.WriteLine("El costo por alumno es: " + 4000 / people);
                return;
            }

            Console.WriteLine("El costo total es: " + people * price);
            Console.WriteLine("El costo por alumno es: " + price);
        }
    }
}
