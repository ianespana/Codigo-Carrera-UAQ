using System;

namespace Ejercicio_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de alumnos:");
            int people = int.Parse(Console.ReadLine());

            int price;

            if (people >= 100)
            {
                price = 20;
            }
            else if (people >= 50 && people < 100)
            {
                price = 35;
            }
            else if (people >= 20 && people < 50)
            {
                price = 40;
            }
            else
            {
                price = 70;
            }

            Console.WriteLine("El costo total es: " + people * price);
            Console.WriteLine("El costo por alumno es: " + price);
        }
    }
}
