namespace Generador_de_tablas_de_verdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero = (int)nupCantidadVariables.Value;
            Generador formularioExpresion = new Generador(numero);
            formularioExpresion.Show();
            this.Hide();
        }

        private void ibSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
