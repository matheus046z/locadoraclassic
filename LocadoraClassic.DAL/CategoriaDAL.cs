using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;
using LocadoraClassic.VO;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {
        public void InserirCategoria(Categoria categoria)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "INSERT INTO categoria(nome, valordiaria) VALUES('" + categoria.Nome + "', '" + categoria.ValorDiaria + "')";

            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public List<DataRow> BuscarCategoria(Categoria categoria)
        {
            DataTable dt = new DataTable();
            //string retorno = "";
            
            List<string> retorno = new List<string>();
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "SELECT nome,valordiaria FROM categoria WHERE Id=" + categoria.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.SelectCommand = command;

            adapter.Fill(dt);

            command.Dispose();
            Conexao2.Sqlcon.Close();

            List<DataRow> listaDr = dt.AsEnumerable().ToList();

            return listaDr;
        }
        public void DeletarCategoria(Categoria categoria)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM categoria WHERE Id=" + categoria.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public void AlterarCategoria(Categoria categoria)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "UPDATE categoria SET nome = '" + categoria.Nome + "', valordiaria = '" + categoria.ValorDiaria + "' WHERE Id = " + categoria.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
    }
}
