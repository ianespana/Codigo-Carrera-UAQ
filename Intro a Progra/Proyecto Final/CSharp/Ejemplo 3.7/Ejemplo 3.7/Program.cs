using System;

namespace Ejemplo_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos kilos de uva estas vendiendo?");
            float kilos = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué tipo de uva son?\n\t1. Tipo A\n\t2. Tipo B");
            byte type = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿De qué tamaño son?\n\t1. Tamaño 1\n\t2. Tamaño 2");
            byte size = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿A qué precio las quieres vender?");
            float price = float.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    if (size == 1)
                    {
                        price += 0.20f;
                    }
                    else
                    {
                        price += 0.30f;
                    }
                    break;
                case 2:
                    if (size == 1)
                    {
                        price -= 0.30f;
                    }
                    else
                    {
                        price -= 0.50f;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo inválido");
                    return;
            }

            Console.WriteLine("El costo total es: " + kilos * price);
        }
    }
}
