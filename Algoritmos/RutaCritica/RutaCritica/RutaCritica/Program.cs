using System;
using System.Collections.Generic;
using System.Linq;

namespace RutaCritica
{
    internal class Program
    {
        static Dictionary<string, Nodo> nodos = new();
        static List<Ruta> rutas = new();
        static Dictionary<Ruta, float> rutasOrdenadas = new();
        static readonly Nodo nodoInicial = new Nodo("Inicio", 0);
        static readonly Nodo nodoFinal = new Nodo("Final", 0);

        static void Main(string[] args)
        {
            Console.WriteLine("Dame la cantidad de nodos");
            var numNodos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numNodos; i++)
            {
                Console.WriteLine("Dame el nombre del nodo " + (i + 1));
                var nombreNodo = Console.ReadLine();
                i += GenerarNodo(nombreNodo);
            }

            GenerarNodoFinal();
            GenerarRutas();
            CalcularDuracion();
        }

        static int GenerarNodo(string nombreNodo, bool inicial = false) {
            int nodoRecursivo = 0;
            Console.WriteLine("Dame la duración del nodo " + nombreNodo);
            var duracionNodo = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame el o los predecesores del nodo " + nombreNodo + " separados por comas. Enter para predecesor vacio");
            var predecesorNodo = Console.ReadLine();

            nodos[nombreNodo] = new Nodo(nombreNodo, duracionNodo);
            predecesorNodo.Replace(" ", "");
            var predecesoresNodo = predecesorNodo.Split(",");

            if (predecesoresNodo.Length == 0 || inicial) {
                nodos[nombreNodo].AgregarPredecesor(nodoInicial);
            }
            
            foreach (var predecesor in predecesoresNodo)
            {
                if (predecesor == "" || predecesor == "*")
                {
                    nodos[nombreNodo].AgregarPredecesor(nodoInicial);
                    nodoInicial.AgregarSucesor(nodos[nombreNodo]);
                    continue;
                }
                else if (predecesor == nombreNodo)
                {
                    continue;
                }
                
                if (!nodos.ContainsKey(predecesor))
                {
                    Console.WriteLine("No existe el nodo " + predecesor + ". Quieres crearlo? (S/N)");
                    var crearNuevoNodo = Console.ReadLine();

                    if (crearNuevoNodo.ToLower() == "s") {
                        nodoRecursivo ++;
                        nodoRecursivo += GenerarNodo(predecesor);
                    }
                }

                nodos[nombreNodo].AgregarPredecesor(nodos[predecesor]);
                nodos[predecesor].AgregarSucesor(nodos[nombreNodo]);
            }

            return nodoRecursivo;
        }

        static void GenerarNodoFinal()
        {
            string nombreNodo = "Final";
            Console.WriteLine("Dame el o los predecesores del nodo final separados por comas. Enter para autogenerado");
            var predecesorNodo = Console.ReadLine();

            nodos[nombreNodo] = nodoFinal;
            predecesorNodo.Replace(" ", "");
            var predecesoresNodo = predecesorNodo.Split(",");

            foreach (var predecesor in predecesoresNodo)
            {
                if (predecesor == nombreNodo || !nodos.ContainsKey(predecesor)) continue;

                nodos[nombreNodo].AgregarPredecesor(nodos[predecesor]);
                nodos[predecesor].AgregarSucesor(nodos[nombreNodo]);
            }
        }

        static void GenerarRutas() {
            foreach (Nodo nodo in nodoInicial.GetSucesores())
            {
                SiguientePaso(nodo, new Ruta());
            }
        }

        static void SiguientePaso(Nodo nodo, Ruta rutaActual) {
            if (nodo.GetSucesores().Count == 0)
            {
                rutaActual.AgregarNodo(nodo);
                rutas.Add(rutaActual);
                return;
            }
            else if (nodo == nodoFinal)
            {
                rutas.Add(rutaActual);
                return;
            }

            foreach (Nodo sucesor in nodo.GetSucesores())
            {
                if (rutaActual.GetRuta().Contains(sucesor)) continue;

                Ruta ruta = new Ruta(new List<Nodo>(rutaActual.GetRuta().ToArray()));
                ruta.AgregarNodo(nodo);
                SiguientePaso(sucesor, ruta);
            }
        }

        static void CalcularDuracion()
        {
            Console.WriteLine();

            foreach (Ruta ruta in rutas)
            {
                float duracion = ruta.CalcularDuracion();
                rutasOrdenadas[ruta] = duracion;
            }

            var _rutasOrdenadas = rutasOrdenadas.OrderByDescending(key => key.Value);
            foreach (KeyValuePair<Ruta, float> ruta in _rutasOrdenadas)
            {
                Console.WriteLine(ruta.Key.ToString());
            }
        }
    }
}
