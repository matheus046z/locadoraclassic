using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmTelaInicialUiDesign : Form
    {
        public FrmTelaInicialUiDesign()
        {
            InitializeComponent();
            customizarDesign();
            abrirFormulario(new FrmConectarBD());
        }
        private void customizarDesign()
        {
            panelCadastros.Visible = false;
            panelLocacao.Visible = false;
            panelRelatorios.Visible = false;
            panelGraficos.Visible = false; 
            panelBancoDeDados.Visible = false;
        }
        private void esconderSubMenu()
        {
            if (panelCadastros.Visible == true)
                panelCadastros.Visible = false;
            if (panelLocacao.Visible == true)
                panelLocacao.Visible = false;
            if (panelRelatorios.Visible == true)
                panelRelatorios.Visible = false;
            if(panelGraficos.Visible == true)
                panelGraficos.Visible = false;
            if(panelBancoDeDados.Visible == true)
                panelBancoDeDados.Visible=false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Cadastros
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCadastros);
        }
        private void btnGenero_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmTelaGenero());
            esconderSubMenu();
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmTelaCategoria());
            esconderSubMenu();
        }
        private void btnFilme_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmTelaFilme());
            esconderSubMenu();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmTelaCliente());
            esconderSubMenu();
        }
        #endregion

        #region Locaçao
        private void btnLocacao_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelLocacao);
        }
        private void btnRealizarLocacao_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmTelaLocacao());
            esconderSubMenu();
        }
        private void btnRelatorio_Click(object sender, EventArgs e) //relatorio diario
        {
            //abrir form
            esconderSubMenu();
        }
        #endregion

        #region Relatórios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelRelatorios);
        }
        private void btnPendentes_Click(object sender, EventArgs e)
        {
            //abrir form
            esconderSubMenu();
        }
        private void btnFaturamentoDia_Click(object sender, EventArgs e)
        {
            //abrir form
            esconderSubMenu();
        }
        private void btnFaturamentoMes_Click(object sender, EventArgs e)
        {
            //abrir form
            esconderSubMenu();
        }
        #endregion

        #region Gráficos
        private void btnGraficos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelGraficos);
        }
        private void btnGraficoClientes_Click(object sender, EventArgs e)
        {
            //abrir form
            esconderSubMenu();
        }
        private void btnGraficoAtrasadosMes_Click(object sender, EventArgs e)
        {
            //abrir form
            esconderSubMenu();
        }
        #endregion

        #region Banco De Dados
        private void btnBancoDeDados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelBancoDeDados);
        }
        private void btnChecarConexao_Click(object sender, EventArgs e)
        {
            //abrir form
            MessageBox.Show(ConexaoBD.ConnectionStringBD);
            try
            {
                SqlConnection sqlcon;
                sqlcon = new SqlConnection(ConexaoBD.ConnectionStringBD);
                sqlcon.Open();
                MessageBox.Show("Conectado!");
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        esconderSubMenu();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //abrir form
            abrirFormulario(new FrmConectarBD());
            esconderSubMenu();
        }
        #endregion

        private Form formularioAtivo = null;
        private void abrirFormulario(Form formFilho)
        {
            if(formularioAtivo != null)
            {
                formularioAtivo.Close();
            }          
            formularioAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelChild.Controls.Add(formFilho);
            panelChild.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();  
        }
    }
}
