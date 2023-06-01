using LocadoraClassic.VO;
using Org.BouncyCastle.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {
        public void InserirCliente(Cliente cliente)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "INSERT INTO clientes(nome_cliente,endereco,telefone,cpf,rg) VALUES('" + cliente.Nome + "','" + cliente.Endereco + "','" + cliente.Telefone + "','" + cliente.Cpf + "','" + cliente.Rg + "')";

            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
            
        }
        public void DeletarCliente(Cliente cliente)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM clientes WHERE Id_clientes=" + cliente.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public string BuscarClienteCPF(Cliente cliente)
        {
            string clienteNome = null;
            DataTable dt = new DataTable();

            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "SELECT nome_cliente FROM clientes WHERE cpf=" + "'" + cliente.Cpf + "'";
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                clienteNome = dt.Rows[0][0].ToString();
            }
            return clienteNome;
        }
    }
}
