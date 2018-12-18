using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICoureurRepository
    {
        /// <summary>
        /// Obtain all Coureur from db
        /// </summary>
        /// <returns></returns>
        List<Coureur> GetAll();

        /// <summary>
        /// SaveOrUpdate <paramref name="coureur"/> in DB
        /// </summary>
        /// <param name="coureur"></param>
        void Save(Coureur coureur);

        /// <summary>
        /// Verify if <paramref name="coureur"/> exist in db
        /// </summary>
        /// <param name="coureur"></param>
        /// <returns></returns>
        bool Exist(Coureur coureur);

        /// <summary>
        /// Delete <paramref name="coureur"/> from db and participations associated
        /// </summary>
        /// <param name="coureur"></param>
        void Delete(Coureur coureur);

        /// <summary>
        /// Delete all coureur in Db and participation associated
        /// </summary>
        void DeleteALL();

        /// <summary>
        /// Obtains all coureur from <paramref name="parti"/>
        /// </summary>
        /// <param name="parti"></param>
        /// <returns></returns>
        Coureur GetCoureurFromParti(Participation parti);
    }
}
