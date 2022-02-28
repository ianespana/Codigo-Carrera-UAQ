using System;

namespace Ejercicio_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            double extra = 1.1;
            Console.WriteLine("Ingresa un número para elegir la póliza:\n\t1. Cobertura amplia\n\t2. Daños a terceros");
            byte insType = byte.Parse(Console.ReadLine());

            switch (insType)
            {
                case 1:
                    price = 1200;
                    break;
                case 2:
                    price = 950;
                    break;
                default:
                    Console.WriteLine("La póliza elegida no es válida");
                    return;
            }

            Console.WriteLine("¿Tienes el hábito de beber alcohol?\n\t1. Sí\n\t2. No");
            byte alcohol = byte.Parse(Console.ReadLine());

            if (alcohol == 1)
            {
                extra += 0.1;
            }

            Console.WriteLine("¿Utilizas lentes?\n\t1. Sí\n\t2. No");
            byte glasses = byte.Parse(Console.ReadLine());

            if (glasses == 1)
            {
                extra += 0.05;
            }

            Console.WriteLine("¿Padeces alguna enfermedad como diabetes o deficiencia cardiaca?\n\t1. Sí\n\t2. No");
            byte ilness = byte.Parse(Console.ReadLine());

            if (ilness == 1)
            {
                extra += 0.05;
            }

            Console.WriteLine("¿Tienes más de 40 años?\n\t1. Sí\n\t2. No");
            byte age = byte.Parse(Console.ReadLine());

            if (age == 1)
            {
                extra += 0.2;
            }

            Console.WriteLine("El costo final de tu poliza es " + extra * price);
        }
    }
}
