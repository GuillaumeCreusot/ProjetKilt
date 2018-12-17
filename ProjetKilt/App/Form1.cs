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
    public partial class Form1 : Form
    {

        private ICoureurRepository CoureurRepo { get; set; }
        private ICourseRepository CourseRepo { get; set; }
        private IParticipationRepository ParticipationRepo { get; set; }
        private Utilisateur UtilisateurConnecté { get; set; }


        public Form1()
        {
            InitializeComponent();

            CoureurRepo = new CoureurRepository();
            CourseRepo = new CourseRepository();
            ParticipationRepo = new ParticipationRepository();


            foreach (Course course in CourseRepo.GetAll())
            {
                listBoxCourses.Items.Add(course.Nom);
                listBoxCourses.SelectedIndex = 0;
            }


            comboBoxFilters.Items.Add("Aucun filtre");
            for (int i = 0; i < 12; i++)
            {
                comboBoxFilters.Items.Add("Age : " + i + "0-" + (i+1) + "0 ans");
            }
            comboBoxFilters.SelectedIndex = 0;

            ReloadDataGridView();
            
        }

        private void textBoxSearch_FocusChanged(object sender, EventArgs e)
        {
            TextBox textbox = ((TextBox)sender);
            if (textbox.Text == "")
                ((TextBox)sender).Text = "Rechercher...";
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox textbox = ((TextBox)sender);

            if (textbox.Text == "Rechercher...")
                ((TextBox)sender).Text = "";
        }



        private void ReloadDataGridView()
        {

            dataGridViewCoureurs.Rows.Clear();

            Course course = CourseRepo.GetAll()[listBoxCourses.SelectedIndex];

            List<Participation> Participations = ParticipationRepo.GetPartiFromCourse(course);
            Participations = Participations.OrderBy( e => e.Temps).ToList();

            for (int i = 0; i<Participations.Count; i++)
            {
                Participation parti = Participations[i];

                Coureur coureur = CoureurRepo.GetCoureurFromParti(parti);

                DataGridViewRow row = (DataGridViewRow)dataGridViewCoureurs.Rows[0].Clone();
                row.Cells[0].Value = i + 1; //Classementparti.NumDossard
                row.Cells[1].Value = coureur.Nom; //Nom
                row.Cells[2].Value = coureur.Prenom; //PréNom
                row.Cells[3].Value = parti.NumDossard; //Dossard
                row.Cells[4].Value = Convert.ToDouble(parti.Course.Kilometrage) / Convert.ToDouble(parti.Temps); //Vitesse Moy
                row.Cells[5].Value = Convert.ToDouble(parti.Temps) / Convert.ToDouble(parti.Course.Kilometrage); ; //Allure Moy
                row.Cells[6].Value = coureur.Age; //Age
                row.Cells[7].Value = coureur.Sexe; //Sexe
                row.Cells[8].Value = coureur.Mail; //Mail
                row.Cells[9].Value = coureur.LicenceFFA; //Licence FFA
                dataGridViewCoureurs.Rows.Add(row);
            }



        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }

        private void buttonIdentification_Click(object sender, EventArgs e)
        {
            if (buttonIdentification.Text == "S'identifier")
            {
                Connexion();
            }
            else if(buttonIdentification.Text == "Se déconnecter")
            {
                Déconnexion();
            }
        }

        private void Déconnexion()
        {
            UtilisateurConnecté = null;
            buttonImport.Enabled = false;
            dataGridViewCoureurs.ReadOnly = true;
            buttonIdentification.Text = "S'identifier";
            labelConnexion.Text = "";
        }

        private void Connexion()
        {
            Connexion Connexion = new Connexion();
            Connexion.ShowDialog();
            if (Connexion.User != null)
            {
                UtilisateurConnecté = Connexion.User;
                buttonImport.Enabled = true;
                dataGridViewCoureurs.ReadOnly = false;
                buttonIdentification.Text = "Se déconnecter";
                labelConnexion.Text = "Vous êtes connecté en tant que " + UtilisateurConnecté.Nom;
            }
            
        }
    }
}
