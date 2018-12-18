using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        public Coureur GetCoureurFromParti(Participation parti)
        {

            List<Coureur> query = Session.Query<Coureur>().Where((u) => u.ID == parti.Participant.ID).ToList();
            Coureur coureur = (query.Count == 0) ? null : query[0];

            return coureur;
        }

        public void Delete(Coureur coureur)
        {
            foreach(Participation part in coureur.Participations)
            {
                part.Course.Participations.Remove(part);
                part.Course = null;
            }

            Session.Delete(coureur);
            Session.Flush();
        }

        public void DeleteALL()
        {
            foreach(Coureur c in GetAll())
            {
                Delete(c);
            }
        }

        public bool Exist(Coureur coureur)
        {
            return Session.Query<Coureur>().Any(c => c.Nom == coureur.Nom);
        }

        public List<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public void Save(Coureur coureur)
        {
            if (Exist(coureur))
            {
                Coureur coureur2 = GetAll().Where((u) => u.Nom == coureur.Nom).First();
                coureur2.Prenom = coureur.Prenom;
                coureur2.LicenceFFA = coureur.LicenceFFA;
                coureur2.Mail = coureur.Mail;
                coureur2.Sexe = coureur.Sexe;
                coureur2.Participations = coureur.Participations;
                Session.SaveOrUpdate(coureur2);
            }
            else
            {
                Session.SaveOrUpdate(coureur);
            }
            
            Session.Flush();
        }

    }
}
