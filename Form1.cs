using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);
                double resultado = num1 + num2;
                listBoxResultados.Items.Add($"{num1} + {num2} = {resultado}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);
                double resultado = num1 - num2;
                listBoxResultados.Items.Add($"{num1} - {num2} = {resultado}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            listBoxResultados.Items.Clear();
        }
    }
}
