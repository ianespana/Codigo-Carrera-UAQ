using System;

namespace Ejemplo_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de la base:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor de la altura:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("El area es: " + (width * height));
        }
    }
}
