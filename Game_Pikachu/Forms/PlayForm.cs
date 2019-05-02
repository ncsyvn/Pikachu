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
        public PlayForm()
        {
            InitializeComponent();
            // Chạy timer, có tác dụng ở progressBar
            timer.Start();
            DrawPanelContainIcon drawPanelContainIcon = new DrawPanelContainIcon();
            drawPanelContainIcon.ProcessRandomIcon(panelContainIcon);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // ProgressBar chạy thời gian.
            progressBarTime.PerformStep();
        }

        // Exit Game
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Play again
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newPlayForm = new PlayForm();
            newPlayForm.StartPosition = FormStartPosition.CenterScreen;
            newPlayForm.Show();
        }
    }
}
