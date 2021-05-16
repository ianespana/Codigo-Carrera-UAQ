using System;

namespace Ejercicio_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu antiguedad en años:");
            float years = float.Parse(Console.ReadLine());

            float bonus;
            if (years > 5)
            {
                bonus = 1000f;
            }
            else
            {
                bonus = years * 100f;
            }

            Console.WriteLine("Tu bono es de " + bonus);
        }
    }
}
