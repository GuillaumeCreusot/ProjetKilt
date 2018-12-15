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
            List<Utilisateur> query = Session.Query<Utilisateur>().Where((u) => u.Nom == user.Nom).ToList<Utilisateur>();
            Utilisateur user2 = (query.Count == 0) ? null : query[0];

            if(user2 == null)
            {
                return false;
            }
            return user == user2;
        }

        public void Delete(Utilisateur user)
        {
            var query = Session.CreateQuery("delete from Utilisateur where Nom = :nom and MDPHash = :mdp");
            query.SetParameter("nom", user.Nom);
            query.SetParameter("mdp", user.MDPHash);
            query.ExecuteUpdate();
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Utilisateur").ExecuteUpdate();
        }

        public bool Exist(string name)
        {
            return Session.Query<Utilisateur>().Any(c => c.Nom == name);
        }

        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur user)
        {
            Session.SaveOrUpdate(user);
            Session.Flush();
        }
    }
}
