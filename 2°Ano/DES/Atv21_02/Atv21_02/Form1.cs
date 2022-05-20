using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atv21_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtS.Text == "")
            {
                MessageBox.Show(" Digite as Informações nescessarias!");
            }

            else
            {
                int dia;

                dia = Int32.Parse(txtS.Text);
            

                switch (dia)
                {
                    case 1:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\segunda.jpg");
                            MessageBox.Show("Ingês-Elaine\n DES- Cristiane\n Biologia- Luciana\n DES- Cristiane\n Geografia-Everton\n PWEB- Rosiane");
                            break;
                        }
                    case 2:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\terca.jpg");
                            MessageBox.Show("HIS- Claudio\n ECO- Jaine\n Inglês- Elaine\n FIS- Leonardo\n QUI- Adriana B.\n EDF- Paula");
                            break;
                        }
                    case 3:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\quarta.gif");
                            MessageBox.Show("MAT- Marinaldo\n MAT- Marinaldo\n QUI- Adriana B.\n PAM- Adriana T.\n DES- Cristiane\n FIS- Leonardo");
                            break;
                        }
                    case 4:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\quinta.jpeg");
                            MessageBox.Show("HIS- Claudio\n LP-Elaine\n LP- Elaine\n EDF- Paula\n PAM- Adriana T.\n PWEB- Rosiane");
                            break;
                        }
                    case 5:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\sexta;jpg");
                            MessageBox.Show("BIO- Luciana\n MAT- Marinaldo\n LP- Elaine\n BDA- Cristiane\n BDA- Cristiane\n GEO- Everton");
                            break;
                        }
                    case 6:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\sabado.jpg");
                            break;
                        }
                    case 7:
                        {
                            picI.Image = Image.FromFile("F:\\Etec Amim Jundi\\2°Ano\\DES\\Semana\\domingo.jpg");
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

        private void txtS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <='9' || e.KeyChar== 8)
            {
            e.Handled= false;
            }

            else 
            {
            e.Handled= true;
            }

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtS.Clear();
            picI.Image.Dispose();
            picI.Image = null;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
