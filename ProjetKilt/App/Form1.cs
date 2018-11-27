﻿using System;
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
        public Form1()
        {
            InitializeComponent();

            ICoureurRepository CoureurRepo = new CoureurRepoTest();
            ICourseRepository Courserepo = new CourseRepoTest();
            IUtilisateurRepository UserRepo = new UtilisateurRepoTest();
            IParticipationRepository ParticipationRepo = new ParticipationRepoTest();

            foreach(Course course in Courserepo.GetAll())
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
            
        }

        private void textBoxSearch_FocusChanged(object sender, EventArgs e)
        {
            TextBox textbox = ((TextBox)sender);

            if (textbox.Text == "Rechercher...")
                ((TextBox)sender).Text = "";
            else if (textbox.Text == "")
                ((TextBox)sender).Text = "Rechercher...";
            progressBar.Value += 4;
            if(progressBar.Value >= progressBar.Maximum)
                progressBar.Maximum *= 2;
        }
    }
}
