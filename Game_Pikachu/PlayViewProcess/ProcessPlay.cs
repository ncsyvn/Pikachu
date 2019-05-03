using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pikachu.PlayViewProcess
{
    public class ProcessPlay
    {
        public void ProcessEvent(DrawPanelContainIcon drawPanelContainIcon, Panel panelContainIcon)
        {
            drawPanelContainIcon = new DrawPanelContainIcon();
            Panel panel = new Panel();
            drawPanelContainIcon.ProcessRandomIcon(panelContainIcon);
        }
    }
}
