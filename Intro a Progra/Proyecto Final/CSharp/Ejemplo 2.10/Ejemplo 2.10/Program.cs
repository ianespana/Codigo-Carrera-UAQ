using System;

namespace Ejemplo_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de metros:");
            float metros = float.Parse(Console.ReadLine());

            Console.WriteLine("La cantidad de pulgadas es: " + (metros / 0.0254));
        }
    }
}
