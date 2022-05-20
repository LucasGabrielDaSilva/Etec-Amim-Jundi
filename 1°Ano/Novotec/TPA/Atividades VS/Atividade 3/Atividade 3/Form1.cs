using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblnome.Text = "Curso";
            lblsobrenome.Text = "Cidade";
        }

        private void btnmensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvimento de Sistemas");
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleTurquoise;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsobrenome.Clear();
        }
    }
}
