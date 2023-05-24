using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.DAL;

namespace LocadoraClassic.View
{
    public partial class FrmTelaCategoria : Form
    {
        public FrmTelaCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            categoria.Nome = txtNomeCategoria.Text;
            categoria.ValorDiaria = txtValorDiaria.Text;

            categoriaDAL.InserirCategoria(categoria);
            
            MessageBox.Show(categoria.Nome +" ("+categoria.ValorDiaria+")" + " inserido no banco de dados!");
        }
    }
}
