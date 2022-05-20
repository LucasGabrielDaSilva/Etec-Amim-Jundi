using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            imagem1.Image.Dispose();
            imagem1.Image = null;
            imagem2.Image.Dispose();
            imagem2.Image = null;
            imagem3.Image.Dispose();
            imagem3.Image = null;
            txtN.Clear();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                MessageBox.Show("Opção Inválida");
            }

            else
            {
                int mes;

                mes = int.Parse(txtN.Text);


                switch (mes)
                {
                    case 1:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Janeiro\\abacaxi.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Janeiro\\alface.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Janeiro\\beringela.jpg");
                            MessageBox.Show("Uma outra opção seria: Carambola, Abobrinha e salsa.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 2:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Fevereiro\\escarola.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Fevereiro\\maracuja.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Fevereiro\\quiabo.jpg");
                            MessageBox.Show("Uma outra opção seria:Banana, Louro e Berinjela.\nPara mais informações consulte um especialista.");
                            break;
                        }

                    case 3:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Março\\catalonha.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Março\\pimenta.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Março\\tangerinacravo.jpg");
                            MessageBox.Show("Uma outra opção seria:Abóbora, ameixa e pimentão.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 4:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Abril\\almeirao.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Abril\\chuchu.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Abril\\kiwi.jpg");
                            MessageBox.Show("Uma outra opção seria:Abacate, inhame  e escarola.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 5:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Maio\\alho.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Maio\\espinafre.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Maio\\pera.jpg");
                            MessageBox.Show("Uma outra opção seria:Pera, almeirão  e mandioca.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 6:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Junho\\mandioca.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Junhp\\pinhao.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Junho\\salsinha.jpg");
                            MessageBox.Show("Uma outra opção seria:Limão, batata-doce  e gengibre.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 7:
                        {

                            imagem1.Image = Image.FromFile("D:\\Lucas\\Julho\\couve.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Julho\\morango.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Julho\\nabo.jpg");
                            MessageBox.Show("Uma outra opção seria:Mexerica, agrião e pepino.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 8:
                        {

                            imagem1.Image = Image.FromFile("D:\\Lucas\\Agosto\\brocolis.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Agosto\\jilo.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Agosto\\tamarindo.jpg");
                            MessageBox.Show("Uma outra opção seria:Maracujá, espinafre e couve.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 9:
                        {
                            imagem1.Image = Image.FromFile("D:\\Lucas\\Setembro\\brocolis.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Setembro\\jilo.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Setembro\\tamarindo.jpg");
                            MessageBox.Show("Uma outra opção seria:Abacaxi, erva-doce e pimentão-vermelho.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 10:
                        {

                            imagem1.Image = Image.FromFile("D:\\Lucas\\Outubro\\mamao.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Outubro\\Repolho.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Outubro\\Vagem.jpg");
                            MessageBox.Show("Uma outra opção seria:Cajú, fava e rabanete.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 11:
                        {

                            imagem1.Image = Image.FromFile("D:\\Lucas\\Novembro\\alho_poro.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Novembro\\Aspargos.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Novembro\\maça.jpg");
                            MessageBox.Show("Uma outra opção seria:Abacate, cenoura e almeirão.\nPara mais informações consulte um especialista.");
                            break;
                        }
                    case 12:
                        {

                            imagem1.Image = Image.FromFile("D:\\Lucas\\Dezembro\\ameixa.jpg");
                            imagem2.Image = Image.FromFile("D:\\Lucas\\Dezembro\\Cogumelos.jpg");
                            imagem3.Image = Image.FromFile("D:\\Lucas\\Dezembro\\salsao.jpg");
                            MessageBox.Show("Uma outra opção seria:Cereja, beterraba e rúcula.\nPara mais informações consulte um especialista.");
                            break;
                        }

                    default:
                        {

                            MessageBox.Show("Digite um numero correto");
                            break;
                        }
                }
            }
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
    }
}