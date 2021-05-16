using System;

namespace Ejercicio_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una calificación (0-10):");
            int grade = int.Parse(Console.ReadLine());

            switch (grade)
            {
                case 10:
                    Console.WriteLine("La calificación equivalente es: A");
                    break;
                case 9:
                    Console.WriteLine("La calificación equivalente es: B");
                    break;
                case 8:
                    Console.WriteLine("La calificación equivalente es: C");
                    break;
                case 7:
                    Console.WriteLine("La calificación equivalente es: D");
                    break;
                case 6:
                    Console.WriteLine("La calificación equivalente es: D");
                    break;
                default:
                    Console.WriteLine("La calificación equivalente es: F");
                    break;
            }
        }
    }
}
