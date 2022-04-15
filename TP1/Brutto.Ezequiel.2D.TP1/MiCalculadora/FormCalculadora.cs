using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string numeroBinario = resultado.DecimalBinario(lblResultado.Text);
            lblResultado.Text = numeroBinario;
            lstOperaciones.Items.Add(numeroBinario);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string numeroDecimal = resultado.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = numeroDecimal;
            lstOperaciones.Items.Add(numeroDecimal);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Vuelve a iniciar el display por defecto para los campos de ingreso de texto, la etiqueta de resultado
        /// y el selector de operador matemático.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Utiliza sus parámetros para recibir argumentos que instanciará en la clase Operando y, mediante 
        /// el método Operar de la Clase Calculadora, retornará el valor de la operación deseada.
        /// </summary>
        /// <param name="numero1">Recibe como argumento el valor en formato string que se utilizará como 1er operando</param>
        /// <param name="numero2">Recibe como argumento el valor en formato string que se utilizará como 2do operando</param>
        /// <param name="operador">Recibe como argumento un caracter que utillizará como operador entre ambos operandos</param>
        /// <returns>El valor de tipo double devuelto por el método Operar de la clase Calculadora como resultado</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            double resultado;

            resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));
            return resultado;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs formClose)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                formClose.Cancel = true;
            }
        }
    }
}
