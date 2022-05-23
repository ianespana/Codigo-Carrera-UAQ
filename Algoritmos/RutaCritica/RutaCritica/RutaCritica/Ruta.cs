using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutaCritica
{
    internal class Ruta
    {
        List<Nodo> ruta;
        float duracion = 0;

        public Ruta(List<Nodo> ruta) { 
            this.ruta = ruta;
        }

        public Ruta()
        {
            ruta = new();
        }

        public float CalcularDuracion() {
            float duracion = 0;

            foreach (Nodo nodo in ruta) {
                duracion += nodo.GetDuracion();
            }

            this.duracion = duracion;
            return duracion;
        }

        public void AgregarNodo(Nodo nodo) {
            ruta.Add(nodo);
        }

        public List<Nodo> GetRuta() {
            return ruta;
        }

        public override string ToString()
        {
            string str = "------------ RUTA [Duracion: " + duracion + "] ---------------\n";
            string nodos = "";

            foreach (var nodo in ruta)
            {
                str += nodo.GetNombre() + ", ";
                nodos += nodo.ToString() + "\n";
            }

            str = str.Substring(0, str.Length - 2);
            str += "\n\n";
            return str + nodos;
        }
    }
}
