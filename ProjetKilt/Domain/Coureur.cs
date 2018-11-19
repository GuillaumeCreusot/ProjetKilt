using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coureur
    {


        public virtual int ID { get; private set; }
        public virtual string Nom { get; private set; }
        public virtual string Prenom { get; private set; }
        public virtual string LicenceFFA { get; private set; }
        public virtual string Mail { get; private set; }
        public virtual string Sexe { get; private set; }
        public virtual DateTime DateNaissance { get; private set; }

        public virtual IList<Participation> Participations { get; set; }
        public virtual IList<Sponsorise> Sponsorises { get; set; }



        public int Age { get; private set; }



        public Coureur(string nom, string prenom, string licenceFFA, string mail, string sexe, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            LicenceFFA = licenceFFA;
            Mail = mail;
            Sexe = sexe;
            DateNaissance = dateNaissance;
        }
    }
}
