using System;
using System.Collections.Generic;

namespace Ejercicio_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int> { };
            string biggestPerson = "";
            int biggestAge = int.MinValue;

            for (int x = 0; x <= 2; x++)
            {
                Console.WriteLine("Dame el nombre de la persona " + (x + 1));
                string name = Console.ReadLine();

                Console.WriteLine("Dame la edad de la persona " + (x + 1));
                int age = int.Parse(Console.ReadLine());

                people.Add(name, age);
            }

            foreach (KeyValuePair<string, int> person in people)
            {
                if (person.Value >= biggestAge)
                {
                    biggestAge = person.Value;
                    biggestPerson = person.Key;
                }
            }

            Console.WriteLine("La persona más grande es " + biggestPerson);
        }
    }
}
