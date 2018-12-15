using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepoTest : Repository, ICourseRepository
    {

        public List<Course> CourseCollection;

        public CourseRepoTest()
        {
            CourseCollection = new List<Course>();

            Course course1 = new Course("course1", 1);
            CourseCollection.Add(course1);
            Course course2 = new Course("course2", 2);
            CourseCollection.Add(course2);
            Course course3 = new Course("course3", 3);
            CourseCollection.Add(course3);
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteALL()
        {
            throw new NotImplementedException();
        }

        public bool Exist(Course course)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {

            return CourseCollection;

        }

        public void Save(Course course)
        {
            CourseCollection.Add(course);
        }
    }
}
