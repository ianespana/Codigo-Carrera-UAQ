namespace Palindrome
{
    internal class Program
    {
        static string Reverse(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static bool IsPalindome(string word)
        {
            string reversedWord = Reverse(word);
            return word == reversedWord;
        }

        static bool IsMadeOfAlphabet(string word, string alphabet)
        {
            foreach (char wordLetter in word)
            {
                bool match = false;
                foreach(char alphabetLetter in alphabet)
                {
                    if (wordLetter == alphabetLetter)
                    {
                        match = true;
                        break;
                    }
                }
                
                if (!match) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el alphabeto Σ:");
            string alphabet = Console.ReadLine();

            Console.WriteLine("Ingresa una palabra:");
            string word = Console.ReadLine();

            if (IsPalindome(word))
            {
                Console.WriteLine("La palabra es palindrome");
            }
            else
            {
                Console.WriteLine("La palabra no es palindrome");
            }

            if (IsMadeOfAlphabet(word, alphabet))
            {
                Console.WriteLine("La palabra es parte de Σ*");
            }
            else
            {
                Console.WriteLine("La palabra no es parte de Σ*");
            }
        }
    }
}