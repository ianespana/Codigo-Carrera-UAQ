using System;

namespace Ejemplo_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero:");
            float numA = float.Parse(Console.ReadLine());

            String val = numA < 0 ? "negativo" : "positivo";

            Console.WriteLine("El numero es " + val);
        }
    }
}
