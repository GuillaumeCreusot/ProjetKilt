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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Utilisateur user = new Utilisateur("Utilisateur", "MDP");
            //Console.WriteLine(String.Join("", user.MDPHash));
            //15112197219145891274157616724218510817136252737015419615822418216916320823413958144242
        }
    }
}
