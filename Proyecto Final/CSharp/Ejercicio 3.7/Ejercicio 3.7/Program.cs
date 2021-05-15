using System;

namespace Ejercicio_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu promedio:");
            float promedio = float.Parse(Console.ReadLine());

            if (age > 18)
            {
                if (promedio >= 9)
                {
                    Console.WriteLine("Tienes una beca de 2000");
                }
                else if (promedio >= 7.5 && promedio < 9)
                {
                    Console.WriteLine("Tienes una beca de 1000");
                }
                else if (promedio >= 6 && promedio < 7.5)
                {
                    Console.WriteLine("Tienes una beca de 500");
                }
                else
                {
                    Console.WriteLine("No tienes beca, estudia mpas el próximo ciclo escolar");
                }
            }
            else
            {
                if (promedio >= 9)
                {
                    Console.WriteLine("Tienes una beca de 3000");
                }
                else if (promedio >= 8 && promedio < 9)
                {
                    Console.WriteLine("Tienes una beca de 2000");
                }
                else if (promedio >= 6 && promedio < 8)
                {
                    Console.WriteLine("Tienes una beca de 100");
                }
                else
                {
                    Console.WriteLine("No tienes beca, estudia mpas el próximo ciclo escolar");
                }
            }
        }
    }
}
