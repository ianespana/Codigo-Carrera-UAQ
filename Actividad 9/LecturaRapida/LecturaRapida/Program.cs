using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LecturaRapida
{
    class Program
    {
        static void ParseFile(string file, List<string> entries)
        {
            var lines = File.ReadLines(file);
            foreach (var line in lines)
            {
                entries.AddRange(line.Split(' '));
            }
        }

        static string[] SplitEqual(string s){
            var length = s.Count();
            int whereToSplit;
            string[] substring = {"", "", ""};

            whereToSplit = length / 3;

            substring[2] = s.Substring(whereToSplit * 2);
            substring[1] = s.Substring(whereToSplit, whereToSplit);
            substring[0] = s.Substring(0, whereToSplit);
            return substring;
        }

        static void DisplayValues(List<string> entries)
        {
            var height = Console.WindowHeight / 2;
            var width = Console.WindowWidth / 2;

            foreach (var entry in entries)
            {
                width -= entry.Count() / 2;
                height--;
                width = width < 0 ? 0 : width;
                height = height < 0 ? 0 : height;

                Console.SetCursorPosition(width, height);
                
                var splitEntry = SplitEqual(entry);
                
                Console.Write(splitEntry[0]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(splitEntry[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(splitEntry[2]);

                System.Threading.Thread.Sleep(entry.Count()*200);
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            string file = Path.Combine(Environment.CurrentDirectory, "texto.txt");
            var entries = new List<string>();
            ParseFile(file, entries);
            DisplayValues(entries); 
        }
    }
}
