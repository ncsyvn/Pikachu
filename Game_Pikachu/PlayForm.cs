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

    }
}
