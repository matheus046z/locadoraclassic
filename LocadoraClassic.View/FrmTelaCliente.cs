using LocadoraClassic.VO;
using LocadoraClassic.DAL;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LocadoraClassic.View
{
    public partial class FrmTelaCliente : Form
    {
        public FrmTelaCliente()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = mtxtTelefone.Text;
            cliente.Cpf = mtxtCPF.Text;
            cliente.Rg = txtRG.Text;

            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.InserirCliente(cliente);

            MessageBox.Show(cliente.Nome + " inserido no banco de dados!");
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            dataGridViewClientes.AutoGenerateColumns = true;

            conexao2BindingSource.DataSource = GetData("SELECT * FROM clientes");
            dataGridViewClientes.DataSource = conexao2BindingSource;

            dataGridViewClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();
            try
            {
                Conexao2.Sqlcon.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
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