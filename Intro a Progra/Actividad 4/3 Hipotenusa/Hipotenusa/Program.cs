using System;

namespace Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame la longitud de A");
            var longA = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la longitud de B");
            var longB = float.Parse(Console.ReadLine());

            Console.WriteLine("El valor de la hipotenusa es {0}", Math.Sqrt(Math.Pow(longA, 2) + Math.Pow(longB,2)));
        }
    }
}
