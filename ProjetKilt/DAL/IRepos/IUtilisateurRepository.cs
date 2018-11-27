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
        Utilisateur[] GetAll();

        bool Connect(Utilisateur user);

        bool Exist(string name);

        void Save(Utilisateur user);
    }
}
