namespace Proy_EstructuraDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormArreglos formArreglos = new FormArreglos();
            formArreglos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListas formListas = new FormListas();
            formListas.ShowDialog();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            FormPilas formPilas = new FormPilas();
            formPilas.ShowDialog();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            FormColas formColas = new FormColas();
            formColas.ShowDialog();
        }
    }
}