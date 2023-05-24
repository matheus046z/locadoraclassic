namespace LocadoraClassic.View
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
            this.conexao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexao2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(80, 53);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(456, 21);
            this.txtNomeGenero.TabIndex = 1;
            // 
            // btnCadastrarGenero
            // 
            this.btnCadastrarGenero.Location = new System.Drawing.Point(395, 80);
            this.btnCadastrarGenero.Name = "btnCadastrarGenero";
            this.btnCadastrarGenero.Size = new System.Drawing.Size(141, 23);
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
            this.dataGridViewGenero.Location = new System.Drawing.Point(42, 133);
            this.dataGridViewGenero.Name = "dataGridViewGenero";
            this.dataGridViewGenero.Size = new System.Drawing.Size(494, 405);
            this.dataGridViewGenero.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataSource";
            this.dataGridViewTextBoxColumn1.HeaderText = "DataSource";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // conexao2BindingSource
            // 
            this.conexao2BindingSource.DataSource = typeof(LocadoraClassic.DAL.Conexao2);
            // 
            // FrmTelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 588);
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
    }
}