using System;

namespace Ejemplo_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame la calificacion del primer examen:");
            float examA = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la calificacion del segundo examen:");
            float examB = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la calificacion del tercer examen:");
            float examC = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la calificacion del cuarto examen:");
            float examD = float.Parse(Console.ReadLine());

            Console.WriteLine("El promedio es: " + (examA + examB + examC + examD) * 0.25);
        }
    }
}
