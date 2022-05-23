using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutaCritica
{
    internal class Nodo
    {
        private string nombre;
        private float duracion;
        private List<Nodo> predecesores = new();
        private List<Nodo> sucecesores = new();

        public Nodo(string nombre, float duracion) {
            this.nombre = nombre;
            this.duracion = duracion;
        }

        public void AgregarPredecesor(Nodo nodo) {
            predecesores.Add(nodo);
        }

        public void AgregarSucesor(Nodo nodo)
        {
            sucecesores.Add(nodo);
        }

        public string GetNombre() {
            return nombre;
        }

        public float GetDuracion()
        {
            return duracion;
        }

        public List<Nodo> GetPredecesores()
        {
            return predecesores;
        }

        public List<Nodo> GetSucesores()
        {
            return sucecesores;
        }

        public override string ToString()
        {
            string str = "Nodo " + nombre;
            str += "\nDuracion: " + duracion;
            str += "\nPredecesores: ";

            foreach (var predecesor in predecesores)
            {
                str += predecesor.GetNombre() + ", ";
            }

            str = str.Substring(0, str.Length - 2);

            return str + "\n";
        }
    }
}
