using System;

namespace Ejemplo_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            float price = 0f;
            Console.WriteLine("Dame el numero de personas:");
            float people = float.Parse(Console.ReadLine());

            people = people < 20 ? 20 : people;

            Console.WriteLine("Indica el tipo de autobs:\n\t1. Tipo A\n\t2. Tipo B\n\t3. Tipo C");
            byte bus = byte.Parse(Console.ReadLine());

            switch (bus)
            {
                case 1:
                    price = 2f;
                    break;
                case 2:
                    price = 2.5f;
                    break;
                case 3:
                    price = 3f;
                    break;
                default:
                    Console.WriteLine("Autobus invalido");
                    return;
            }

            Console.WriteLine("El costo total es: " + people * price);
        }
    }
}
