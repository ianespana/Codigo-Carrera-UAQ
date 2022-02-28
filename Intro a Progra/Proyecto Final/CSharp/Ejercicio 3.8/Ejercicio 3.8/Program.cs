using System;

namespace Ejercicio_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            float bonusA = 0;
            float bonusB = 0;

            Console.WriteLine("Ingresa tu antiguedad en años:");
            float years = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu sueldo:");
            float salary = float.Parse(Console.ReadLine());

            if (years >= 5)
            {
                bonusA = 0.3f;
            }
            else if (years >= 2 && years < 5)
            {
                bonusA = 0.2f;
            }

            if (salary >= 3500)
            {
                bonusB = 0.10f;
            }
            else if (salary >= 1000 && salary < 3500)
            {
                bonusB = 0.15f;
            }
            else if (salary < 1000)
            {
                bonusB = 0.25f;
            }

            salary *= bonusA > bonusB ? bonusA : bonusB;

            Console.WriteLine("Tu bono es de " + salary);
        }
    }
}
