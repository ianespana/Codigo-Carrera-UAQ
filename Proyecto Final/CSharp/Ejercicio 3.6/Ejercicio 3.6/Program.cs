using System;

namespace Ejercicio_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el precio original del artículo");
            float precio = float.Parse(Console.ReadLine());

            if (precio >= 200)
            {
                precio *= 0.85f;
            }
            else if (precio >= 100 && precio < 200)
            {
                precio *= 0.88f;
            }
            else if (precio < 100)
            {
                precio *= 0.90f;
            }

            Console.WriteLine("El precio del artículo con descuento es {0}", precio);
        }
    }
}
