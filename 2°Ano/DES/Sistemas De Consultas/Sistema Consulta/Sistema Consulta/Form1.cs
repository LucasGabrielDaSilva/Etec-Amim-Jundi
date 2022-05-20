using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Consulta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btnl_Click(object sender, EventArgs e)
        {
            txtm.Clear();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
           int mes;

           mes = int.Parse(txtm.Text);

        switch (mes)
            {
            case 1:
            
            {
                MessageBox.Show("Janeiro");
                break;
            }
            case 2:
            {
            
                MessageBox.Show("Feveiro");
                break;
            }
            case 3:
                {
                MessageBox.Show("Março");
                break;
                }
            case 4:
                {
                    MessageBox.Show("Abril");
                    break;
                }
            case 5:
                {
                    MessageBox.Show("Maio");
                    break;
                }
            case 6:
                {
                    MessageBox.Show("Junho");
                    break;
                }
            case 7:
                {
                    MessageBox.Show("Julho");
                    break;
                }
            case 8:
                {
                    MessageBox.Show("Agosto");
                    break;
                }
            case 9:
                {
                    MessageBox.Show("Setembro");
                    break;
                }
            case 10:
                {
                    MessageBox.Show("Outubro");
                    break;
                }
            case 11:
                {
                    MessageBox.Show("Novembro");
                    break;
                }
            case 12:
                {
                    MessageBox.Show("Dezembro");
                    break;
                }

            }
        }
    }
 }
