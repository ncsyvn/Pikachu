using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Game_Pikachu.PlayViewProcess
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-SIBM61D";

            string database = "Game_Pikachu";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
