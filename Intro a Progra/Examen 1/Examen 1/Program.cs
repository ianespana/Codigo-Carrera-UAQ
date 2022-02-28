using System;

namespace Examen_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número para elegir el ejercicio:\n\t1. Saldo semanal\n\t2. Naufrago satisfecho\n\t3. Costo de enviar un paquete\n\t4. Estatura promedio");
            byte ejercicio = byte.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    Pregunta1();
                    break;
                case 2:
                    Pregunta2();
                    break;
                case 3:
                    Pregunta3();
                    break;
                case 4:
                    Pregunta4();
                    break;
                default:
                    break;
            }
        }

        static void Pregunta1()
        {
            Console.WriteLine("Dame el total de horas trabajadas:");
            float horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el sueldo or hora:");
            float sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine("El pago semanal es de ${0}", horas*sueldo);
        }

        static void Pregunta2()
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

        static void Pregunta3()
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

        static void Pregunta4()
        {
            double promedio = 0;
            Console.WriteLine("Dame el numero de personas para registrar las estaturas");
            int estaturas = int.Parse(Console.ReadLine());

            if (estaturas <= 1)
            {
                Console.WriteLine("no hay estaturas");
                return;
            }

            for (int i = 0; i < estaturas; i++)
            {
                Console.WriteLine("Dame la estatura {0} en centimetros", i + 1);
                promedio += double.Parse(Console.ReadLine());
            }

            promedio /= estaturas;

            Console.WriteLine("El promedio es {0}", promedio);
        }
    }
}
