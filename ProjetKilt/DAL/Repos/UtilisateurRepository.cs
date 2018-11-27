using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public Utilisateur[] GetAll()
        {
            return Session.Query<Utilisateur>().ToArray();
        }

        public void Save(Utilisateur user)
        {
            Session.SaveOrUpdate(user);
            Session.Flush();
        }
    }
}
