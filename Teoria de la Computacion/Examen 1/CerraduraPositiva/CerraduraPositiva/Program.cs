namespace CerraduraPositiva
{
    internal class Program
    {
        static string alphabet = "";
        static int wordSize = 0;
        static List<string> language = new();

        static void Concat(string oldString)
        {
            Console.WriteLine("\t" + oldString);
            language.Add(oldString);
            if (oldString.Length >= wordSize)
            {
                return;
            }

            foreach (char letter in alphabet)
            {
                Concat(oldString + letter);
            }
        }

        static void Main(string[] args)
        {
            alphabet = "";
            wordSize = 0;

            Console.WriteLine("Dame el alfabeto:");
            alphabet = Console.ReadLine();

            Console.WriteLine("Dame la longitud máxima de las palabras:");
            wordSize = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nLenguaje con palabras de longitud 0 a " + alphabet.Length + ":\n");
            Console.WriteLine("\tNULL");

            for (int i = 0; i < alphabet.Length; i++)
            {
                Concat(alphabet[i].ToString());
            }

            Console.WriteLine("\n\nPalabras del lenguaje con una cantidad par de símbolos:\n");
            Console.WriteLine("\tNULL");

            foreach (string word in language)
            {
                Dictionary<char, int> simbolCount = new();
                foreach (char letter in word)
                {
                    if (simbolCount.ContainsKey(letter))
                    {
                        simbolCount[letter]++;
                    }
                    else
                    {
                        simbolCount[letter] = 1;
                    }
                }

                bool even = true;
                foreach(KeyValuePair<char, int> pair in simbolCount)
                {
                    if (pair.Value % 2 == 1)
                    {
                        even = false;
                        break;
                    }
                }

                if (even) Console.WriteLine("\t" + word);
            }
        }
    }
}