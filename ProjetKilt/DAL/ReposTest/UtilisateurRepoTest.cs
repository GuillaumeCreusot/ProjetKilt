using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UtilisateurRepoTest : Repository, IUtilisateurRepository
    {

        public List<Utilisateur> UtilisateurCollection;

        public UtilisateurRepoTest()
        {
            UtilisateurCollection = new List<Utilisateur>();

            Utilisateur utilisateur1 = new Utilisateur("utilisateur1", 1);
            UtilisateurCollection.Add(utilisateur1);
            Utilisateur utilisateur2 = new Utilisateur("utilisateur2", 2);
            UtilisateurCollection.Add(utilisateur2);
            Utilisateur utilisateur3 = new Utilisateur("utilisateur3", 3);
            UtilisateurCollection.Add(utilisateur3);
        }



        public Utilisateur[] GetAll()
        {

            return UtilisateurCollection.ToArray();

        }

        public void Save(Utilisateur utilisateur)
        {
            UtilisateurCollection.Add(utilisateur);
        }
    }
}
