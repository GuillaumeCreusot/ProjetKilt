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
        public bool Connect(Utilisateur user)
        {
            Utilisateur user2 = Session.Query<Utilisateur>().Where((u) => u.Nom == user.Nom).LastOrDefault();

            if(user2 == null)
            {
                return false;
            }
            return user == user2;
        }

        public bool Exist(string name)
        {
            return Session.Query<Utilisateur>().Where((u) => u.Nom == name).Count() != 0;
        }

        public List<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Utilisateur user)
        {
            throw new NotImplementedException();
        }
    }
}
