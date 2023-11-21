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
    public partial class FormListas : Form
    {
        Listas listas = new Listas();
        public FormListas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listas.InsertarElemento(txtCancion.Text, txtDuracion.Text, txtGenero.Text, txtInterprete.Text);
            MessageBox.Show("Se guardo con exito");
            Limpiar();
        }

        private void Limpiar()
        {
            txtCancion.Text = "";
            txtDuracion.Text = "";
            txtGenero.Text = "";
            txtInterprete.Text = "";
        }

        private void btnGuardarList_Click(object sender, EventArgs e)
        {
            pnlGuardar.Visible = true;
            pnlMostrar.Visible = false;
        }

        private void btnMostrarList_Click(object sender, EventArgs e)
        {
            pnlGuardar.Visible = false;
            pnlMostrar.Visible = true;

            gridCaciones.Columns.Add("nombreCancion", "Cancion");
            gridCaciones.Columns.Add("Interprete", "Interprete");
            gridCaciones.Columns.Add("Duracion", "Duracion");
            gridCaciones.Columns.Add("Genero", "Genero");
           

            gridCaciones.Rows.Add("Agustin", "Ramos", "Mexico", "psis@gmail.com");



        }
    }
}
