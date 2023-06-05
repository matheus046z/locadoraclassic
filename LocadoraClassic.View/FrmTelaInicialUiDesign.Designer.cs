namespace LocadoraClassic.View
{
    partial class FrmTelaInicialUiDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panelCadastros = new System.Windows.Forms.Panel();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnLocacao = new System.Windows.Forms.Button();
            this.panelLocacao = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnRealizarLocacao = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.btnFaturamentoDia = new System.Windows.Forms.Button();
            this.btnPendentes = new System.Windows.Forms.Button();
            this.btnFaturamentoMes = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.btnGraficoAtrasadosMes = new System.Windows.Forms.Button();
            this.btnGraficoClientes = new System.Windows.Forms.Button();
            this.btnBancoDeDados = new System.Windows.Forms.Button();
            this.panelBancoDeDados = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnChecarConexao = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelCadastros.SuspendLayout();
            this.panelLocacao.SuspendLayout();
            this.panelRelatorios.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            this.panelBancoDeDados.SuspendLayout();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSideMenu.Controls.Add(this.panelBancoDeDados);
            this.panelSideMenu.Controls.Add(this.btnBancoDeDados);
            this.panelSideMenu.Controls.Add(this.panelGraficos);
            this.panelSideMenu.Controls.Add(this.btnGraficos);
            this.panelSideMenu.Controls.Add(this.panelRelatorios);
            this.panelSideMenu.Controls.Add(this.btnRelatorios);
            this.panelSideMenu.Controls.Add(this.panelLocacao);
            this.panelSideMenu.Controls.Add(this.btnLocacao);
            this.panelSideMenu.Controls.Add(this.panelCadastros);
            this.panelSideMenu.Controls.Add(this.btnCadastros);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.ForeColor = System.Drawing.Color.LightGray;
            this.btnCadastros.Location = new System.Drawing.Point(0, 109);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(233, 45);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // panelCadastros
            // 
            this.panelCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelCadastros.Controls.Add(this.btnCliente);
            this.panelCadastros.Controls.Add(this.btnFilme);
            this.panelCadastros.Controls.Add(this.btnCategoria);
            this.panelCadastros.Controls.Add(this.btnGenero);
            this.panelCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastros.Location = new System.Drawing.Point(0, 154);
            this.panelCadastros.Name = "panelCadastros";
            this.panelCadastros.Size = new System.Drawing.Size(233, 173);
            this.panelCadastros.TabIndex = 2;
            // 
            // btnGenero
            // 
            this.btnGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenero.FlatAppearance.BorderSize = 0;
            this.btnGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenero.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenero.Location = new System.Drawing.Point(0, 0);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGenero.Size = new System.Drawing.Size(233, 40);
            this.btnGenero.TabIndex = 0;
            this.btnGenero.Text = "Gênero";
            this.btnGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.btnCategoria.Location = new System.Drawing.Point(0, 40);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(233, 40);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilme.FlatAppearance.BorderSize = 0;
            this.btnFilme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilme.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilme.Location = new System.Drawing.Point(0, 80);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFilme.Size = new System.Drawing.Size(233, 40);
            this.btnFilme.TabIndex = 2;
            this.btnFilme.Text = "Filme";
            this.btnFilme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnCliente.Location = new System.Drawing.Point(0, 120);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(233, 40);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnLocacao
            // 
            this.btnLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocacao.FlatAppearance.BorderSize = 0;
            this.btnLocacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocacao.ForeColor = System.Drawing.Color.LightGray;
            this.btnLocacao.Location = new System.Drawing.Point(0, 327);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocacao.Size = new System.Drawing.Size(233, 45);
            this.btnLocacao.TabIndex = 3;
            this.btnLocacao.Text = "Locação";
            this.btnLocacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocacao.UseVisualStyleBackColor = true;
            this.btnLocacao.Click += new System.EventHandler(this.btnLocacao_Click);
            // 
            // panelLocacao
            // 
            this.panelLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelLocacao.Controls.Add(this.btnRelatorio);
            this.panelLocacao.Controls.Add(this.btnRealizarLocacao);
            this.panelLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocacao.Location = new System.Drawing.Point(0, 372);
            this.panelLocacao.Name = "panelLocacao";
            this.panelLocacao.Size = new System.Drawing.Size(233, 92);
            this.panelLocacao.TabIndex = 4;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.ForeColor = System.Drawing.Color.LightGray;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 40);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRelatorio.Size = new System.Drawing.Size(233, 40);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "Relatório Diário";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnRealizarLocacao
            // 
            this.btnRealizarLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRealizarLocacao.FlatAppearance.BorderSize = 0;
            this.btnRealizarLocacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRealizarLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarLocacao.ForeColor = System.Drawing.Color.LightGray;
            this.btnRealizarLocacao.Location = new System.Drawing.Point(0, 0);
            this.btnRealizarLocacao.Name = "btnRealizarLocacao";
            this.btnRealizarLocacao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRealizarLocacao.Size = new System.Drawing.Size(233, 40);
            this.btnRealizarLocacao.TabIndex = 0;
            this.btnRealizarLocacao.Text = "Realizar Locação";
            this.btnRealizarLocacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarLocacao.UseVisualStyleBackColor = true;
            this.btnRealizarLocacao.Click += new System.EventHandler(this.btnRealizarLocacao_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.ForeColor = System.Drawing.Color.LightGray;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 464);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(233, 45);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelRelatorios.Controls.Add(this.btnFaturamentoMes);
            this.panelRelatorios.Controls.Add(this.btnFaturamentoDia);
            this.panelRelatorios.Controls.Add(this.btnPendentes);
            this.panelRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelatorios.Location = new System.Drawing.Point(0, 509);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(233, 126);
            this.panelRelatorios.TabIndex = 6;
            // 
            // btnFaturamentoDia
            // 
            this.btnFaturamentoDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaturamentoDia.FlatAppearance.BorderSize = 0;
            this.btnFaturamentoDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFaturamentoDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturamentoDia.ForeColor = System.Drawing.Color.LightGray;
            this.btnFaturamentoDia.Location = new System.Drawing.Point(0, 40);
            this.btnFaturamentoDia.Name = "btnFaturamentoDia";
            this.btnFaturamentoDia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFaturamentoDia.Size = new System.Drawing.Size(233, 40);
            this.btnFaturamentoDia.TabIndex = 1;
            this.btnFaturamentoDia.Text = "Faturamento do Dia";
            this.btnFaturamentoDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturamentoDia.UseVisualStyleBackColor = true;
            this.btnFaturamentoDia.Click += new System.EventHandler(this.btnFaturamentoDia_Click);
            // 
            // btnPendentes
            // 
            this.btnPendentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendentes.FlatAppearance.BorderSize = 0;
            this.btnPendentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendentes.ForeColor = System.Drawing.Color.LightGray;
            this.btnPendentes.Location = new System.Drawing.Point(0, 0);
            this.btnPendentes.Name = "btnPendentes";
            this.btnPendentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPendentes.Size = new System.Drawing.Size(233, 40);
            this.btnPendentes.TabIndex = 0;
            this.btnPendentes.Text = "Pendentes";
            this.btnPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendentes.UseVisualStyleBackColor = true;
            this.btnPendentes.Click += new System.EventHandler(this.btnPendentes_Click);
            // 
            // btnFaturamentoMes
            // 
            this.btnFaturamentoMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaturamentoMes.FlatAppearance.BorderSize = 0;
            this.btnFaturamentoMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFaturamentoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturamentoMes.ForeColor = System.Drawing.Color.LightGray;
            this.btnFaturamentoMes.Location = new System.Drawing.Point(0, 80);
            this.btnFaturamentoMes.Name = "btnFaturamentoMes";
            this.btnFaturamentoMes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFaturamentoMes.Size = new System.Drawing.Size(233, 40);
            this.btnFaturamentoMes.TabIndex = 2;
            this.btnFaturamentoMes.Text = "Faturamento do Mês";
            this.btnFaturamentoMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturamentoMes.UseVisualStyleBackColor = true;
            this.btnFaturamentoMes.Click += new System.EventHandler(this.btnFaturamentoMes_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.ForeColor = System.Drawing.Color.LightGray;
            this.btnGraficos.Location = new System.Drawing.Point(0, 635);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGraficos.Size = new System.Drawing.Size(233, 45);
            this.btnGraficos.TabIndex = 7;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.UseVisualStyleBackColor = true;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // panelGraficos
            // 
            this.panelGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelGraficos.Controls.Add(this.btnGraficoAtrasadosMes);
            this.panelGraficos.Controls.Add(this.btnGraficoClientes);
            this.panelGraficos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraficos.Location = new System.Drawing.Point(0, 680);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(233, 89);
            this.panelGraficos.TabIndex = 8;
            // 
            // btnGraficoAtrasadosMes
            // 
            this.btnGraficoAtrasadosMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraficoAtrasadosMes.FlatAppearance.BorderSize = 0;
            this.btnGraficoAtrasadosMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnGraficoAtrasadosMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficoAtrasadosMes.ForeColor = System.Drawing.Color.LightGray;
            this.btnGraficoAtrasadosMes.Location = new System.Drawing.Point(0, 40);
            this.btnGraficoAtrasadosMes.Name = "btnGraficoAtrasadosMes";
            this.btnGraficoAtrasadosMes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGraficoAtrasadosMes.Size = new System.Drawing.Size(233, 40);
            this.btnGraficoAtrasadosMes.TabIndex = 1;
            this.btnGraficoAtrasadosMes.Text = "Atrasados Por Mês";
            this.btnGraficoAtrasadosMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficoAtrasadosMes.UseVisualStyleBackColor = true;
            this.btnGraficoAtrasadosMes.Click += new System.EventHandler(this.btnGraficoAtrasadosMes_Click);
            // 
            // btnGraficoClientes
            // 
            this.btnGraficoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraficoClientes.FlatAppearance.BorderSize = 0;
            this.btnGraficoClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnGraficoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficoClientes.ForeColor = System.Drawing.Color.LightGray;
            this.btnGraficoClientes.Location = new System.Drawing.Point(0, 0);
            this.btnGraficoClientes.Name = "btnGraficoClientes";
            this.btnGraficoClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGraficoClientes.Size = new System.Drawing.Size(233, 40);
            this.btnGraficoClientes.TabIndex = 0;
            this.btnGraficoClientes.Text = "Clientes Por Endereço";
            this.btnGraficoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficoClientes.UseVisualStyleBackColor = true;
            this.btnGraficoClientes.Click += new System.EventHandler(this.btnGraficoClientes_Click);
            // 
            // btnBancoDeDados
            // 
            this.btnBancoDeDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBancoDeDados.FlatAppearance.BorderSize = 0;
            this.btnBancoDeDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBancoDeDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancoDeDados.ForeColor = System.Drawing.Color.LightGray;
            this.btnBancoDeDados.Location = new System.Drawing.Point(0, 769);
            this.btnBancoDeDados.Name = "btnBancoDeDados";
            this.btnBancoDeDados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBancoDeDados.Size = new System.Drawing.Size(233, 45);
            this.btnBancoDeDados.TabIndex = 9;
            this.btnBancoDeDados.Text = "Banco de Dados";
            this.btnBancoDeDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBancoDeDados.UseVisualStyleBackColor = true;
            this.btnBancoDeDados.Click += new System.EventHandler(this.btnBancoDeDados_Click);
            // 
            // panelBancoDeDados
            // 
            this.panelBancoDeDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelBancoDeDados.Controls.Add(this.btnConectar);
            this.panelBancoDeDados.Controls.Add(this.btnChecarConexao);
            this.panelBancoDeDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBancoDeDados.Location = new System.Drawing.Point(0, 814);
            this.panelBancoDeDados.Name = "panelBancoDeDados";
            this.panelBancoDeDados.Size = new System.Drawing.Size(233, 89);
            this.panelBancoDeDados.TabIndex = 10;
            // 
            // btnConectar
            // 
            this.btnConectar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConectar.Location = new System.Drawing.Point(0, 40);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConectar.Size = new System.Drawing.Size(233, 40);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnChecarConexao
            // 
            this.btnChecarConexao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChecarConexao.FlatAppearance.BorderSize = 0;
            this.btnChecarConexao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnChecarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecarConexao.ForeColor = System.Drawing.Color.LightGray;
            this.btnChecarConexao.Location = new System.Drawing.Point(0, 0);
            this.btnChecarConexao.Name = "btnChecarConexao";
            this.btnChecarConexao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChecarConexao.Size = new System.Drawing.Size(233, 40);
            this.btnChecarConexao.TabIndex = 0;
            this.btnChecarConexao.Text = "Checar Conexão";
            this.btnChecarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChecarConexao.UseVisualStyleBackColor = true;
            this.btnChecarConexao.Click += new System.EventHandler(this.btnChecarConexao_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChild.Controls.Add(this.pictureBox1);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(684, 561);
            this.panelChild.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::LocadoraClassic.View.Properties.Resources.CLASSICtransparente;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 109);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocadoraClassic.View.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTelaInicialUiDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FrmTelaInicialUiDesign";
            this.Text = "FrmTelaInicialUiDesign";
            this.panelSideMenu.ResumeLayout(false);
            this.panelCadastros.ResumeLayout(false);
            this.panelLocacao.ResumeLayout(false);
            this.panelRelatorios.ResumeLayout(false);
            this.panelGraficos.ResumeLayout(false);
            this.panelBancoDeDados.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel panelCadastros;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Panel panelLocacao;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnRealizarLocacao;
        private System.Windows.Forms.Button btnLocacao;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Panel panelRelatorios;
        private System.Windows.Forms.Button btnFaturamentoDia;
        private System.Windows.Forms.Button btnPendentes;
        private System.Windows.Forms.Button btnFaturamentoMes;
        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.Button btnGraficoAtrasadosMes;
        private System.Windows.Forms.Button btnGraficoClientes;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Panel panelBancoDeDados;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnChecarConexao;
        private System.Windows.Forms.Button btnBancoDeDados;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}