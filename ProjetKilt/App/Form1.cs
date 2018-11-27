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
        public Form1()
        {
            InitializeComponent();

            IUtilisateurRepository repo = new UtilisateurRepository();
            label1.Text = repo.GetAll().Length.ToString();

            Utilisateur user = new Utilisateur("test", 2132184135);
            repo.Save(user);

            label1.Text = repo.GetAll().Length.ToString();
            
        }
    }
}
