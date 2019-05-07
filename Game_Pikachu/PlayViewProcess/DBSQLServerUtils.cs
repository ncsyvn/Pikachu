using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Game_Pikachu.PlayViewProcess
{
    class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database)
        {
    
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security = true" ;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
