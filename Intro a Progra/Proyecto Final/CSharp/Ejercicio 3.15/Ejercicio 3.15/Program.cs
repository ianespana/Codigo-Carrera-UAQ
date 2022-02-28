using System;

namespace Ejercicio_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número (1-7):");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("El número es equivalente a: Lunes");
                    break;
                case 2:
                    Console.WriteLine("El número es equivalente a: Martes");
                    break;
                case 3:
                    Console.WriteLine("El número es equivalente a: Miércoles");
                    break;
                case 4:
                    Console.WriteLine("El número es equivalente a: Jueves");
                    break;
                case 5:
                    Console.WriteLine("El número es equivalente a: Viernes");
                    break;
                case 6:
                    Console.WriteLine("El número es equivalente a: Sábado");
                    break;
                case 7:
                    Console.WriteLine("El número es equivalente a: Domingo");
                    break;
                default:
                    Console.WriteLine("No se puede convertir a un día");
                    break;
            }
        }
    }
}
