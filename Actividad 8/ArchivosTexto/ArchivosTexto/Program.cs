using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ArchivosTexto
{
    public enum Active
    {
        Inactivo,
        Activo
    }
    public class Entry
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName_A { get; set; }
        public string lastName_B { get; set; }
        public DateTime birthday { get; set; }
        public string birthPlace { get; set; }
        public string gender { get; set; }
        public Active active { get; set; }
    }

    class Program
    {
        static void ParseFile(string file, List<Entry> entries)
        {
            var lines = File.ReadLines(file);
            for (int i = 0; i < lines.Count() / 8; i++)
            {
                var offset = i * 7;
                Enum.TryParse(lines.ElementAt(7 + offset), out Active activeStatus);

                entries.Insert(i, new Entry()
                {
                    lastName_A = lines.ElementAt(1 + offset),
                    lastName_B = lines.ElementAt(2 + offset),
                    firstName = lines.ElementAt(3 + offset),
                    birthday = Convert.ToDateTime(lines.ElementAt(4 + offset)),
                    birthPlace = lines.ElementAt(5 + offset),
                    gender = lines.ElementAt(6 + offset),
                    active = activeStatus
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
                    fileStream.WriteLine(entry.lastName_A.Trim());
                    fileStream.WriteLine(entry.lastName_B.Trim());
                    fileStream.WriteLine(entry.firstName.Trim());
                    fileStream.WriteLine(entry.birthday.Date);
                    fileStream.WriteLine(entry.birthPlace.Trim());
                    fileStream.WriteLine(entry.gender.Trim());
                    fileStream.Write(entry.active.ToString());
                }
            }
        }

        static void PrintEntries(List<Entry> entries)
        {
            Console.WriteLine("\tID\t|\tApellido Paterno\t|\tApellido Materno\t|\tNombre\t|\tFecha de Nacimiento\t|\tLugar de Nacimiento\t|\tGénero\t|\tEstatus\t");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}", entry.ID, entry.lastName_A, entry.lastName_B, entry.firstName, entry.birthday.Date, entry.birthPlace, entry.gender, entry.active.ToString());
            }
        }

        static void Main(string[] args)
        {
            string file = Path.Combine(Environment.CurrentDirectory, "datos.txt");
            var entries = new List<Entry>();
            ParseFile(file, entries);
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingersa la opción que deseas:");
                Console.WriteLine("1. Altas");
                Console.WriteLine("2. Bajas");
                Console.WriteLine("3. Cambios");
                var opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AddEntry(entries);
                        break;
                    case 2:
                        DeactivateEntry(entries);
                        break;
                    case 3:
                        ModifyEntry(entries);
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

            Console.WriteLine("Ingresa tu apellido paterno:");
            string lastName_A = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido materno:");
            string lastName_B = Console.ReadLine();

            Console.WriteLine("Ingresa tu nombre:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Ingresa tu fecha de nacimiento: DD/MM/AA");
            string birthday = Console.ReadLine();

            Console.WriteLine("Ingresa tu lugar de nacimiento:");
            string birthPlace = Console.ReadLine();

            Console.WriteLine("Ingresa tu genero:");
            string gender = Console.ReadLine();
            Active active = Active.Activo;

            entries.Add(new Entry()
            {
                lastName_A = lastName_A,
                lastName_B = lastName_B,
                firstName = firstName,
                birthday = Convert.ToDateTime(birthday, new CultureInfo("es-MX", false).DateTimeFormat),
                birthPlace = birthPlace,
                gender = gender,
                active = active
            });
        }

        static void DeactivateEntry(List<Entry> entries)
        {
            Console.Clear();
            Console.WriteLine(" Bajas ");
            Console.WriteLine("-------");

            PrintEntries(entries);

            Console.WriteLine("Ingresa el ID del registro a dar de baja: ");
            int id = int.Parse(Console.ReadLine());
            entries[id].active = Active.Inactivo;
        }

        static void ModifyEntry(List<Entry> entries)
        {
            Console.Clear();
            Console.WriteLine(" Cambios ");
            Console.WriteLine("---------");

            PrintEntries(entries);

            Console.WriteLine("Ingresa el ID del registro a modificar: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona la opción a modificar: ");
            Console.WriteLine("1. Apelllido Paterno");
            Console.WriteLine("2. Apelllido Materno");
            Console.WriteLine("3. Nombre");
            Console.WriteLine("4. Fecha Nacimiento");
            Console.WriteLine("5. Entidad de nacimiento");
            Console.WriteLine("6. Genero");
            byte opcionModificar = byte.Parse(Console.ReadLine());

            switch (opcionModificar)
            {
                case 1:
                    Console.WriteLine("Ingresa el nuevo apellido paterno:");
                    entries[id].lastName_A = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ingresa el nuevo apellido materno:");
                    entries[id].lastName_B = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Ingresa el nuevo nombre:");
                    entries[id].firstName = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Ingresa la fecha de nacimiento:");
                    entries[id].birthday = Convert.ToDateTime(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Ingresa la entidad de nacimiento:");
                    entries[id].birthPlace = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Ingresa el genero:");
                    entries[id].gender = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
