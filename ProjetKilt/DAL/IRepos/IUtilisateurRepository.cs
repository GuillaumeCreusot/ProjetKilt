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
        /// <summary>
        /// Protocol for <paramref name="user"/> connexion
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Connect(Utilisateur user);

        /// <summary>
        /// Verify if user with <paramref name="name"/> exist
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Exist(string name);

        /// <summary>
        /// Verify if <paramref name="user"/> exist
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Exist(Utilisateur user);

        /// <summary>
        /// Get all user from db
        /// </summary>
        /// <returns></returns>
        List<Utilisateur> GetAll();

        /// <summary>
        /// Save or update <paramref name="user"/> in DB
        /// </summary>
        /// <param name="user"></param>
        void Save(Utilisateur user);

        /// <summary>
        /// Delete <paramref name="user"/> from DB
        /// </summary>
        /// <param name="user"></param>
        void Delete(Utilisateur user);

        /// <summary>
        /// Delete all user from DB
        /// </summary>
        void DeleteALL();
    }
}
