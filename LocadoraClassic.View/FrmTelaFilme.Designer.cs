﻿namespace LocadoraClassic.View
{
    partial class FrmTelaFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaFilme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.conexao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.checkBoxLocado = new System.Windows.Forms.CheckBox();
            this.mtxtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridViewFilmes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Filme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Banner";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DataSource = this.conexao2BindingSource;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(28, 36);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(343, 21);
            this.CategoriaComboBox.TabIndex = 0;
            this.CategoriaComboBox.Click += new System.EventHandler(this.CategoriaComboBox_Click);
            // 
            // conexao2BindingSource
            // 
            this.conexao2BindingSource.DataSource = typeof(LocadoraClassic.DAL.Conexao2);
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.DataSource = this.conexao2BindingSource;
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Location = new System.Drawing.Point(28, 76);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(121, 21);
            this.GeneroComboBox.TabIndex = 1;
            this.GeneroComboBox.Click += new System.EventHandler(this.GeneroComboBox_Click);
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(28, 129);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(343, 21);
            this.txtNomeFilme.TabIndex = 2;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(28, 224);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(343, 126);
            this.txtSinopse.TabIndex = 4;
            // 
            // checkBoxLocado
            // 
            this.checkBoxLocado.AutoSize = true;
            this.checkBoxLocado.Location = new System.Drawing.Point(28, 368);
            this.checkBoxLocado.Name = "checkBoxLocado";
            this.checkBoxLocado.Size = new System.Drawing.Size(60, 17);
            this.checkBoxLocado.TabIndex = 12;
            this.checkBoxLocado.Text = "Locado";
            this.checkBoxLocado.UseVisualStyleBackColor = true;
            // 
            // mtxtDuracao
            // 
            this.mtxtDuracao.Location = new System.Drawing.Point(28, 175);
            this.mtxtDuracao.Mask = "00:00";
            this.mtxtDuracao.Name = "mtxtDuracao";
            this.mtxtDuracao.Size = new System.Drawing.Size(343, 21);
            this.mtxtDuracao.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(28, 406);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(665, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // dataGridViewFilmes
            // 
            this.dataGridViewFilmes.AllowUserToAddRows = false;
            this.dataGridViewFilmes.AllowUserToDeleteRows = false;
            this.dataGridViewFilmes.AutoGenerateColumns = false;
            this.dataGridViewFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmes.DataSource = this.conexao2BindingSource;
            this.dataGridViewFilmes.Location = new System.Drawing.Point(28, 461);
            this.dataGridViewFilmes.Name = "dataGridViewFilmes";
            this.dataGridViewFilmes.ReadOnly = true;
            this.dataGridViewFilmes.Size = new System.Drawing.Size(1032, 176);
            this.dataGridViewFilmes.TabIndex = 15;
            // 
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 686);
            this.Controls.Add(this.dataGridViewFilmes);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxtDuracao);
            this.Controls.Add(this.checkBoxLocado);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.GeneroComboBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filme";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.CheckBox checkBoxLocado;
        private System.Windows.Forms.MaskedTextBox mtxtDuracao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.BindingSource conexao2BindingSource;
        private System.Windows.Forms.DataGridView dataGridViewFilmes;
    }
}