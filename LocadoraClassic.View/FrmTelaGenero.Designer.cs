﻿namespace LocadoraClassic.View
{
    partial class FrmTelaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGenero));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.btnCadastrarGenero = new System.Windows.Forms.Button();
            this.dataGridViewGenero = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNomeNovo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeSelecionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conexao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(42, 52);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(570, 21);
            this.txtNomeGenero.TabIndex = 1;
            // 
            // btnCadastrarGenero
            // 
            this.btnCadastrarGenero.Location = new System.Drawing.Point(42, 79);
            this.btnCadastrarGenero.Name = "btnCadastrarGenero";
            this.btnCadastrarGenero.Size = new System.Drawing.Size(570, 23);
            this.btnCadastrarGenero.TabIndex = 2;
            this.btnCadastrarGenero.Text = "Cadastrar";
            this.btnCadastrarGenero.UseVisualStyleBackColor = true;
            this.btnCadastrarGenero.Click += new System.EventHandler(this.btnCadastrarGenero_Click);
            // 
            // dataGridViewGenero
            // 
            this.dataGridViewGenero.AllowUserToAddRows = false;
            this.dataGridViewGenero.AllowUserToDeleteRows = false;
            this.dataGridViewGenero.AllowUserToResizeColumns = false;
            this.dataGridViewGenero.AllowUserToResizeRows = false;
            this.dataGridViewGenero.AutoGenerateColumns = false;
            this.dataGridViewGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenero.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGenero.DataSource = this.conexao2BindingSource;
            this.dataGridViewGenero.Location = new System.Drawing.Point(42, 138);
            this.dataGridViewGenero.Name = "dataGridViewGenero";
            this.dataGridViewGenero.ReadOnly = true;
            this.dataGridViewGenero.Size = new System.Drawing.Size(570, 525);
            this.dataGridViewGenero.TabIndex = 0;
            this.dataGridViewGenero.SelectionChanged += new System.EventHandler(this.DataGridViewGenero_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataSource";
            this.dataGridViewTextBoxColumn1.HeaderText = "DataSource";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(794, 150);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(168, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(794, 193);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(168, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar Nome";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNomeNovo
            // 
            this.txtNomeNovo.Location = new System.Drawing.Point(634, 195);
            this.txtNomeNovo.Name = "txtNomeNovo";
            this.txtNomeNovo.Size = new System.Drawing.Size(154, 21);
            this.txtNomeNovo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 11);
            this.label2.TabIndex = 7;
            this.label2.Text = "Novo Nome";
            // 
            // txtNomeSelecionado
            // 
            this.txtNomeSelecionado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeSelecionado.Enabled = false;
            this.txtNomeSelecionado.Location = new System.Drawing.Point(634, 152);
            this.txtNomeSelecionado.Name = "txtNomeSelecionado";
            this.txtNomeSelecionado.Size = new System.Drawing.Size(154, 21);
            this.txtNomeSelecionado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 11);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gênero Selecionado";
            // 
            // conexao2BindingSource
            // 
            this.conexao2BindingSource.DataSource = typeof(LocadoraClassic.DAL.Conexao2);
            // 
            // FrmTelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 728);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeSelecionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridViewGenero);
            this.Controls.Add(this.btnCadastrarGenero);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Gênero";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Button btnCadastrarGenero;
        private System.Windows.Forms.DataGridView dataGridViewGenero;
        private System.Windows.Forms.BindingSource conexao2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNomeNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeSelecionado;
        private System.Windows.Forms.Label label3;
    }
}