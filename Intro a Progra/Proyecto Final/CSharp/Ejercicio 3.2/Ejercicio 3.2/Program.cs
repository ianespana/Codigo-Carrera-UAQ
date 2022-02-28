using System;

namespace Ejercicio_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            Console.WriteLine("Dame el total de horas trabajadas:");
            float horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el sueldo por hora:");
            float sueldo = float.Parse(Console.ReadLine());

            total += horas* sueldo;

            if (horas > 40)
            {
                total += (horas - 40) * sueldo * 2;
            }

            Console.WriteLine("El pago semanal es de ${0}", total);
        }
    }
}
