using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDapper
{
    public class Dapper
    {
        protected readonly SqlConnection _cs;

        public static string CadenaDeConexion = "server=SERVERNAME;database=DATABASENAME;uid=USER;password=PASSWORD ";
       
        public Dapper()
        {
            _cs = new SqlConnection(CadenaDeConexion);
        }


        public IEnumerable<AreaEntity> GetAll()
        {
            try
            {
                return _cs.Query<AreaEntity>("SELECT * FROM Area");
            }
            catch (SqlException sqlex)
            {
                throw new ArgumentException($"Error al obtener los registros en la base de datos. Error número: {sqlex.Number}");
            }
        }
    }
}
