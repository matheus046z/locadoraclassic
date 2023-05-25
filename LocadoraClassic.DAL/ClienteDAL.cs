using LocadoraClassic.VO;
using Org.BouncyCastle.Utilities;
using System.Data.SqlClient;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {
        public void InserirCliente(Cliente cliente)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "INSERT INTO clientes(nome,endereco,telefone,cpf,rg) VALUES('" + cliente.Nome + "','" + cliente.Endereco + "','" + cliente.Telefone + "','" + cliente.Cpf + "','" + cliente.Rg + "')";

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
            string sql = "DELETE FROM clientes WHERE Id=" + cliente.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
    }
}
