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
            var query = Session.CreateQuery("delete from Course where Id = :Id");
            query.SetParameter("Id", course.ID);
            query.ExecuteUpdate();
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Course").ExecuteUpdate();
        }

        public bool Exist(Course course)
        {
            return Session.Query<Course>().Any(c => c == course);
        }

        public List<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }

        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
        }

        public void Flush()
        {
            Session.Flush();
        }
    }
}
