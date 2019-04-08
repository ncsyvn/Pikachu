using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pikachu
{
    static class Program
    {
        static public MenuGame menu;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new PlayForm());
=======
            menu=new MenuGame();
            menu.Show();
            Application.Run();
>>>>>>> master
        }
    }
}
