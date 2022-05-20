using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtValor2.Clear();
            txtValor1.Clear();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double v1, v2, total;

            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            total = v1 + v2;
            txtTotal.Text = total.ToString();
        }
    }
}
