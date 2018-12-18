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
using System.Text.RegularExpressions;
using System.IO;

namespace App
{
    public partial class MainForm : Form
    {

        private ICoureurRepository CoureurRepo { get; set; }
        private ICourseRepository CourseRepo { get; set; }
        private IParticipationRepository ParticipationRepo { get; set; }
        private Utilisateur UtilisateurConnecté { get; set; }
        private bool Initializing { get; set; }


        public MainForm()
        {
            InitializeComponent();

            Initializing = true;

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

            Initializing = false;

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
            loadingBar(0);
            dataGridViewCoureurs.Rows.Clear();

            Course course = CourseRepo.GetAll()[listBoxCourses.SelectedIndex];
            loadingBar(25);

            List<Participation> Participations = ParticipationRepo.GetPartiFromCourse(course);
            loadingBar(50);
            Participations = Participations.OrderBy( e => e.Temps).ToList();
            loadingBar(75);

            for (int i = 0; i<Participations.Count; i++)
            {
                Participation parti = Participations[i];

                Coureur coureur = CoureurRepo.GetCoureurFromParti(parti);

                string query = textBoxSearch.Text;
                int indexFilter = comboBoxFilters.SelectedIndex;
                string filter = comboBoxFilters.Items[indexFilter].ToString();
                
                if ((query == "" || query == "Rechercher..." ||
                    Regex.IsMatch(coureur.Nom.ToLower(), $"^{query.ToLower()}" ) ||
                    Regex.IsMatch(coureur.Prenom.ToLower(), $"^{query.ToLower()}")  ||
                    Regex.IsMatch(parti.NumDossard.ToString().ToLower(), $"^{query.ToLower()}"))  &&
                    (filter == "Aucun filtre" ||
                    (coureur.Age >= (indexFilter - 1) * 10 && coureur.Age <= indexFilter * 10)))
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewCoureurs.Rows[0].Clone();
                    row.Cells[0].Value = i + 1; //Classement
                    row.Cells[1].Value = coureur.Nom; //Nom
                    row.Cells[2].Value = coureur.Prenom; //PréNom
                    row.Cells[3].Value = parti.NumDossard; //Dossard
                    row.Cells[4].Value = (Convert.ToDouble(parti.Temps) != 0) ? Convert.ToDouble(parti.Course.Kilometrage) / Convert.ToDouble(parti.Temps) : 0; //Vitesse Moy
                    row.Cells[5].Value = (Convert.ToDouble(parti.Course.Kilometrage) != 0) ? Convert.ToDouble(parti.Temps) / Convert.ToDouble(parti.Course.Kilometrage) : 0 ; //Allure Moy
                    row.Cells[6].Value = coureur.Age; //Age
                    row.Cells[7].Value = coureur.Sexe; //Sexe
                    row.Cells[8].Value = coureur.Mail; //Mail
                    row.Cells[9].Value = coureur.LicenceFFA; //Licence FFA
                    dataGridViewCoureurs.Rows.Add(row);
                }

                loadingBar(75 + 25 * ((i + 1) / Participations.Count));
            }



        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Initializing)
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
            buttonImportParti.Enabled = false;
            buttonImportResultats.Enabled = false;
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
                buttonImportParti.Enabled = true;
                buttonImportResultats.Enabled = true;
                buttonIdentification.Text = "Se déconnecter";
                labelConnexion.Text = "Vous êtes connecté en tant que " + UtilisateurConnecté.Nom;
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!Initializing)
                ReloadDataGridView();
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Initializing)
                ReloadDataGridView();
        }

        private void buttonImportParti_Click(object sender, EventArgs e)
        {
            FileInfo filePath = FileBrowser.GetFileByBrowser(Application.StartupPath
                , "les participants de cette course", "csv");
        }

        private void buttonImportResultats_Click(object sender, EventArgs e)
        {
            FileInfo filePath = FileBrowser.GetFileByBrowser(Application.StartupPath
                , "les résultats de cette course", "csv");

        }

        private void loadingBar(double value)
        {
            if(value >= 0 && value <= 100)
            {
                progressBar.Value = Convert.ToInt32(Math.Ceiling(value));
            }
        }

        private void comboBoxFilters_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
