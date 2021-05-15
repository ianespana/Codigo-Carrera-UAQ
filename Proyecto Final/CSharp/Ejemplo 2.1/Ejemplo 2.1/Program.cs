using System;

namespace Ejemplo_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer numero:");
            float numA = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero:");
            float numB = float.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + (numA + numB));
        }
    }
}
