using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pikachu
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        #region Click to Button Start
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            Application.Run(new UserForm());

        }
        #endregion

        #region Click to Button Continue
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            buttonContinue.Visible = false;
        }
        #endregion

        #region Click to Button Guide
        private void buttonGuide_Click(object sender, EventArgs e)
        {
            buttonGuide.Visible = false;
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
        }

        #endregion

    }
}
