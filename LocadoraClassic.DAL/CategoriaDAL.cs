using System.Data.SqlClient;
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
    }
}
