using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    internal static class Program
    {
        public static MainMenu Menu { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WorkZone());
            MainMenu mainMenu = new MainMenu();
            Application.Run(mainMenu);
            if (mainMenu.DialogResult == DialogResult.OK)
                Application.Run(new WorkZone());
            //Application.Run(new New());
            //Application.Run(new DownLoad());


        }
    }
}
