using LocadoraClassic.VO;
using System.Data.SqlClient;

namespace LocadoraClassic.DAL
{
    public class GeneroDAL
    {
        //Faz um CRUD ai?
        //INSERT, DELETE, UPDATE, SELECT

        // metodo orientado a objeto
        public void IserirGenero(Genero genero) //Classe objeto
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "INSERT INTO genero(nome) VALUES('"+ genero.Nome +"')";
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public void DeletarGenero(Genero genero)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM genero WHERE Id="+genero.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public void AlterarGenero(Genero genero)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "UPDATE genero SET nome = '" + genero.Nome + "' WHERE Id = " + genero.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
    }
}
/*
UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;
*/