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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGenero));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.btnCadastrarGenero = new System.Windows.Forms.Button();
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
            this.txtNomeGenero.Size = new System.Drawing.Size(439, 21);
            this.txtNomeGenero.TabIndex = 1;
            // 
            // btnCadastrarGenero
            // 
            this.btnCadastrarGenero.Location = new System.Drawing.Point(395, 102);
            this.btnCadastrarGenero.Name = "btnCadastrarGenero";
            this.btnCadastrarGenero.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrarGenero.TabIndex = 2;
            this.btnCadastrarGenero.Text = "Cadastrar";
            this.btnCadastrarGenero.UseVisualStyleBackColor = true;
            this.btnCadastrarGenero.Click += new System.EventHandler(this.btnCadastrarGenero_Click);
            // 
            // FrmTelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 173);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Button btnCadastrarGenero;
    }
}