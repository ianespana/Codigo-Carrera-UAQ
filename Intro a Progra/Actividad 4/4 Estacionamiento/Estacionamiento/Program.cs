using System;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el costo por hora:");
            var costo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de horas:");
            var horas = double.Parse(Console.ReadLine());

            horas = Math.Ceiling(horas);
            Console.WriteLine("El costo total es de {0}", horas * costo);
        }
    }
}
