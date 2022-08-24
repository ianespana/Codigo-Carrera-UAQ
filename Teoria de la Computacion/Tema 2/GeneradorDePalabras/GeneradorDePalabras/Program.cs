namespace GeneradorDePalabras
{
    internal class Program
    {
        static List<string> alphabet = new();
        static int wordSize = 0;

        static void Concat(string oldString) {
            if (oldString.Length > wordSize)
            {
                return;
            }

            string word = oldString;
            Console.WriteLine(word);
            foreach (string letter in alphabet)
            {
                Concat(word + letter);
            }
        }

        static void Main(string[] args)
        {
            alphabet = new();
            wordSize = 0;

            Console.WriteLine("Dame el numero de letras que hay en el alfabeto:");
            int alphabetSize = int.Parse(Console.ReadLine());

            for (int i = 0; i < alphabetSize; i++) {
                Console.WriteLine("Dame la letra " + (i + 1));
                alphabet.Add(Console.ReadLine());
            }

            Console.WriteLine("Dame la longitud máxima de las palabras:");
            wordSize = int.Parse(Console.ReadLine());
            Console.WriteLine("NULL");

            for (int i = 0; i < alphabet.Count; i++) {
                Concat(alphabet[i]);
            }

            Console.WriteLine("Quieres repetir el programa? (S/N)");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "s") {
                Console.Clear();
                Main(null);
            }
        }
    }
}