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
        public Utilisateur User { get; private set; }
        private IUtilisateurRepository UserRepo { get; set; }

        public Connexion()
        {
            UserRepo = new UtilisateurRepository();
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
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
    }
}
