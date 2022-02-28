using System;
using System.Globalization;

namespace Ejercicio_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu fecha de nacimiento (DD/MM/AA)");
            string birthdyIn = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(birthdyIn, new CultureInfo("es-MX", false).DateTimeFormat);

            Console.WriteLine("Ingresa la fecha de las elecciones (DD/MM/AA)");
            string electionsIn = Console.ReadLine();
            DateTime elections = Convert.ToDateTime(electionsIn, new CultureInfo("es-MX", false).DateTimeFormat);

            TimeSpan timeDiff = elections.Subtract(birthday);

            if (timeDiff.TotalDays >= (365 * 18))
            {
                Console.WriteLine("Puedes votar");
            }
            else
            {
                Console.WriteLine("No puedes votar");
            }
        }
    }
}
