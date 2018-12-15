using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        bool Connect(Utilisateur user);

        bool Exist(string name);

        bool Exist(Utilisateur user);

        List<Utilisateur> GetAll();

        void Save(Utilisateur user);

        void Delete(Utilisateur user);

        void DeleteALL();
    }
}
