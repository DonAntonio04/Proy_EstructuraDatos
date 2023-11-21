using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_EstructuraDatos
{
    public class Nodo
    {
        private string nombreCancion;
        private string Interprete;
        private string Duracion;
        private string Genero;
        private Nodo _Siguiente;

        public Nodo(string nombreCancion, string interprete, string duracion, string genero)
        {
            this.nombreCancion = nombreCancion;
            Interprete = interprete;
            Duracion = duracion;
            Genero = genero;        
        }

        public Nodo(string nombreCancion, string interprete, string duracion, string genero, Nodo siguiente)
        {
            this.nombreCancion = nombreCancion;
            Interprete = interprete;
            Duracion = duracion;
            Genero = genero;
            _Siguiente = siguiente;
        }

        public string getDatos()
        {
            return $"{nombreCancion} , {Interprete} , {Duracion} ,{Genero}";
        }

        public string getCancion()
        {
            return nombreCancion;
        }

        public Nodo getSiguente()
        {
            return _Siguiente ;
        }

        public void setSiguiente(Nodo siguiente)
        {
            _Siguiente = siguiente;
        }
    }
}
