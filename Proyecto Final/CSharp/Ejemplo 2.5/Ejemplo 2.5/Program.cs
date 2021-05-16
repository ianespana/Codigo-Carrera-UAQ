using System;

namespace Ejemplo_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el ancho del terreno:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la altura del terreno (parte larga):");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el altura del terreno (parte corta):");
            float height2 = float.Parse(Console.ReadLine());

            Console.WriteLine("El area es: " + ((width * (height - height2)) / 2 + (width * height)));
        }
    }
}
