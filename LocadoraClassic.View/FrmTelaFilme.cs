using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LocadoraClassic.View
{
    public partial class FrmTelaFilme : Form
    {
        public FrmTelaFilme()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void CategoriaComboBox_Click(object sender, EventArgs e)
        {
            CategoriaComboBox.DataSource = CategoriaDAL.ValoresComboBoxCategoria();
            CategoriaComboBox.DisplayMember = "nome";
            CategoriaComboBox.ValueMember = "Id_categoria";
             
        }

        private void GeneroComboBox_Click(object sender, EventArgs e)
        {
            GeneroComboBox.DataSource = GeneroDAL.ValoresComboBoxGenero();
            GeneroComboBox.DisplayMember = "nome";
            GeneroComboBox.ValueMember = "Id_genero";   
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            FilmeDAL filmeDAL = new FilmeDAL();

            if (checkBoxLocado.CheckState == CheckState.Unchecked)
            {
                filme.Stlocado = false;
            }
            else
            {
                filme.Stlocado = true;
            }
            filme.Nome = txtNomeFilme.Text;
            filme.Duracao = mtxtDuracao.Text;
            filme.Sinopse = txtSinopse.Text;
            //filme.IdCategoria = Convert.ToInt32(CategoriaComboBox.ValueMember);
            //filme.IdGenero = Convert.ToInt32(GeneroComboBox.ValueMember);

            filme.IdCategoria = Convert.ToInt32(CategoriaComboBox.SelectedValue);
            filme.IdGenero = Convert.ToInt32(GeneroComboBox.SelectedValue);
            //filme.Banner =

            MessageBox.Show("Categoria - Id " + filme.IdCategoria);
            MessageBox.Show("Genero - Id: " + filme.IdGenero);

            filmeDAL.InserirFilme(filme);

        }
        private void InitializeDataGridView()
        {
            dataGridViewFilmes.AutoGenerateColumns = true;

            conexao2BindingSource.DataSource = GetData("SELECT * FROM filmes");
            dataGridViewFilmes.DataSource = conexao2BindingSource;

            dataGridViewFilmes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();
            try
            {
                Conexao2.Sqlcon.Open();

                SqlCommand command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                Conexao2.Sqlcon.Close();

                adapter.SelectCommand = command;

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
            }
            catch (System.InvalidOperationException)
            {
                Conexao2.Sqlcon.Close();
                MessageBox.Show("O sistema perdeu a conexão ao banco de dados");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Conexao2.Sqlcon.Close();
                MessageBox.Show("Erro de pesquisa no banco de dados, verificar com o administrador do sistema");
            }
            return table;
        }

    }
}
