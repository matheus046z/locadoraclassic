﻿namespace LocadoraClassic.View
{
    partial class FrmTelaLocacao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaLocacao));
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeDoFilmeSelecionado = new System.Windows.Forms.TextBox();
            this.dataGridViewBusca = new System.Windows.Forms.DataGridView();
            this.conexao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PIX = new System.Windows.Forms.Label();
            this.txtTotalDeDias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.dateTimeDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLocacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(9, 34);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(98, 21);
            this.mtxtCPF.TabIndex = 1;
            this.mtxtCPF.TextChanged += new System.EventHandler(this.mtxtCPF_OnTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(113, 34);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(227, 21);
            this.txtCliente.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.mtxtCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de Cliente por CPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtValorDiaria);
            this.groupBox2.Controls.Add(this.btnBuscarTodos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNomeDoFilmeSelecionado);
            this.groupBox2.Controls.Add(this.dataGridViewBusca);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.GeneroComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CategoriaComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 255);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Filme por Nome";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor da diária";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDiaria.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValorDiaria.Enabled = false;
            this.txtValorDiaria.Location = new System.Drawing.Point(317, 228);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(89, 21);
            this.txtValorDiaria.TabIndex = 9;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTodos.Location = new System.Drawing.Point(310, 31);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarTodos.TabIndex = 8;
            this.btnBuscarTodos.Text = "Buscar em todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Selecione o filme";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtNomeDoFilmeSelecionado
            // 
            this.txtNomeDoFilmeSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeDoFilmeSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNomeDoFilmeSelecionado.Enabled = false;
            this.txtNomeDoFilmeSelecionado.Location = new System.Drawing.Point(9, 228);
            this.txtNomeDoFilmeSelecionado.Name = "txtNomeDoFilmeSelecionado";
            this.txtNomeDoFilmeSelecionado.Size = new System.Drawing.Size(261, 21);
            this.txtNomeDoFilmeSelecionado.TabIndex = 5;
            // 
            // dataGridViewBusca
            // 
            this.dataGridViewBusca.AllowUserToAddRows = false;
            this.dataGridViewBusca.AllowUserToDeleteRows = false;
            this.dataGridViewBusca.AllowUserToOrderColumns = true;
            this.dataGridViewBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBusca.AutoGenerateColumns = false;
            this.dataGridViewBusca.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusca.DataSource = this.conexao2BindingSource;
            this.dataGridViewBusca.Location = new System.Drawing.Point(9, 73);
            this.dataGridViewBusca.Name = "dataGridViewBusca";
            this.dataGridViewBusca.ReadOnly = true;
            this.dataGridViewBusca.Size = new System.Drawing.Size(399, 136);
            this.dataGridViewBusca.TabIndex = 5;
            this.dataGridViewBusca.SelectionChanged += new System.EventHandler(this.DataGridViewBusca_SelectionChanged);
            // 
            // conexao2BindingSource
            // 
            this.conexao2BindingSource.DataSource = typeof(LocadoraClassic.DAL.Conexao2);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do Filme Selecionado";
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Location = new System.Drawing.Point(133, 31);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(118, 21);
            this.GeneroComboBox.TabIndex = 4;
            this.GeneroComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_GeneroCategoria);
            this.GeneroComboBox.Click += new System.EventHandler(this.GeneroComboBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(9, 31);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(118, 21);
            this.CategoriaComboBox.TabIndex = 3;
            this.CategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_GeneroCategoria);
            this.CategoriaComboBox.Click += new System.EventHandler(this.CategoriaComboBox_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(366, 43);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 38);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Calcular Valor";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.PIX);
            this.groupBox3.Controls.Add(this.txtTotalDeDias);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnAlugar);
            this.groupBox3.Controls.Add(this.btnConfirmar);
            this.groupBox3.Controls.Add(this.dateTimeDevolucao);
            this.groupBox3.Controls.Add(this.dateTimeLocacao);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 171);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(479, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 42);
            this.label12.TabIndex = 10;
            this.label12.Text = "R$";
            this.label12.UseCompatibleTextRendering = true;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // PIX
            // 
            this.PIX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PIX.AutoSize = true;
            this.PIX.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIX.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.PIX.Location = new System.Drawing.Point(530, 47);
            this.PIX.Name = "PIX";
            this.PIX.Size = new System.Drawing.Size(0, 38);
            this.PIX.TabIndex = 9;
            this.PIX.UseCompatibleTextRendering = true;
            // 
            // txtTotalDeDias
            // 
            this.txtTotalDeDias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDeDias.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalDeDias.Enabled = false;
            this.txtTotalDeDias.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeDias.Location = new System.Drawing.Point(9, 123);
            this.txtTotalDeDias.Name = "txtTotalDeDias";
            this.txtTotalDeDias.Size = new System.Drawing.Size(66, 30);
            this.txtTotalDeDias.TabIndex = 7;
            this.txtTotalDeDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total de Dias";
            // 
            // btnAlugar
            // 
            this.btnAlugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlugar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAlugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlugar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlugar.Location = new System.Drawing.Point(366, 114);
            this.btnAlugar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(274, 53);
            this.btnAlugar.TabIndex = 4;
            this.btnAlugar.Text = "ALUGAR";
            this.btnAlugar.UseVisualStyleBackColor = false;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // dateTimeDevolucao
            // 
            this.dateTimeDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDevolucao.Location = new System.Drawing.Point(9, 78);
            this.dateTimeDevolucao.Name = "dateTimeDevolucao";
            this.dateTimeDevolucao.Size = new System.Drawing.Size(223, 21);
            this.dateTimeDevolucao.TabIndex = 3;
            this.dateTimeDevolucao.ValueChanged += new System.EventHandler(this.dateTimeLocacaoDevolucao_ValueChanged);
            // 
            // dateTimeLocacao
            // 
            this.dateTimeLocacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeLocacao.Location = new System.Drawing.Point(9, 33);
            this.dateTimeLocacao.Name = "dateTimeLocacao";
            this.dateTimeLocacao.Size = new System.Drawing.Size(223, 21);
            this.dateTimeLocacao.TabIndex = 2;
            this.dateTimeLocacao.ValueChanged += new System.EventHandler(this.dateTimeLocacaoDevolucao_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data da Devolução";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data da Locação";
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBanner.Location = new System.Drawing.Point(440, 12);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(216, 321);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner.TabIndex = 7;
            this.pictureBoxBanner.TabStop = false;
            // 
            // FrmTelaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Locar Filme";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeDoFilmeSelecionado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dataGridViewBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucao;
        private System.Windows.Forms.DateTimePicker dateTimeLocacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource conexao2BindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.TextBox txtTotalDeDias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label PIX;
        private System.Windows.Forms.Label label12;
    }
}