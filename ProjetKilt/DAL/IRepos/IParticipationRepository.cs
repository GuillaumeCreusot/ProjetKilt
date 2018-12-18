using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IParticipationRepository
    {
        /// <summary>
        /// Get all participation from DB
        /// </summary>
        /// <returns></returns>
        List<Participation> GetAll();

        /// <summary>
        /// Save or update <paramref name="part"/> in db
        /// </summary>
        /// <param name="part"></param>
        void Save(Participation part);

        /// <summary>
        /// Verify if <paramref name="part"/> exist
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        bool Exist(Participation part);

        /// <summary>
        /// Delete <paramref name="part"/> from DB
        /// </summary>
        /// <param name="part"></param>
        void Delete(Participation part);

        /// <summary>
        /// Delete all participation
        /// </summary>
        void DeleteALL();

        /// <summary>
        /// Get all participation from a course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        List<Participation> GetPartiFromCourse(Course course);

    }
}
