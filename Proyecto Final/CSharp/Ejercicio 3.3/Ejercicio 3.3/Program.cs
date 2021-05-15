using System;

namespace Ejercicio_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame tu presupuesto::");
            float budget = float.Parse(Console.ReadLine());

            if (budget > 0 && budget <= 10)
            {
                Console.WriteLine("Puedes comprar una tarjeta");
            }
            else if (budget > 10 && budget <= 100)
            {
                Console.WriteLine("Puedes comprar unos chocolates");
            }
            else if (budget > 100 && budget <= 250)
            {
                Console.WriteLine("Puedes comprar flores");
            }
            else if (budget > 250)
            {
                Console.WriteLine("Puedes comprar un anillo");
            }
            else
            {
                Console.WriteLine("No puedes comprar nada :(");
            }
        }
    }
}
