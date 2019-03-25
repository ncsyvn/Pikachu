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
    public partial class NewSelectForm : Form
    {
        public NewSelectForm()
        {
            InitializeComponent();
        }

        #region Click to Button Start
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            Form UserForm1 = new UserForm();
            //UserForm1.WindowState = 
            UserForm1.Show();

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
