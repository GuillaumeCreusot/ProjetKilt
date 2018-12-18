using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;


namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch(Exception e)
            {
                MessageBox.Show("La Flemme :\n" + e.ToString(), "#Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            

        }
    }
}
