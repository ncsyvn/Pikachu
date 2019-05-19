using Game_Pikachu.Forms;
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


namespace Game_Pikachu
{
    public partial class PlayForm : Form
    {

        Sounds sound = new Sounds(@"C:\Users\SyVN\SoundPlay.mp3");
        int i_sounds = 1;
        public DataTable UserData = new DataTable();
        InitialProcessEvent InitialProcessPlay = new InitialProcessEvent();
        DrawPanelContainIcon drawPanelContainIcon = new DrawPanelContainIcon();
        ProcessPlay processPlay = new ProcessPlay();
        public PlayForm(DataTable UserData)

        {
            InitializeComponent();
            this.UserData = UserData;
            // Chạy timer, có tác dụng ở progressBar            
            timer.Start();
            InitialProcessPlay.ProcessEvent(drawPanelContainIcon, panelContainIcon);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
            if (progressBarTime.Value == 3000)
            {
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
            sound.Stop();
            this.Dispose();
            this.Close();
            this.Hide();
        }

        // Play again
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newPlayForm = new PlayForm(UserData);
            newPlayForm.StartPosition = FormStartPosition.CenterScreen;
            newPlayForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i_sounds++;
            PlayForm_Load(sender, e);
        }

    }
}
