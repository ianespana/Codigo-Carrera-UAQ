using System;

namespace Ejemplo_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el precio por galon:");
            float ppg = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el nmero de litros:");
            float liters = float.Parse(Console.ReadLine());

            Console.WriteLine("El costo total es: " + ppg * (liters / 3.785));
        }
    }
}
