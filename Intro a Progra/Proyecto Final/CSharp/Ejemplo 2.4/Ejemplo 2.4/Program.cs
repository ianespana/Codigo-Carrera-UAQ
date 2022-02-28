using System;

namespace Ejemplo_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el radio del circulo:");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("El area es: " + (Math.PI * Math.Pow(radius, 2)));
        }
    }
}
