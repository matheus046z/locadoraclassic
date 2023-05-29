using LocadoraClassic.VO;
using System.Data;
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
            string sql = "DELETE FROM genero WHERE Id_genero="+genero.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
        public string BuscarGenero(Genero genero)
        {
            DataTable dt = new DataTable("DTnome");
            //DataSet ds = new DataSet("DSnome");
            string retorno = "";
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "SELECT nome FROM genero WHERE Id_genero=" + genero.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.SelectCommand = command;
            
            adapter.Fill(dt);
            
            command.Dispose();
            Conexao2.Sqlcon.Close();
            
            //ds.Tables.Add(dt);
            if (dt.Rows.Count > 0)
            {
                retorno = dt.Rows[0][0].ToString();
            }
            return retorno;
        }
        public void AlterarGenero(Genero genero)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "UPDATE genero SET nome = '" + genero.Nome + "' WHERE Id_genero = " + genero.Id;
            command = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();
        }
    }
}