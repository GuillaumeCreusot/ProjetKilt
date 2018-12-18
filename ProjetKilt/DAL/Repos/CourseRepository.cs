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
            foreach (Participation part in course.Participations)
            {
                part.Participant.Participations.Remove(part);
                part.Participant = null;
            }

            Session.Delete(course);
            Session.Flush();
        }

        public void DeleteALL()
        {
            foreach (Course c in GetAll())
            {
                Delete(c);
            }
        }

        public bool Exist(Course course)
        {
            return Session.Query<Course>().Any(c => c.Nom == course.Nom);
        }

        public List<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }

        public void Save(Course course)
        {
            if (Exist(course))
            {
                Course course2 = GetAll().Where((u) => u.Nom == course.Nom).First();
                course2.Kilometrage = course.Kilometrage;
                course2.Participations = course.Participations;
                Session.SaveOrUpdate(course2);
            }
            else
            {
                Session.SaveOrUpdate(course);
                
            }
            Session.Flush();
        }
    }
}
