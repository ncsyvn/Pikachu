using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pikachu.Forms
{
    public partial class FrmGioiThieu : Form
    {
        public FrmGioiThieu()
        {
            InitializeComponent();
        }

        private void QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewSelectForm nv = new NewSelectForm();
            nv.Show();

        }
    }
}
