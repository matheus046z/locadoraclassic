using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraClassic.VO;
using MySqlX.XDevAPI;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme filme)
        {
            Conexao2.Sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "INSERT INTO filmes(nome,duracao,sinopse,stlocado,Id_filme_categoria,Id_filme_genero) VALUES('" + filme.Nome + "','" + filme.Duracao +"','" + filme.Sinopse +"','" + filme.Stlocado +"','" + filme.IdCategoria + "','" + filme.IdGenero + "')";
            SqlCommand command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
    }
}
