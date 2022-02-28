using System;

namespace Descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el precio original del artículo");
            var precio = float.Parse(Console.ReadLine());

            precio *= 0.8f;
            Console.WriteLine("El precio del artículo con descuento es {0}", precio);

            precio *= 1.15f;
            Console.WriteLine("El precio final del artículo con descuento e IVA es {0}", precio);
        }
    }
}
