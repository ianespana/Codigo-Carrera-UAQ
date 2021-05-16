using System;

namespace Ejemplo_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el lado R:");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el lado H:");
            float hip = float.Parse(Console.ReadLine());

            Console.WriteLine("El area es: " + ((Math.PI * Math.Pow(radius, 2)) + (Math.Sqrt(Math.Pow(hip, 2) - Math.Pow(radius, 2)) * radius)));
        }
    }
}
