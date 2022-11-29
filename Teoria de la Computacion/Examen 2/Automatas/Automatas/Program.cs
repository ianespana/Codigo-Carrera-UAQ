namespace Automatas
{
    class Node
    {
        string id = ""; // ID del nodo
        bool isFinal = false; // Es nodo final?
        Dictionary<string, Node> links = new(); // Nodos vinculados (transiciones)

        public Node() {}

        public Node(string id)
        {
            this.id = id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetIsFinal(bool isFinal)
        {
            this.isFinal = isFinal;
        }

        public void SetLinks(Dictionary<string, Node> links)
        {
            this.links = links;
        }

        public void SetLink(string id, Node link)
        {
            links[id] = link;
        }

        public string GetId()
        {
            return id;
        }

        public bool GetIsFinal()
        {
            return isFinal;
        }

        public Dictionary<string, Node> GetLinks()
        {
            return links;
        }

        public Node GetLink(string id)
        {
            return links[id];
        }

        /// <summary>
        /// Revisa si una palabra es válida para este nodo de manera recursiva.
        /// Separa la primer letra de la palabra para revisar si es válida para este nodo.
        /// Si es válida y aún hay letras, llama la función CheckWord para el siguiente nodo.
        /// Si es válida y ya no hay letras, devuelve verdadero.
        /// Si no es válida devuelve falso.
        /// </summary>
        public bool CheckWord(string word) {
            if (word == "")
            {
                Console.WriteLine("\n" + id);
                return isFinal;
            } else if (!links.ContainsKey(word[..1])) {
                Console.WriteLine("\n" + id + "\t\t\t" + word[..1]);
                return false;
            }

            Node next = links[word[..1]];
            Console.WriteLine("\n" + id + "\t\t\t" + word[..1] + "\t\t\t" + next.GetId());

            word = word[1..];

            return next.CheckWord(word);
        }
    }

    internal class Program
    {
        static Dictionary<string, Node> nodes = new();
        static Node first = new();
        static List<string> alphabet = new();

        static void ProcessLineValues(int lineNum, string[] values)
        {
            switch (lineNum)
            {
                case 0: // Primera fila. Nodos
                    if (values == null || values.FirstOrDefault() == null)
                        throw new Exception("Error al validar datos. Los nodos son inválidos.");

                    foreach (string id in values)
                    {
                        nodes[id] = new Node(id);
                    }
                    break;
                case 1:  // Segunda fila. Alfabeto
                    if (values == null || values.FirstOrDefault() == null)
                        throw new Exception("Error al validar datos. El alfabeto es inválido.");

                    foreach (string letter in values)
                    {
                        alphabet.Add(letter);
                    }
                    break;
                case 2: // Tercer fila. Nodo inicial
                    if (values == null || values.FirstOrDefault() == null || nodes[values.FirstOrDefault()] == null)
                        throw new Exception("Error al validar datos. El nodo inicial es inválido.");

                    first = nodes[values.FirstOrDefault()];
                    break;
                case 3: // Cuarta fila. Nodos finales
                    if (values == null || values.FirstOrDefault() == null)
                        throw new Exception("Error al validar datos. Los nodos finales son inválidos.");

                    foreach (string letter in values)
                    {
                        if (letter == null || nodes[letter] == null)
                        {
                            Console.WriteLine("El nodo '" + letter + "' no existe, excluyendolo de los nodos finales.");
                            continue;
                        }

                        nodes[letter].SetIsFinal(true);
                    }
                    break;
                default: // Quinta fila en adelante. Funciones de transición
                    if (values == null || values.FirstOrDefault() == null || nodes[values.FirstOrDefault()] == null || values.Length != alphabet.Count + 1)
                        throw new Exception("Error al validar datos. Las relaciones entre nodos son inválidas.");

                    for (int i = 0; i < alphabet.Count; i++)
                    {
                        if (values[i + 1] == null || nodes[values[i + 1]] == null)
                            throw new Exception("Error al validar datos. Las relaciones entre nodos son inválidas.");

                        nodes[values[0]].SetLink(alphabet[i], nodes[values[i + 1]]);
                    }

                    break;
            }
        }

        static void ParseFile(string file)
        {
            using (var reader = new StreamReader(file))
            {
                int lineNum = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;
                    
                    var values = line.Split(' ');
                    ProcessLineValues(lineNum, values);

                    lineNum++;
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ParseFile(@".\afd.txt");
                Console.WriteLine("¿Cuántas palabras tiene el conjunto?");
                int.TryParse(Console.ReadLine(), out int wordNum);
                List<string> words = new();

                for (int i = 0; i < wordNum; i++)
                {
                    Console.WriteLine("Dame la palabra " + i);
                    words.Add(Console.ReadLine());
                }

                foreach (string word in words)
                {
                    Console.WriteLine("\n\nPalabra w = " + word);
                    Console.WriteLine("\nEstado Actual\t\tCaracter Leido\t\tEstado Siguiente");

                    bool valid = first.CheckWord(word);
                    if (valid) Console.WriteLine("\nPalabra w = " + word + " ACEPTADA");
                    else Console.WriteLine("\nPalabra w = " + word + " RECHAZADA");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}