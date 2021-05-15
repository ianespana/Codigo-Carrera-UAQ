using System;

namespace Ejemplo_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el sueldo por hora:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el numero de horas trabajadas:");
            float hours = float.Parse(Console.ReadLine());

            Console.WriteLine("La distancia entre puntos es: " + (salary * hours));
        }
    }
}
