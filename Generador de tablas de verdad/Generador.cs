using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generador_de_tablas_de_verdad
{
    public partial class Generador : Form
    {
        private int cantidadVariables;
        public Generador(int cantidad)
        {
            InitializeComponent();
            cantidadVariables = cantidad;
            GenerarBotonesVariables();
            GenerarBotonesFijos();
            dgvTabla.BackgroundColor = ColorTranslator.FromHtml("#fcf7d3"); // color5
            dgvTabla.Font = new Font("Century Gothic", 12);
            dgvTabla.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#fcf7d3");
            dgvTabla.DefaultCellStyle.ForeColor = Color.Black;
            dgvTabla.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5e3929"); // color1
            dgvTabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void GenerarBotonesVariables()
        {
            flpVariables.Controls.Clear(); // Por si acaso
            string[] variables = { "p", "q", "r", "s", "t", "u", "v", "w", "x", "y" };

            for (int i = 1; i <= cantidadVariables; i++)
            {

                Button btnVariable = new Button();
                btnVariable.Text = variables[i-1];
                btnVariable.Width = 90;
                btnVariable.Height = 90;
                btnVariable.Margin = new Padding(10);
                btnVariable.BackColor = ColorTranslator.FromHtml("#cd8c52");
                btnVariable.ForeColor = Color.White;
                btnVariable.Font = new Font("Century Gothic", 14);
                btnVariable.FlatStyle = FlatStyle.Flat;
                btnVariable.Click += Variable_Click;

                flpVariables.Controls.Add(btnVariable);
            }
            CentrarBotones();

        }

        private void Variable_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtExpresion.Text += btn.Text;
        }

        private void GenerarBotonesFijos()
        {
            string[] operadores = { "∧", "∨", "¬", "→", "↔", "(", ")" };

            foreach (string op in operadores)
            {
                Button btn = new Button();
                btn.Text = op;
                btn.Width = 90;
                btn.Height = 90;
                btn.Margin = new Padding(10);
                btn.BackColor = ColorTranslator.FromHtml("#cd8c52");
                btn.ForeColor = Color.White;
                btn.Font = new Font("Century Gothic", 14);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Variable_Click;

                flpOperadores.Controls.Add(btn);
            }
        }
        private void CentrarBotones()
        {
            int totalWidth = 0;

            foreach (Control c in flpVariables.Controls)
            {
                totalWidth += c.Width + c.Margin.Left + c.Margin.Right;
            }

            int espacioExtra = flpVariables.ClientSize.Width - totalWidth;

            if (espacioExtra > 0)
            {
                flpVariables.Padding = new Padding(espacioExtra / 2, 0, 0, 0);
            }
            else
            {
                flpVariables.Padding = new Padding(0);
            }
        }
        private void Generador_Load(object sender, EventArgs e)
        {


        }

        private void gbVariables_Enter(object sender, EventArgs e)
        {

        }



        private void ibSalir_Click(object sender, EventArgs e)
        {
            Form1 formularioExpresion = new Form1();
            formularioExpresion.Show();
            this.Hide();
        }

        private void ibHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = " ";
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text.Trim();

            if (string.IsNullOrEmpty(expresion))
            {
                MessageBox.Show("Por favor ingresa una expresión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidadorExpresion.ParentesisBalanceados(expresion))
            {
                MessageBox.Show("Los paréntesis no están balanceados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            MessageBox.Show("La expresión tiene paréntesis balanceados.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
