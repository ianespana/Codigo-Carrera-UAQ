using System;

namespace Ejemplo_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer numero:");
            float numA = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero:");
            float numB = float.Parse(Console.ReadLine());

            float numC = numA > numB ? numA : numB;

            Console.WriteLine("El numero más grande es: " + numC);
        }
    }
}
