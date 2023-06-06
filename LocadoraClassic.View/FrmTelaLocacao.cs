using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmTelaLocacao : Form
    {
        public FrmTelaLocacao()
        {
            InitializeComponent();
            dateTimeLocacao.Value = DateTime.Today;
            dateTimeDevolucao.Value = DateTime.Today;
        }

        private void mtxtCPF_OnTextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDAL clienteDAL = new ClienteDAL();
            cliente.Cpf = mtxtCPF.Text;
            txtCliente.Text = clienteDAL.BuscarClienteCPF(cliente);
        }
        private void CategoriaComboBox_Click(object sender, EventArgs e)
        {
            if (CategoriaComboBox.DataSource == null)
            {
                CategoriaComboBox.DataSource = CategoriaDAL.ValoresComboBoxCategoria();
                //MessageBox.Show("Pegou do valores da categoria no Banco");
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
                //MessageBox.Show("Pegou do valores do genero no Banco");
                GeneroComboBox.DisplayMember = "nome_genero";
                GeneroComboBox.ValueMember = "Id_genero";
                GeneroComboBox.SelectedIndex = -1;
            }    
        }
        private void SelectedIndexChanged_GeneroCategoria(object sender, EventArgs e)
        {
            if (GeneroComboBox.DroppedDown == false & CategoriaComboBox.DroppedDown == false)
            {
                InitializeDataGridView();
            }
        }
        private void InitializeDataGridView()

        {
            if (GeneroComboBox.SelectedValue != null & CategoriaComboBox.SelectedValue != null)
            {
                DataTable dt = new DataTable();
                dt = GetData("SELECT * FROM filmes JOIN categoria " +
                    "ON CAST(filmes.Id_filme_categoria as VARCHAR(MAX)) = categoria.Id_categoria JOIN genero ON CAST(filmes.Id_filme_genero as VARCHAR(MAX)) = genero.Id_genero WHERE Id_filme_genero = " + GeneroComboBox.SelectedValue + "AND Id_filme_categoria = " + CategoriaComboBox.SelectedValue);
                string[] selectedColumns = new[] { "Id_filme", "nome_filme", "duracao", "sinopse", "nome_categoria", "nome_genero", "valordiaria", "stlocado" };
                DataTable dtOrganizada = new DataView(dt).ToTable(false, selectedColumns);
                dataGridViewBusca.AutoGenerateColumns = true;
                conexao2BindingSource.DataSource = dtOrganizada;
                dataGridViewBusca.DataSource = conexao2BindingSource;
                dataGridViewBusca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewBusca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }     
        }
        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();
            try
            {
                Conexao2.Sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);  // Usando a conection string instanciada no Conexao2 -> Conexao2.Sqlcon
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
                //MessageBox.Show("Erro de pesquisa no banco de dados, verificar com o administrador do sistema");
            }
            return table;
        }
        private void DataGridViewBusca_SelectionChanged(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            FilmeDAL filmeDAL = new FilmeDAL();
            int id = 0;
            DataGridViewRow selectedRow = null;

            if (dataGridViewBusca.SelectedRows.Count > 0)
            {
                try
                {
                    selectedRow = dataGridViewBusca.SelectedRows[0];
                    id = Convert.ToInt32(selectedRow.Cells["Id_filme"].Value);
                    filme.Id = id;
                    txtNomeDoFilmeSelecionado.Text = selectedRow.Cells["nome_filme"].Value.ToString();
                    txtValorDiaria.Text = selectedRow.Cells["valordiaria"].Value.ToString();

                    string URLbanner = filmeDAL.BuscarBannerURL(filme);
                    var request = WebRequest.Create(URLbanner);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBoxBanner.Image = Bitmap.FromStream(stream);
                    }
                }
                catch (System.InvalidCastException)
                {
                    selectedRow = null;
                }
                catch (System.UriFormatException) { }
                catch (System.Net.WebException) { }
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //txtPix.Text = ((float.Parse(txtTotalDeDias.Text)) * float.Parse(txtValorDiaria.Text)).ToString();
            PIX.Text = ((float.Parse(txtTotalDeDias.Text)) * float.Parse(txtValorDiaria.Text)).ToString();
            CategoriaComboBox.SelectedIndex = -1;
            GeneroComboBox.SelectedIndex = -1;
        }
        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GetData("SELECT * FROM filmes JOIN categoria ON CAST(filmes.Id_filme_categoria as VARCHAR(MAX)) = categoria.Id_categoria JOIN genero ON CAST(filmes.Id_filme_genero as VARCHAR(MAX)) = genero.Id_genero;");
            string[] selectedColumns = new[] { "Id_filme", "nome_filme", "duracao", "sinopse", "nome_categoria","nome_genero", "valordiaria", "stlocado" };
            DataTable dtOrganizada = new DataView(dt).ToTable(false, selectedColumns);
            dataGridViewBusca.AutoGenerateColumns = true;
            conexao2BindingSource.DataSource = dtOrganizada;
            dataGridViewBusca.DataSource = conexao2BindingSource;
            dataGridViewBusca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBusca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dateTimeLocacaoDevolucao_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeLocacao.Checked == true)
            {
                DateTime dataLocacao = dateTimeLocacao.Value;
                
                if (dateTimeDevolucao.Checked == true)
                {
                    DateTime dataDevolucao = dateTimeDevolucao.Value;
                    txtTotalDeDias.Text = Convert.ToInt32(dataDevolucao.Subtract(dataLocacao).TotalDays).ToString();
                }
            } 
        }
        private void btnAlugar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                try
                {
                    int StLocado = Convert.ToInt32(dataGridViewBusca.SelectedRows[0].Cells["stlocado"].Value);
                    if (StLocado == 0)
                    {
                        Filme filme = new Filme();
                        FilmeDAL filmeDAL = new FilmeDAL();
                        int id = Convert.ToInt32(dataGridViewBusca.SelectedRows[0].Cells["Id_filme"].Value);
                        // MessageBox.Show("Id_filme selecionado: " + id.ToString());
                        filme.Id = id;
                        filmeDAL.AlugarFilme(filme);
                        btnBuscarTodos.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Filme não disponível para locação");
                    }
                }
                catch (System.ArgumentOutOfRangeException) { }
            }
            else
            {
                MessageBox.Show("Digite o CPF de cliente cadastrado para alugar um filme!");
            }
        }
    }
}

