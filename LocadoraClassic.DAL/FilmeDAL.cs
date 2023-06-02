using System.Data;
using System.Data.SqlClient;
using LocadoraClassic.VO;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme filme)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "INSERT INTO filmes(nome_filme,duracao,sinopse,stlocado,banner, Id_filme_categoria,Id_filme_genero) VALUES('" + filme.Nome + "','" + filme.Duracao +"','" + filme.Sinopse +"','" + filme.Stlocado + "','" + filme.URLbanner + "','" + filme.IdCategoria + "','" + filme.IdGenero + "')";
            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public void DeletarFilme(Filme filme)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM filmes WHERE Id_filme=" + filme.Id;
            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public string BuscarBannerURL (Filme filme)
        {
            string BannerURL = null;
            DataTable dt = new DataTable();

            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "SELECT banner FROM filmes WHERE Id_filme = " + filme.Id;
            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                BannerURL = dt.Rows[0][0].ToString();
            }

            return BannerURL;
        }
        public void AlugarFilme (Filme filme)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "UPDATE filmes SET stlocado = 1 WHERE Id_filme = " + filme.Id;
            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
            adapter.SelectCommand = command;
        }
    }
}