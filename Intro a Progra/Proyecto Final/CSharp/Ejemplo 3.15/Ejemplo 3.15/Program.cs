using System;

namespace Ejemplo_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué tipo de tarjeta es?\n\t1. Tipo 1\n\t2. Tipo 2\n\t3. Tipo 3\n\t4. Otro");
            byte tipo = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es el límite de crédito actual?");
            double limiteActual = double.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    limiteActual *= 1.25;
                    break;
                case 2:
                    limiteActual *= 1.35;
                    break;
                case 3:
                    limiteActual *= 1.4;
                    break;
                default:
                    limiteActual *= 1.5;
                    break;
            }

            Console.WriteLine("El nuevo límite es de ${0}", limiteActual);
        }
    }
}
