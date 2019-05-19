using Game_Pikachu.Forms;
using Game_Pikachu.PlayViewProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Pikachu
{
    public partial class PlayForm : Form
    {

        Sounds sound = new Sounds(@"C:\Users\SyVN\SoundPlay.mp3");
        int i_sounds = 1;
        public DataTable UserData = new DataTable();
        public string name;
        InitialProcessEvent InitialProcessPlay = new InitialProcessEvent();
        DrawPanelContainIcon drawPanelContainIcon = new DrawPanelContainIcon();
        ProcessPlay processPlay = new ProcessPlay();
        public PlayForm(DataTable UserData, string name)

        {
            InitializeComponent();
            this.UserData = UserData;
            this.name = name;
            // Chạy timer, có tác dụng ở progressBar            
            timer.Start();
            InitialProcessPlay.ProcessEvent(drawPanelContainIcon, panelContainIcon);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
            if (progressBarTime.Value == 3000)
            {
                Update_Mark(name);
                timer.Stop();
                EndGame endGame = new EndGame();
                endGame.Show();
            }
            else
            {
                labelHelp.Text = DrawPanelContainIcon.help.ToString();
                labelMark.Text= DrawPanelContainIcon.mark.ToString();
            }

        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // ProgressBar chạy thời gian.
            progressBarTime.PerformStep();

            if (i_sounds % 2 == 0)
            {
                labelSound.Visible = false;
                sound.Pause();
            }
            else
            {
                labelSound.Visible = true;
                sound.Resume();
            }

        }

        // Exit Game
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Update_Mark(name);
            sound.Stop();
            this.Dispose();
            this.Close();
            this.Hide();
        }

        // Play again
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newPlayForm = new PlayForm(UserData, name);
            newPlayForm.StartPosition = FormStartPosition.CenterScreen;
            newPlayForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i_sounds++;
            PlayForm_Load(sender, e);
        }

        // Cập nhật điểm sau khi hết thời gian hoặc click nút exit
        public void Update_Mark(string UserName)
        {
            DateTime dateTime = DateTime.Now;
            string time = "'"+dateTime.Date.Year + "-" + dateTime.Date.Month + "-" + dateTime.Date.Day + "'";
            try
            {

                DataBase.Connection();

                string SqlUpdate_Mark = "Exec Cap_Nhat_Diem N'" + UserName + "'," + labelMark.Text + ",1,"+time;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DataBase.conn;
                cmd.CommandText = SqlUpdate_Mark;
                cmd.ExecuteReader();
                DataBase.DisConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }


    }
}
