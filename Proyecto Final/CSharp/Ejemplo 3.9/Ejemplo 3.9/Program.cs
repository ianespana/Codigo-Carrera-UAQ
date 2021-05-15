using System;

namespace Ejemplo_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero de minutos:");
            float minutes = float.Parse(Console.ReadLine());

            float price = CalcPricePerMinute(minutes);

            Console.WriteLine("Indica el día:\n\t1. Día habil\n\t2. Sabado\n\t3. Domingo");
            byte day = byte.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Indica el turno:\n\t1. Matutino\n\t2. Vespertino");
                    byte time = byte.Parse(Console.ReadLine());
                    switch (time)
                    {
                        case 1:
                            price *= 1.15f;
                            break;
                        case 2:
                            price *= 1.1f;
                            break;
                        default:
                            Console.WriteLine("Turno invalido");
                            return;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    price *= 1.03f;
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    return;
            }

            Console.WriteLine("El costo total es: " + price);
        }

        static float CalcPricePerMinute(float n)
        {
            float total = 0;

            if (n - 5 <= 0)
            {
                total += n;
                return total;
            }
            total += 5;
            n -= 5;

            if (n - 3 <= 0)
            {
                total += n * 0.8f;
                return total;
            }
            total += 3 * 0.8f;
            n -= 3;

            if (n - 2 <= 0)
            {
                total += n * 0.7f;
                return total;
            }
            total += 2 * 0.7f;
            n -= 2;

            total += n * 0.5f;

            return total;
        }
    }
}
