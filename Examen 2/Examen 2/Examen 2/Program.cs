using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Examen_2
{
    public class Entry
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int inventory { get; set; }
    }

    class Program
    {
        static void ParseFile(string file, List<Entry> entries)
        {
            if (!File.Exists(file))
            {
                var fileStream = File.Create(file);
                fileStream.Close();
                return;
            }

            var lines = File.ReadLines(file);
            for (int i = 0; i < lines.Count() / 5; i++)
            {
                var offset = i * 4;

                float price;
                float.TryParse(lines.ElementAt(3 + offset), out price);

                int inventory;
                int.TryParse(lines.ElementAt(4 + offset), out inventory);

                entries.Insert(i, new Entry()
                {
                    name = lines.ElementAt(1 + offset),
                    description = lines.ElementAt(2 + offset),
                    price = price,
                    inventory = inventory
                });
            }
        }

        static void WriteFile(string file, List<Entry> entries)
        {
            using (StreamWriter fileStream = File.CreateText(file))
            {
                foreach (Entry entry in entries)
                {
                    fileStream.WriteLine(entry.ID);
                    fileStream.WriteLine(entry.name.Trim());
                    fileStream.WriteLine(entry.description.Trim());
                    fileStream.WriteLine(entry.price);
                    fileStream.WriteLine(entry.inventory);
                }
            }
        }

        static void PrintEntries(List<Entry> entries)
        {
            Console.WriteLine(" ID | Nombre | Descripción | Precio | Inventario ");
            foreach (Entry entry in entries)
            {
                PrintEntry(entry);
            }
        }

        static void PrintEntry(Entry entry)
        {
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", entry.ID, entry.name, entry.description, entry.price, entry.inventory);
        }

        static void Main(string[] args)
        {
            string file = Path.Combine(Environment.CurrentDirectory, "productos.txt");
            var entries = new List<Entry>();
            ParseFile(file, entries);
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingersa la opción que deseas:");
                Console.WriteLine("1. Altas");
                Console.WriteLine("2. Cambios");
                Console.WriteLine("3. Consulta");
                var opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AddEntry(entries);
                        break;
                    case 2:
                        ModifyEntry(entries);
                        break;
                    case 3:
                        ListEntries(entries);
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine("Deseas repetir el programa? si/no");
                respuesta = Console.ReadLine();
            } while (respuesta.ToLower().Equals("si"));
            WriteFile(file, entries);
        }

        static void AddEntry(List<Entry> entries)
        {
            Console.Clear();
            Console.WriteLine(" Altas ");
            Console.WriteLine("-------");

            Console.WriteLine("Ingresa el nombre del producto:");
            string name = Console.ReadLine();

            Console.WriteLine("Ingresa la descripción del producto:");
            string description = Console.ReadLine();

            Console.WriteLine("Ingresa el precio del producto:");
            float price;
            float.TryParse(Console.ReadLine(), out price);

            Console.WriteLine("Ingresa el inventario del producto:");
            int inventory;
            int.TryParse(Console.ReadLine(), out inventory);

            entries.Add(new Entry()
            {
                name = name,
                description = description,
                price = price,
                inventory = inventory
            });
        }

        static void ModifyEntry(List<Entry> entries)
        {
            Console.Clear();
            Console.WriteLine(" Cambios ");
            Console.WriteLine("---------");

            PrintEntries(entries);

            Console.WriteLine("Ingresa el ID del registro a modificar:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona la opción a modificar: ");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Descripción");
            Console.WriteLine("3. Precio");
            Console.WriteLine("4. Inventario");
            byte opcionModificar = byte.Parse(Console.ReadLine());

            switch (opcionModificar)
            {
                case 1:
                    Console.WriteLine("Ingresa el nuevo nombre:");
                    entries[id].name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ingresa la nueva descripción:");
                    entries[id].description = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Ingresa el nuevo precio:");
                    float price;
                    float.TryParse(Console.ReadLine(), out price);
                    entries[id].price = price;
                    break;
                case 4:
                    Console.WriteLine("Ingresa el nuevo inventario:");
                    int inventory;
                    int.TryParse(Console.ReadLine(), out inventory);
                    entries[id].inventory = inventory;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        static void ListEntries(List<Entry> entries)
        {
            Console.Clear();
            Console.WriteLine(" Consulta de registros ");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Ingresa el ID del registro a consultar. Si quieres ver todos los registros presiona enter.");
            string temp = Console.ReadLine();

            if (temp == "")
            {
                PrintEntries(entries);
                return;
            }

            int id = int.Parse(temp);
            if (entries.ElementAtOrDefault(id) != null)
            {
                PrintEntry(entries[id]);
            }
            else
            {
                Console.WriteLine("ID inválido");
            }
        }
    }
}
