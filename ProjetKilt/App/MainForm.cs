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
        private IUtilisateurRepository UserRepo { get; set; }
        private Utilisateur UtilisateurConnecté { get; set; }
        private bool Initializing { get; set; }


        public MainForm()
        {
            InitializeComponent();

            Initializing = true;

            CoureurRepo = new CoureurRepository();
            CourseRepo = new CourseRepository();
            ParticipationRepo = new ParticipationRepository();
            UserRepo = new UtilisateurRepository();
            if(!UserRepo.Exist(new Utilisateur("admin", "admin")))
                UserRepo.Save(new Utilisateur("admin", "admin"));


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
                    row.Cells[4].Value = ((parti.Temps != 0) ? Math.Truncate(parti.Course.Kilometrage / (parti.Temps / 3600) * 100) / 100 : 0) + " km/h"; //Vitesse Moy

                    if (parti.Course.Kilometrage != 0) //Allure
                    {
                        double temps = parti.Temps / parti.Course.Kilometrage;
                        int h = Convert.ToInt32(temps) / 3600;
                        temps = temps % 3600;
                        string allure = ((h / 10 > 1) ? h.ToString() : "0" + h.ToString()) + "h ";

                        int mn = Convert.ToInt32(temps) / 60;
                        temps = temps % 60;
                        allure += ((mn / 10 > 1) ? mn.ToString() : "0" + mn.ToString()) + "mn ";

                        temps = Convert.ToInt32(temps);
                        allure += ((temps / 10 > 1) ? temps.ToString() : "0" + temps.ToString()) + "s / km";

                        row.Cells[5].Value = allure;
                    }
                    else
                        row.Cells[5].Value = "00h 00mn 00s";

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
            loadingBar(0);
            UtilisateurConnecté = null;
            loadingBar(20);
            buttonImportParti.Enabled = false;
            loadingBar(50);
            buttonIdentification.Text = "S'identifier";
            loadingBar(80);
            labelConnexion.Text = "";
            loadingBar(100);
        }

        private void Connexion()
        {
            loadingBar(0);
            Connexion Connexion = new Connexion();
            loadingBar(50);
            Connexion.ShowDialog();
            if (Connexion.User != null)
            {
                UtilisateurConnecté = Connexion.User;
                loadingBar(60);
                buttonImportParti.Enabled = true;
                loadingBar(80);
                buttonIdentification.Text = "Se déconnecter";
                loadingBar(90);
                labelConnexion.Text = "Vous êtes connecté en tant que " + UtilisateurConnecté.Nom;
            }
            loadingBar(100);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!Initializing && textBoxSearch.Text != "Rechercher...")
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

            Dictionary<string, List<string>> dico = ImportCsvBrut.ImportCsv(filePath.FullName);
            ParticipationCSVToDB.Import(dico, CourseRepo.GetAll()[listBoxCourses.SelectedIndex]);

            ReloadDataGridView();
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
