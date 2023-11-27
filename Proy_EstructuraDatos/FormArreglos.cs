using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_EstructuraDatos
{
    public partial class FormArreglos : Form
    {
        public FormArreglos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private string[] nombresCanciones = new string[100]; //  un límite de 100 canciones
        private string[] interpretes = new string[100];
        private double?[] duraciones = new double?[100];
        private string[] generos = new string[100];
        private int totalCanciones = 0;


        private void GuardarCancion(string nombre, string interprete, double duracion, string genero)
        {
            // Verifica si hay espacio disponible en los arreglos
            if (totalCanciones < nombresCanciones.Length)
            {
                // Guarda los datos en los arreglos
                nombresCanciones[totalCanciones] = nombre;
                interpretes[totalCanciones] = interprete;
                duraciones[totalCanciones] = duracion; // Aquí, duración sigue siendo un string
                generos[totalCanciones] = genero;

                // Incrementa el contador de canciones
                totalCanciones++;

                // Puedes mostrar un mensaje de éxito si es necesario
                MessageBox.Show("Canción guardada exitosamente.", "Guardar Canción");
            }
            else
            {
                MessageBox.Show("No hay espacio disponible para más canciones.", "Guardar Canción");
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
            // Aquí puedes obtener los datos de la canción desde tus cuadros de texto u otros controles
            string nombre = txtNombreCancion.Text;
            string interprete = txtInterprete.Text;
            double duracion = double.Parse (txtDuracion.Text);
            string genero = txtGenero.Text;

            // Llama al método GuardarCancion
            GuardarCancion(nombre, interprete, duracion, genero);

            //Form1 form1 = new Form1();
            //form1.ShowDialog();
        }
     
        private bool EliminarCancion(string nombreCancion, string interprete, double duracion, string genero)
        {
            int indiceCancion = -1;

            // Busca el índice de la canción a eliminar
            for (int i = 0; i < totalCanciones; i++)
            {
                if (nombresCanciones[i] == nombreCancion)
                {
                    indiceCancion = i;
                    break;
                }
            }

            if (indiceCancion != -1)
            {
                // "Elimina" la canción estableciendo sus valores a null (o cualquier valor que indique eliminación)
                nombresCanciones[indiceCancion] = null;
                interpretes[indiceCancion] = null;
                duraciones[indiceCancion] = null;
                generos[indiceCancion] = null;

                // Decrementa el contador de canciones
                totalCanciones--;

                // Indica que la canción se eliminó correctamente
                return true;
            }

            // Indica que la canción no se encontró
            return false;

        }

        private void btnEliminarArr_Click(object sender, EventArgs e)
        {
            string nombreCancion = txtNombreCancion.Text;
            string interprete = txtInterprete.Text;
            double duracion = double.Parse(txtDuracion.Text);
            string genero = txtGenero.Text;

            // Llama al método EliminarCancion con los valores adecuados
            bool cancionEliminada = EliminarCancion(nombreCancion, interprete, duracion, genero);

            // Proporciona retroalimentación al usuario según el resultado
            if (cancionEliminada)
            {
                MessageBox.Show("¡Canción eliminada correctamente!");
            }
            else
            {
                MessageBox.Show("Canción no encontrada o ocurrió un error al eliminar.");
            }
        }
        private bool EditarCancion(string nombreCancion, string nuevoInterprete, double nuevaDuracion, string nuevoGenero)
        {
            // Busca la canción por su nombre
            for (int i = 0; i < totalCanciones; i++)
            {
                if (nombresCanciones[i] == nombreCancion)
                {
                    // Edita la información de la canción
                    interpretes[i] = nuevoInterprete;
                    duraciones[i] = nuevaDuracion;
                    generos[i] = nuevoGenero;

                    // Indica que la canción se editó correctamente
                    return true;
                }
            }

            // Indica que la canción no se encontró
            return false;
        }
        private void btnEditarArr_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los cuadros de texto
            string nombreCancion = txtNombreCancion.Text;
            string nuevoInterprete = txtInterprete.Text;
            double nuevaDuracion = double.Parse(txtDuracion.Text);
            string nuevoGenero = txtGenero.Text;

            // Llama al método EditarCancion con los valores adecuados
            bool cancionEditada = EditarCancion(nombreCancion, nuevoInterprete, nuevaDuracion, nuevoGenero);

            // Proporciona retroalimentación al usuario según el resultado
            if (cancionEditada)
            {
                MessageBox.Show("¡Canción editada correctamente!");
            }
            else
            {
                MessageBox.Show("Canción no encontrada o ocurrió un error al editar.");
            }

        }
        private void MostrarCanciones()
        {
            // Verifica si hay canciones almacenadas
            if (totalCanciones > 0)
            {
                // Construye un mensaje con la información de todas las canciones
                StringBuilder mensaje = new StringBuilder("Lista de Canciones:\n");

                for (int i = 0; i < totalCanciones; i++)
                {
                    mensaje.AppendLine($"Canción: {nombresCanciones[i]}, Intérprete: {interpretes[i]}, Duración: {duraciones[i]}, Género: {generos[i]}");
                }

                // Muestra el mensaje en un cuadro de diálogo o en cualquier otro lugar que desees
                MessageBox.Show(mensaje.ToString(), "Canciones Guardadas");
            }
            else
            {
                MessageBox.Show("No hay canciones almacenadas.", "Canciones guardadas");
            }
        }


        private void btnMostrarArr_Click(object sender, EventArgs e)
        {
            MostrarCanciones();
        }

        private void OrdenarCanciones()
        {
            // Verifica si hay canciones almacenadas
            if (totalCanciones > 1)
            {
                // Implementa un simple algoritmo de ordenación (por ejemplo, método de burbuja)
                for (int i = 0; i < totalCanciones - 1; i++)
                {
                    for (int j = 0; j < totalCanciones - 1 - i; j++)
                    {
                        // Convierte las duraciones a enteros para comparar
                        double duracionA = double.Parse(duraciones[j].ToString());
                        double duracionB = double.Parse(duraciones[j + 1].ToString());

                        // Compara las duraciones y realiza el intercambio si es necesario
                        if (duracionA > duracionB)
                        {
                            // Intercambia los valores directamente
                            string tempNombre = nombresCanciones[j];
                            nombresCanciones[j] = nombresCanciones[j + 1];
                            nombresCanciones[j + 1] = tempNombre;

                            string tempInterprete = interpretes[j];
                            interpretes[j] = interpretes[j + 1];
                            interpretes[j + 1] = tempInterprete;

                            double? tempDuracion = duraciones[j];
                            duraciones[j] = duraciones[j + 1];
                            duraciones[j + 1] = tempDuracion;

                            string tempGenero = generos[j];
                            generos[j] = generos[j + 1];
                            generos[j + 1] = tempGenero;
                        }
                    }
                }

                MessageBox.Show("Canciones ordenadas por duración.", "Ordenar Canciones");
            }
            else
            {
                MessageBox.Show("No hay suficientes canciones para ordenar.", "Ordenar Canciones");
            }
        }

        private void btnOrdenarArr_Click(object sender, EventArgs e)
        {
            // Llama al método OrdenarCanciones
            OrdenarCanciones();
        }
        private void BuscarCancion(string nombreABuscar)
        {
            bool encontrada = false;

            // Verifica si hay canciones almacenadas
            if (totalCanciones > 0)
            {
                // Busca la canción por nombre
                for (int i = 0; i < totalCanciones; i++)
                {
                    if (nombresCanciones[i].Equals(nombreABuscar, StringComparison.CurrentCultureIgnoreCase))
                    {
                        // Muestra información de la canción encontrada
                        MessageBox.Show($"Canción encontrada:\n\nNombre: {nombresCanciones[i]}\nIntérprete: {interpretes[i]}\nDuración: {duraciones[i]}\nGénero: {generos[i]}", "Buscar Canción");
                        encontrada = true;
                        break; // Termina la búsqueda una vez encontrada la canción
                    }
                }

                if (!encontrada)
                {
                    MessageBox.Show($"La canción '{nombreABuscar}' no fue encontrada.", "Buscar Canción");
                }
            }
            else
            {
                MessageBox.Show("No hay canciones almacenadas para buscar.", "Buscar Canción");
            }
        }

        private void btnBuscarArr_Click(object sender, EventArgs e)
        {
            // Aquí puedes obtener el nombre de la canción a buscar, por ejemplo, desde un cuadro de texto.
            string nombreABuscar = txtNombreCancion.Text;

            // Llama al método BuscarCancion
            BuscarCancion(nombreABuscar);
        }
    }
}
