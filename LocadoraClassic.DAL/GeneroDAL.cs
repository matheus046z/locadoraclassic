using LocadoraClassic.VO;
using MySql.Data.MySqlClient;


namespace LocadoraClassic.DAL
{
    public class GeneroDAL
    {
        //Faz um CRUD ai?
        //INSER, DELETE, UPDATE, SELECT

        // metodo orientado a objeto
        public void IserirGenero(Genero genero) //Classe objeto
        {
            //Abrir a conexão
            Conexao.Instance.Open();  // A instancia é da classe, não do objeto

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand(); 
            // DML -> (INSERT - DELETE - UPDATE - SELECT)
            // STORED PROCEDURES -> (ALGORITMOS ARMAZENADOS NO BANCO), ao utilizar .Text os dados sao inseridos pelo codigo
            //ADO.NET -> BIBLIOTECA DE BANCO DE DADOS DO .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO genero(nome) values(@nome)"; // "@"  Proteção contra sql injection. não acha diretamente o valor pois ele passa por um parametro
            comando.Parameters.Add(new MySqlParameter("@nome", genero.Nome));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }
    }
}
