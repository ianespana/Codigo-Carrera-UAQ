using System;

namespace Ejemplo_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de personas:");
            int people = int.Parse(Console.ReadLine());

            int price = 95;

            if (people > 200 && people <= 300)
            {
                price = 85;
            }
            else if (people > 300)
            {
                price = 75;
            }
            Console.WriteLine("El costo total es: " + people * price);
        }
    }
}
