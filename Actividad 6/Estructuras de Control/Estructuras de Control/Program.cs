using System;

namespace Estructuras_de_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número para elegir el ejercicio:\n\t1. Determinar el valor más grande\n\t2. Determinar si un numero es positivo o negativo\n\t3. Precio de unos lápices\n\t4. Ganancia de las uvas\n\t5. Costo de enviar un paquete\n\t6. Límite de crédito");
            byte ejercicio = byte.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Ejercicio6();
                    break;
                default:
                    break;
            }
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Dame el primer valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());

            double mayor;
            if (valor1 > valor2)
            {
                mayor = valor1;
            }
            else if (valor1 == valor2)
            {
                Console.WriteLine("Los dos valores son iguales");
                return;
            }
            else
            {
                mayor = valor2;
            }
            Console.WriteLine("El mayor es {0}", mayor);
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Dame un número:");
            double numero = double.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                Console.WriteLine("El número es positivo");
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("¿Cuántos lápices quieres?");
            double cantidad = double.Parse(Console.ReadLine());

            if (cantidad > 1000)
            {
                cantidad *= 0.85;
            }
            else
            {
                cantidad *= 0.90;
            }

            Console.WriteLine("El precio total es de ${0}", cantidad);
        }

        static void Ejercicio4()
        {
            Console.WriteLine("¿Cuántos kilos de uvas estás vendiendo?");
            double kilos = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué tipo de uva son?\n\t1. Tipo A\n\t2. Tipo B");
            byte tipo = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué tamaño de uva son?\n\t1. Tamaño 1\n\t2. Tamaño 2");
            byte tamaño = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿A qué precio las quieres vender?");
            double precio = double.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    if (tamaño == 1)
                    {
                        precio += 0.20;
                    }
                    else
                    {
                        precio += 0.30;
                    }
                    break;
                case 2:
                    if (tamaño == 1)
                    {
                        precio -= 0.30;
                    }
                    else
                    {
                        precio -= 0.50;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo inválido");
                    return;
            }

            Console.WriteLine("La ganancia total es de ${0}", kilos*precio);
        }

        static void Ejercicio5()
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

        static void Ejercicio6()
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
