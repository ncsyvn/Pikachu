using Game_Pikachu.PlayViewProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Game_Pikachu
{
    public partial class UserForm : Form
    {
        Sounds sound1 = new Sounds(@"C:\Users\levan\Desktop\Pikachu\Game_Pikachu\Sounds and img Sounds\Content\102-palette town theme.mp3");
        int i_sounds1 = 1;
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            sound1.Stop();
            PlayForm pf = new PlayForm();
            pf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            i_sounds1++;
            UserForm_Load(sender, e);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (i_sounds1 % 2 == 0)
            {
                sound1.Pause();
            }
            else
            {
                sound1.Resume();
            }
        }
        public void Load_DanhSachNguoiChoi()
        {
            DataBase.Connection();

            string SqlSelect_TenNguoiChoi = "Select Nguoi_Choi.Ten_Nguoi_Choi From Nguoi_Choi";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DataBase.conn;
            cmd.CommandText = SqlSelect_TenNguoiChoi;

            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    var ListUser = new DataTable();
                    ListUser.Load(reader);
                    reader.Dispose();
                    this.comboBox1.DataSource = ListUser;
                    this.comboBox1.DisplayMember = "Ten_Nguoi_Choi";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
