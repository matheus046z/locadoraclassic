using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Org.BouncyCastle.Security;
using LocadoraClassic.VO;

namespace LocadoraClassic.DAL
{
    public class Conexao2
    {
        public object DataSource { get; set; }

        private static SqlConnection _sqlcon;

        public static SqlConnection Sqlcon
        {
            get
            {
                if (_sqlcon == null)
                {
                    _sqlcon = new SqlConnection(@"Initial Catalog=locadoraclassic;User ID=Matheus;Password=zmThe$19-03sql; Server=177.235.71.5");
                }
                return _sqlcon;
            }
        }
    }
}