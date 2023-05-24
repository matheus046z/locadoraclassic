using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;
using LocadoraClassic.DAL;

namespace LocadoraClassic.View
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void graficoDeBarraDeAtrasadisPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaGenero frmTelaGenero = new FrmTelaGenero();
            frmTelaGenero.MdiParent = this;
            frmTelaGenero.Show();
            //FrmTelaGenero form = FrmTelaGenero.Instance;
            //form.Show();

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCategoria frmTelaCategoria = new FrmTelaCategoria();
            frmTelaCategoria.MdiParent = this;
            frmTelaCategoria.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaFilme frmTelaFilme = new FrmTelaFilme();
            frmTelaFilme.MdiParent = this;
            frmTelaFilme.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCliente frmTelaCliente = new FrmTelaCliente();
            frmTelaCliente.MdiParent = this;
            frmTelaCliente.Show();
        }

        private void realizarLocacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaLocacao frmTelaLocacao = new FrmTelaLocacao();
            frmTelaLocacao.MdiParent = this;
            frmTelaLocacao.Show();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConectarBD frmConectarBD = new FrmConectarBD();
            frmConectarBD.MdiParent = this;
            frmConectarBD.Show();
        }
    }
}
