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
        List<Course> GetAll();

        void Save(Course course);

        bool Exist(Course course);

        void Delete(Course course);

        void DeleteALL();

        void Flush();
    }
}
