using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace Game_Pikachu.PlayViewProcess
{
    class DataBase
    {
        public static SqlConnection conn = DBUtils.GetDBConnection();
        public static void Connection()
        {

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+ e.Message);
            }
        }

        public static void DisConnection()
        {
            conn.Close();
        }
    }
}
