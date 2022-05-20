using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mensagem
{
    public partial class atvd : Form
    {
        public atvd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!\nEstou de volta em outra plataforma!!\n\nCriador:Lucas Gabriel");
        }

        private void bntfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
