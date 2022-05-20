using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void btnprint_Click(object sender, EventArgs e)
            {
                lblNome.Text = txtnome.Text;
                lblCurso.Text = txtcurso.Text;
                lblcidade.Text = txtcidade.Text;
                lblperiodo.Text = txtperiodo.Text;
                lblcpf.Text = txtcpf.Text;
                lblnome.Visible = true;
                lblcurso.Visible = true;
                lblcidade.Visible = true;
                lblperiodo.Visible = true;
                lblcpf.Visible = true;
            }
    }
}
