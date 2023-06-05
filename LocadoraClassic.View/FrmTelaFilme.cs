using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
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
            if (CategoriaComboBox.DataSource == null)
            {
                CategoriaComboBox.DataSource = CategoriaDAL.ValoresComboBoxCategoria();
                CategoriaComboBox.DisplayMember = "nome_categoria";
                CategoriaComboBox.ValueMember = "Id_categoria";
                CategoriaComboBox.SelectedIndex = -1;
            }                
        }

        private void GeneroComboBox_Click(object sender, EventArgs e)
        {
            if (GeneroComboBox.DataSource == null)
            {
                GeneroComboBox.DataSource = GeneroDAL.ValoresComboBoxGenero();
                GeneroComboBox.DisplayMember = "nome_genero";
                GeneroComboBox.ValueMember = "Id_genero";
                GeneroComboBox.SelectedIndex = -1;
            }
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
            filme.IdCategoria = Convert.ToInt32(CategoriaComboBox.SelectedValue);
            filme.IdGenero = Convert.ToInt32(GeneroComboBox.SelectedValue);
            filme.URLbanner = txtURL.Text;

            filmeDAL.InserirFilme(filme);
            InitializeDataGridView();

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

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var request = WebRequest.Create(txtURL.Text);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBoxBanner.Image = Bitmap.FromStream(stream);
                }
            }
            catch (System.UriFormatException) { }
            catch (System.Net.WebException) { }
        }
        public void DataGridViewFilmes_SelectionChanged(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            int id = 0;

            if (dataGridViewFilmes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFilmes.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["Id_filme"].Value);
                //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());
                filme.Id = id;
                txtSelecao.Text = filme.Id.ToString(); 
            }
            // MessageBox.Show(generoDAL.BuscarGenero(genero));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            FilmeDAL filmeDAL = new FilmeDAL();

            int id = 0;

            if (dataGridViewFilmes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFilmes.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["Id_filme"].Value);
                //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());
                filme.Id = id;
                txtSelecao.Text = filme.Id.ToString();
            }
            filmeDAL.DeletarFilme(filme);
            InitializeDataGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
