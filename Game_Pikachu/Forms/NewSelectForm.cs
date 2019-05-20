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
using Game_Pikachu.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Game_Pikachu
{
    public partial class NewSelectForm : Form
    {
        Sounds sound2 = new Sounds(@"C:\Users\SyVN\SoundSelect.mp3");
        int i_sounds2 = 1;
        public NewSelectForm()
        {
            InitializeComponent();
        }

        #region Click to Button Start
        private void buttonStart_Click(object sender, EventArgs e)
        {
           
            buttonStart.Visible = false;
            this.Hide();
            sound2.Stop();
            Form UserForm1 = new UserForm();
            //UserForm1.WindowState =
            UserForm1.Show();
            

        }
        #endregion

        #region Click to Button Continue
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            buttonContinue.Visible = false;
            this.Hide();
            PlayForm pf = new PlayForm(Load_UserData("a"), "a");
            pf.Show();
        }
        #endregion

        #region Click to Button Guide
        private void buttonGuide_Click(object sender, EventArgs e)
        {
            buttonGuide.Visible = false;
            Form FormHuongDan = new FormHuongDan();
            FormHuongDan.Show();
        }
        #endregion

        #region Click to Button About
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            buttonAbout.Visible = false;
        }
        #endregion

        #region Click to Button Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            buttonExit.Visible = false;
            this.Close();
        }


        #endregion

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            i_sounds2++;
            NewSelectForm_Load(sender, e);
        }

        private void NewSelectForm_Load(object sender, EventArgs e)
        {
            if (i_sounds2 % 2 == 0)
            {
                labelSound.Visible = false;
                sound2.Pause();
            }
            else
            {
                labelSound.Visible = true;
                sound2.Resume();
            }
        }
        public DataTable Load_UserData(string UserName)
        {
            var UserData = new DataTable();
            try
            {
                DataBase.Connection();

                string SqlSelect_TenNguoiChoi = "Select Nguoi_Choi.Ten_Nguoi_Choi,Diem,Level_Choi From Nguoi_Choi Where Ten_Nguoi_Choi = '" + UserName+"'";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DataBase.conn;
                cmd.CommandText = SqlSelect_TenNguoiChoi;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    UserData.Load(reader);
                    reader.Dispose();
                    DataBase.DisConnection();
                }                   
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return UserData;
        }
    }
}
