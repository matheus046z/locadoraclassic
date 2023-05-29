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
using System.Data.SqlClient;

namespace LocadoraClassic.View
{
    public partial class FrmTelaCategoria : Form
    {
        public FrmTelaCategoria()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            categoria.Nome = txtNomeCategoria.Text;
            categoria.ValorDiaria = txtValorDiaria.Text;

            categoriaDAL.InserirCategoria(categoria);
            
            MessageBox.Show(categoria.Nome +" ("+categoria.ValorDiaria+")" + " inserido no banco de dados!");

            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridViewCategoria.AutoGenerateColumns = true;
            conexao2BindingSource.DataSource = GetData("select * from categoria");
            dataGridViewCategoria.DataSource = conexao2BindingSource;
            dataGridViewCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }
        private static DataTable GetData(string sqlCommand)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();

            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategoria.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_categoria"].Value);
                MessageBox.Show("O valor do campo 'id' a ser excluido é: " + id.ToString());
            }

            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            categoria.Id = id;
            categoriaDAL.DeletarCategoria(categoria);
            InitializeDataGridView();
        }
        private void DataGridViewCategoria_SelectionChanged(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            int id = 0;

            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategoria.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_categoria"].Value);
                //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());
                categoria.Id = id;
                List<DataRow> nomeValor = categoriaDAL.BuscarCategoria(categoria);
                txtNomeSelecionado.Text = nomeValor[0][0].ToString();
                txtValorSelecionado.Text = nomeValor[0][1].ToString();

            }
            // MessageBox.Show(generoDAL.BuscarGenero(genero));
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            int id = 0;

            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategoria.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_categoria"].Value);
            }
            categoria.Id = id;
            categoria.Nome = txtNomeNovo.Text;
            categoria.ValorDiaria = txtValorNovo.Text;
            categoriaDAL.AlterarCategoria(categoria);
            InitializeDataGridView();
        }
    }
}