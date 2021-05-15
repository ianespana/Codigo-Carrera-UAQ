using System;

namespace Ejemplo_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            Console.WriteLine("Ingresa un número para elegir la hamburguesa:\n\t1. Sencilla - $20.00\n\t2. Doble - $25.00\n\t3. Triple - $30.00");
            byte hamburguesa = byte.Parse(Console.ReadLine());

            switch (hamburguesa)
            {
                case 1:
                    precio = 20;
                    break;
                case 2:
                    precio = 25;
                    break;
                case 3:
                    precio = 30;
                    break;
                default:
                    Console.WriteLine("La Hamburguesa elegida no es válida");
                    return;
            }

            Console.WriteLine("¿Cuántas hamburguesas quieres pedir?");
            int cantidad = int.Parse(Console.ReadLine());
            precio *= cantidad;

            Console.WriteLine("Elige tu método de pago:\n\t1. Efectivo\n\t2. Tarjeta");
            byte metodo = byte.Parse(Console.ReadLine());

            if (metodo > 2)
            {
                Console.WriteLine("Método de pago inválido");
                return;
            }
            else if (metodo == 2)
            {
                precio *= 1.05;
            }

            Console.WriteLine("El costo total es de ${0}", Math.Round(precio, 2));
        }
    }
}
