using System;

namespace Ejemplo_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de lapices:");
            int pencils = int.Parse(Console.ReadLine());

            int price = pencils >= 1000 ? 85 : 90;

            Console.WriteLine("El costo final es " + pencils * price);
        }
    }
}
