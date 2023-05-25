using System.Data.SqlClient;
using LocadoraClassic.VO;

namespace LocadoraClassic.DAL
{
    public class Conexao2
    {
        //Singleton
        //set e get
        //psquisar quando e porque usar "static"

        private static SqlConnection _sqlcon; //Variavel de apoio, instancia de conexão
        public static SqlConnection Sqlcon // variavel de propriedade
        {
            get
            {
                if (_sqlcon == null)
                {
                    _sqlcon = new SqlConnection(ConexaoBD.ConnectionStringBD);
                }
                return _sqlcon;
            }
        }
    }
}