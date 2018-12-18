using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICourseRepository
    {
        /// <summary>
        /// Get all Course
        /// </summary>
        /// <returns></returns>
        List<Course> GetAll();

        /// <summary>
        /// Save or Upadate <paramref name="course"/>
        /// </summary>
        /// <param name="course"></param>
        void Save(Course course);

        /// <summary>
        /// Verify if <paramref name="course"/> exist
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        bool Exist(Course course);

        /// <summary>
        /// Delete <paramref name="course"/> from db and all participation associated
        /// </summary>
        /// <param name="course"></param>
        void Delete(Course course);

        /// <summary>
        /// Delete all course from db and all participation associated
        /// </summary>
        void DeleteALL();
    }
}
