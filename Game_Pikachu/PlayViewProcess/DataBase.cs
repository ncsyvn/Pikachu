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
        public static string [] DanhSachNguoiChoi = new string[10];
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
        public void ThemNguoiChoi(string TenNguoiChoi,string GhiChu)
        {

        }

        public void CapNhatDiem(string TenNguoiChoi,int Diem,int Level, DateTime NgayChoi)
        {

        }

        public void SuaTenNguoiChoi(string TenCu, string TenMoi)
        {

        }

        public void XoaNguoiChoi(string TenNguoiChoi)
        {

        }

        public void BangXepHang()
        {

        }
        public static void get_User()
        {
            
            string SqlSelect_TenNguoiChoi = "Select Nguoi_Choi.Ten_Nguoi_Choi From Nguoi_Choi";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = SqlSelect_TenNguoiChoi;

            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            int NameIndex = reader.GetOrdinal("Ten_Nguoi_Choi");// 2
                            DanhSachNguoiChoi[i] = reader.GetString(NameIndex);
                            i++;
                            if (i > 10) break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            
        }
    }
}
