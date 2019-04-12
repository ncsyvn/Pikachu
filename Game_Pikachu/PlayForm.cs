using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Game_Pikachu
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
            // Chạy timer, có tác dụng ở progressBar
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // ProgressBar chạy thời gian.
            progressBarTime.PerformStep();
            SoundPlayer sound = new SoundPlayer(@"C:\Users\levan\Desktop\Slice bài giảng\Thực tập nhóm\Code\Pikachu\Game_Pikachu\Sounds\101-opening (online-audio-converter.com).wav");
            sound.LoadAsync();
            sound.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\levan\Desktop\Slice bài giảng\Thực tập nhóm\Code\Pikachu\Game_Pikachu\Sounds\101-opening (online-audio-converter.com).wav");
            sound.LoadAsync();
            sound.Stop();
        }
    }
}
