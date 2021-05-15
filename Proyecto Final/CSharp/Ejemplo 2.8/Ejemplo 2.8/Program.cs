using System;

namespace Ejemplo_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame la coordenada X del primer punto:");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la coordenada Y del primer punto:");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la coordenada X del segundo punto:");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la coordenada Y del segundo punto:");
            float y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("La distancia entre puntos es: " + (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
        }
    }
}
