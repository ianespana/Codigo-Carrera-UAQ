using System;

namespace Ejemplo_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            Console.WriteLine("Ingresa la clave del producto:\n\t1\n\t2\n\t3\n\t4\n\t5\n\t6");
            byte code = byte.Parse(Console.ReadLine());

            switch (code)
            {
                case 1:
                    price = 0.8+0.28;
                    break;
                case 2:
                    price = 0.85+0.3;
                    break;
                case 3:
                    price = 0.75+0.35;
                    break;
                case 4:
                    price = 0.75+0.28;
                    break;
                case 5:
                    price = 0.8+0.3;
                    break;
                case 6:
                    price = 0.85+0.35;
                    break;
                default:
                    Console.WriteLine("La clave elegida no es válida");
                    return;
            }

            Console.WriteLine("¿Cuál es el costo de la materia prima?");
            double matPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("El costo de producción es de ${0}", matPrice*price);
            Console.WriteLine("El precio de venta es de ${0}", matPrice*price*1.45);
        }
    }
}
