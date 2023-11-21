using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_EstructuraDatos
{
    public class Listas
    {
        Nodo primero;
        Nodo ultimo;

        public Listas()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }

        public void InsertarElemento(string nombreCancion, string interprete, string duracion, string genero)
        {
            if (ListaVacia())
            {
                primero = new Nodo(nombreCancion, interprete,duracion, genero);
            }
            else
            {
                primero = new Nodo(nombreCancion, interprete, duracion, genero, primero);
            }

        }

        public void InsertarMedio(string nombreCancion, string interprete, string duracion, string genero)
        {
            if (ListaVacia())
            {
                primero = new Nodo(nombreCancion, interprete, duracion, genero, primero);
            }
            else
            {
                Nodo anterior = null;
                int iterador = 1;
                int longitud = LongitudLista();
                Nodo actual = primero;
                Console.WriteLine(longitud);
                while (actual.getSiguente() != null && iterador < longitud / 2)
                {
                    actual = actual.getSiguente();
                    iterador++;
                }
                Console.WriteLine(actual.getDatos());
                anterior = actual;
                Nodo nuevo = new Nodo(nombreCancion, interprete, duracion, genero, actual.getSiguente());
                anterior.setSiguiente(nuevo);
            }
        }

        public int LongitudLista()
        {
            int contador = 0;
            if (ListaVacia())
            {
                return contador;
            }
            else
            {
                Nodo actual = primero;
                if (actual.getSiguente() == null)
                {
                    return (contador + 1);
                }
                else
                {

                    while (actual.getSiguente() != null)
                    {
                        contador++;
                        actual = actual.getSiguente();
                    }
                    return contador + 1;
                }
            }
        }

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"Los datos son {actual.getDatos()}");
                    actual = actual.getSiguente();
                }
                Console.WriteLine("--> null");

            }
        }

        public void BuscarCancion(string nombreCancion)
        {
            bool encontrado = false;
            if (ListaVacia())
            {
                Console.WriteLine("El nombre solicitado no se encuentra");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.getDatos() == nombreCancion)
                    {
                        Console.WriteLine("Si se encuentra el elemento deseado");
                        encontrado = true;
                    }
                    else
                    {
                        actual = actual.getSiguente();
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }

        public int BuscarPosicion(string cancion)
        {
            int cont = 0;
            //checar primero si la lista esta vacia o si hay elementos 
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    cont++;

                    if (actual.getCancion() == cancion)
                    {
                        cont++;
                    }
                    else
                    {
                        actual = actual.getSiguente();
                    }
                }   
            }
            return cont;
        }

    }
}
