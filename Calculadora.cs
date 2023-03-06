using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public double Resultado { get; set; }
        public int NumEsquerda { get; set; }
        public int NumDireita { get; set; }
        public Calculadora()
        {
            InitializeComponent();
            this.Resultado = 0.0;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            this.lblOperacao.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            this.lblOperacao.Text = "-";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            this.lblOperacao.Text = "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            this.lblOperacao.Text = "*";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            NumDireita = ConverteEmInteiro(tbxNumDireita);
            NumEsquerda = ConverteEmInteiro(tbxNumEsquerda);

            switch (this.lblOperacao.Text)
            {
                case "+":
                    this.Resultado += Soma();
                    this.lblResultado.Text = this.Resultado.ToString();
                    break;

                case "-":
                    this.Resultado += Subtracao();
                    this.lblResultado.Text = this.Resultado.ToString();
                    break;

                case "*":
                   
                    this.Resultado += Multiplicacao();
                    this.lblResultado.Text = this.Resultado.ToString();
                    break;

                case "/":
                   
                    this.Resultado += Divisao();
                    this.lblResultado.Text = this.Resultado.ToString();
                    break;

                default:
                    MessageBox.Show("Por Favor, especifique a operação que voce deseja fazer", "Popup Event");
                    break;
            }
        }

        private double Soma()
        {
            return (double)NumEsquerda + NumDireita;
        }
        private double Subtracao()
        {
            return  (double)NumEsquerda - NumDireita;
        }
        private double Divisao()
        {
            return (double)NumEsquerda / NumDireita;
        }
        private double Multiplicacao()
        {
            return (double)NumEsquerda * NumDireita;
        }


        private int ConverteEmInteiro(TextBox campo)
        {
            return campo.Text != "" ? int.Parse(campo.Text) : 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tbxNumEsquerda.Text = "0";
            this.tbxNumDireita.Text = "0";
            this.Resultado = 0;
            this.lblOperacao.Text = "?";
            this.lblResultado.Text = "resultado";
        }

        private void tbxNumEsquerda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = sender.ToString();
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
             
        }

        private void tbxNumDireita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}
