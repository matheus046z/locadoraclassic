using LocadoraClassic.VO;
using LocadoraClassic.DAL;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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

            if (ValidarCPF(cliente.Cpf) == true)
            {
                ClienteDAL clienteDAL = new ClienteDAL();
                clienteDAL.InserirCliente(cliente);

                MessageBox.Show(cliente.Nome + " inserido no banco de dados!");
                InitializeDataGridView();
            }
            else
            {
                MessageBox.Show("Cpf inválido!");
            }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                MessageBox.Show("O valor do campo 'id' a ser excluido é: " + id.ToString());
            }
            Cliente cliente = new Cliente();
            ClienteDAL clienteDAL = new ClienteDAL();

            cliente.Id = id;
            clienteDAL.DeletarCliente(cliente);
            InitializeDataGridView();
        }

        public static bool ValidarCPF(string cpf)
        {
            // Remove caracteres especiais do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF possui 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos do CPF são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            // Verifica se o primeiro dígito verificador está correto
            if (int.Parse(cpf[9].ToString()) != digitoVerificador1)
                return false;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            // Verifica se o segundo dígito verificador está correto
            if (int.Parse(cpf[10].ToString()) != digitoVerificador2)
                return false;

            // CPF válido
            return true;
        }
    }
}