using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class Connexion : Form
    {
        /// <summary>
        /// User connected
        /// </summary>
        public Utilisateur User { get; private set; }

        /// <summary>
        /// Repository to communicate with bd
        /// </summary>
        private IUtilisateurRepository UserRepo { get; set; }

        public Connexion()
        {
            UserRepo = new UtilisateurRepository();
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            //tentative de connexion
            Utilisateur tentative = new Utilisateur(textBoxID.Text, textBoxMDP.Text);
            bool connexion = UserRepo.Connect(tentative);

            if (connexion)
            {
                User = tentative;
                Close();
            }
            else
                labelErreur.Visible = true;

        }

        private void textBoxMDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key = ENTER
            if (Convert.ToInt32(e.KeyChar) == 13)
                buttonConnexion_Click(buttonConnexion, new EventArgs()); // Yes, I know, but it works right ?
        }
    }
}
