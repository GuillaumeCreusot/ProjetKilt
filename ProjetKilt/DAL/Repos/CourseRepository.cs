using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {
        public void Delete(Course course)
        {
            Session.Delete(course);
        }

        public void DeleteALL()
        {
            throw new NotImplementedException();
        }

        public bool Exist(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
