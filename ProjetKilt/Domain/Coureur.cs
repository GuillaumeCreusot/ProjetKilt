using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coureur : IEntity
    {


        public virtual int ID { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string LicenceFFA { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Sexe { get; set; }
        public virtual DateTime DateNaissance { get; set; }

        public virtual IList<Participation> Participations { get; set; }


        
        public virtual int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DateNaissance.Year;
                if(!(DateNaissance.Month < today.Month ||
                    DateNaissance.Month == today.Month && DateNaissance.Day < today.Day))
                {
                    age -= 1;
                }
                return age;
            }
        }



        public Coureur(string nom, string prenom, string licenceFFA, string mail, string sexe, DateTime dateNaissance) : this()
        {
            Nom = nom;
            Prenom = prenom;
            LicenceFFA = licenceFFA;
            Mail = mail;
            Sexe = sexe;
            DateNaissance = dateNaissance;

            Participations = new List<Participation>();
        }

        public override bool Equals(object obj)
        {
            if(obj is Coureur)
            {
                Coureur c = (Coureur)obj;
                return c.LicenceFFA == LicenceFFA && c.Nom == Nom && c.Prenom == Prenom
                    && c.Mail == Mail && c.Sexe == Sexe && c.DateNaissance == DateNaissance;
            }
            return false;
        }

        public Coureur()
        {
        }
    }
}
