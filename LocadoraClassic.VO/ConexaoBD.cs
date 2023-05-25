using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class ConexaoBD
    {
        public static string ConnectionStringBD { get; set; }
        public string Server { get; set; }
        public string UserID { get; set; }
        public string Password { get; set;}
        public string InitialCatalog { get; set; }
        
        
        public ConexaoBD(string connectionStringBD)
        {
            ConnectionStringBD = connectionStringBD;
        }

        public ConexaoBD()
        {

        }
        public ConexaoBD(string server, string userID, string password, string initialCatalog)
        {
            Server = server;
            UserID = userID;
            Password = password;
            InitialCatalog = initialCatalog;
        }
    }
}
