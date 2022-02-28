using System;

namespace Ejemplo_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el precio del traje:");
            float price = float.Parse(Console.ReadLine());

            float disc = price > 2500 ? 0.85f : 0.92f;

            Console.WriteLine("El costo final es " + price * disc);
        }
    }
}
