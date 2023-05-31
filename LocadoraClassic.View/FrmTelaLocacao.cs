using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraClassic.View
{
    public partial class FrmTelaLocacao : Form
    {
        public FrmTelaLocacao()
        {
            InitializeComponent();
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
            if (Convert.ToInt32(CategoriaComboBox.SelectedIndex) <= 0)
            {
                CategoriaComboBox.DataSource = CategoriaDAL.ValoresComboBoxCategoria();
            }

            CategoriaComboBox.DisplayMember = "nome";
            CategoriaComboBox.ValueMember = "Id_categoria";
            InitializeDataGridView();
        }

        private void GeneroComboBox_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GeneroComboBox.SelectedIndex) <= 0)
            {
                GeneroComboBox.DataSource = GeneroDAL.ValoresComboBoxGenero();
            }

            GeneroComboBox.DisplayMember = "nome";
            GeneroComboBox.ValueMember = "Id_genero";
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            if (Convert.ToInt32(GeneroComboBox.SelectedValue) > 0 & Convert.ToInt32(GeneroComboBox.SelectedValue) > 0)
            {
                dataGridViewBusca.AutoGenerateColumns = true;
                //MessageBox.Show("Genero: " + GeneroComboBox.SelectedValue + "\n Categoria: " + CategoriaComboBox.SelectedValue);
                //MessageBox.Show("SELECT * FROM filmes WHERE Id_filme_genero = " + GeneroComboBox.SelectedValue + "AND Id_filme_categoria = " + CategoriaComboBox.SelectedValue);
                conexao2BindingSource.DataSource = GetData("SELECT * FROM filmes WHERE Id_filme_genero = " + GeneroComboBox.SelectedValue + " AND Id_filme_categoria = " + CategoriaComboBox.SelectedValue);
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
            //FilmeDAL filmeDAL = new FilmeDAL();
            int id = 0;

            if (dataGridViewBusca.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewBusca.SelectedRows[0];
                    id = Convert.ToInt32(selectedRow.Cells["Id_filme"].Value);
                    //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());
                    filme.Id = id;
                    txtNomeDoFilmeSelecionado.Text = selectedRow.Cells["nome"].Value.ToString();
                }

                catch (System.InvalidCastException)
                {

                }
            }
        }
        //private void dataGridViewBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
