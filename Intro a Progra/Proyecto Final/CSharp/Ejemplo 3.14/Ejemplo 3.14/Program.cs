using System;

namespace Ejemplo_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos kilos pesa el paquete?");
            double kilos = double.Parse(Console.ReadLine());

            Console.WriteLine("¿A qué zona se va a realizar el envío?\n\t1. América del Norte\n\t2. América Central\n\t3. América del Sur\n\t4. Europa\n\t5. Asia");
            byte zona = byte.Parse(Console.ReadLine());

            if (kilos > 5)
            {
                Console.WriteLine("No se puede realizar el envio, el paquete pesa más de 5 kilos");
                return;
            }

            uint precio = (uint)(kilos * 1000);
            switch (zona)
            {
                case 1:
                    precio *= 11;
                    break;
                case 2:
                    precio *= 10;
                    break;
                case 3:
                    precio *= 12;
                    break;
                case 4:
                    precio *= 24;
                    break;
                case 5:
                    precio *= 27;
                    break;
                default:
                    Console.WriteLine("Zona inválida");
                    return;
            }

            Console.WriteLine("El costo por el envío es de ${0}", precio);
        }
    }
}
