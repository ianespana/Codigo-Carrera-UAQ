using System;

namespace Hotel_Cama_Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el precio por noche de la habitación:");
            var precioHabitacion = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la cantidad de noches que pasará el cliente:");
            var noches = int.Parse(Console.ReadLine());

            Console.WriteLine("El costo total es {0}", precioHabitacion * noches);
        }
    }
}
