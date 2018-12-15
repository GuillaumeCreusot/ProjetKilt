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
            return Session.Query<Coureur>().Any(c => c == coureur);
        }

        public List<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }

    }
}
