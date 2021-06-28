using System;
using System.Windows.Forms;

namespace JeuWinForms {

    internal static class Program {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main mdi = new Main();
            mdi.WindowState = FormWindowState.Maximized;
            Application.Run(mdi);
        }
    }
}