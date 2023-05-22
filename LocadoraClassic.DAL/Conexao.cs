using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class Conexao
    {
        //Singleton
        //set e get
        //psquisar quando e porque usar "static"

        private static MySqlConnection _instance; //Variavel de apoio, instancia de conexão

        public static MySqlConnection Instance {  // variavel de propriedade
            get {
                if(_instance == null)
                {
                    _instance = new MySqlConnection(@"Server = 127.0.0.1;Database=locadoraclassic;Uid=root;Pwd= ");
                }
                return _instance; 
            }
        }
    }
}
