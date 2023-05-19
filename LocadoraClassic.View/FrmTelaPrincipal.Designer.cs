namespace LocadoraClassic.View
{
    partial class fmrMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoPizzaDeClientesPorEnderecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generoToolStripMenuItem.Text = "Gênero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocacaoToolStripMenuItem,
            this.relatorioDiarioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocacaoToolStripMenuItem
            // 
            this.realizarLocacaoToolStripMenuItem.Name = "realizarLocacaoToolStripMenuItem";
            this.realizarLocacaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarLocacaoToolStripMenuItem.Text = "Realizar Locação";
            this.realizarLocacaoToolStripMenuItem.Click += new System.EventHandler(this.realizarLocacaoToolStripMenuItem_Click);
            // 
            // relatorioDiarioToolStripMenuItem
            // 
            this.relatorioDiarioToolStripMenuItem.Name = "relatorioDiarioToolStripMenuItem";
            this.relatorioDiarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatorioDiarioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.faturamentoDoDiaToolStripMenuItem,
            this.faturamentoDoMesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            // 
            // faturamentoDoMesToolStripMenuItem
            // 
            this.faturamentoDoMesToolStripMenuItem.Name = "faturamentoDoMesToolStripMenuItem";
            this.faturamentoDoMesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.faturamentoDoMesToolStripMenuItem.Text = "Faturamento do Mês";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficoPizzaDeClientesPorEnderecoToolStripMenuItem,
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem});
            this.gráficosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // graficoPizzaDeClientesPorEnderecoToolStripMenuItem
            // 
            this.graficoPizzaDeClientesPorEnderecoToolStripMenuItem.Name = "graficoPizzaDeClientesPorEnderecoToolStripMenuItem";
            this.graficoPizzaDeClientesPorEnderecoToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.graficoPizzaDeClientesPorEnderecoToolStripMenuItem.Text = "Gráfico Pizza de Clientes por Endereço";
            // 
            // graficoDeBarraDeAtrasadosPorMasToolStripMenuItem
            // 
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem.Name = "graficoDeBarraDeAtrasadosPorMasToolStripMenuItem";
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem.Text = "Gráfico de Barra de Atrasados por Mês";
            this.graficoDeBarraDeAtrasadosPorMasToolStripMenuItem.Click += new System.EventHandler(this.graficoDeBarraDeAtrasadisPorMesToolStripMenuItem_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 517);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Locadora Classic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoPizzaDeClientesPorEnderecoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoDeBarraDeAtrasadosPorMasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDiarioToolStripMenuItem;
    }
}

