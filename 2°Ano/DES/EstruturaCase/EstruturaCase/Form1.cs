using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstruturaCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '3' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtProf.Clear();
            txtReaj.Clear();
            txtSalario.Clear();
            txtNome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNome.Text + "\n Até breve!!");
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNome.Text + "\n Até breve!!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo;
            double salario, reajsal;

            if (txtCodigo.Text == "" || txtSalario.Text == "" || txtNome.Text =="")
            {
                MessageBox.Show(txtNome.Text + ": Digite as Informações nescessarias!");
            }
            
            else
            {


                codigo = Int32.Parse(txtCodigo.Text);
                salario = double.Parse(txtSalario.Text);

                switch (codigo)
                {
                    case 1:
                        {
                            txtProf.Text = ("ANALISTA DE SISTEMAS");
                            reajsal = salario * 1.15;
                            txtReaj.Text = reajsal.ToString("C2");
                            break;
                        }
                    case 2:
                        {

                            txtProf.Text = ("PROGRAMADOR");
                            reajsal = salario * 1.20;
                            txtReaj.Text = reajsal.ToString("C2");
                            break;
                        }

                    case 3:
                        {
                            txtProf.Text = ("DESIGNER GRÁFICO");
                            reajsal = salario * 1.05;
                            txtReaj.Text = reajsal.ToString();
                            break;
                        }

                    default:
                        {
                            MessageBox.Show("Opção Inválida");
                            break;
                        }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá de novo!! Seja Bem-Vindo!!Aguarde enquanto iniciamos...");
        }
    }

}