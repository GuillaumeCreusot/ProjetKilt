﻿using System;
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

            List<Utilisateur> query = Session.Query<Utilisateur>().Where((u) => u.Nom == user.Nom).ToList();
            Utilisateur user2 = (query.Count == 0) ? null : query[0];

            if(user2 == null)
            {
                return false;
            }
            return user.Equals(user2);
        }

        public void Delete(Utilisateur user)
        {
            Session.Delete(user);
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Utilisateur").ExecuteUpdate();
        }

        public bool Exist(string name)
        {
            return Session.Query<Utilisateur>().Any(c => c.Nom == name);
        }

        public bool Exist(Utilisateur user)
        {
            return Session.Query<Utilisateur>().Any(c => c.Nom == user.Nom);
        }

        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur user)
        {
            if (Exist(user))
            {

            }
            else
            {
                Session.SaveOrUpdate(user);
            }

            
            Session.Flush();
        }
    }
}
