using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double salario, atual;

            salario = double.Parse(txtS.Text);

            if (salario >= 2000)
            {

                atual = salario + 500;

            }

            else
            {

                atual = salario + 300;
            
            }

            txtSA.Text = atual.ToString();

           // MessageBox.Show("Bom Dia!");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtS.Clear();
            txtSA.Clear();
        }
    }
}
