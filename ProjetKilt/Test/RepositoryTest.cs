using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CoureurRepositoryTest
    {
        [TestMethod]
        public void TestGetAll()
        {
            ICoureurRepository coureurs = new CoureurRepository();

            coureurs.DeleteALL();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur1);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur2);
            Coureur coureur3 = new Coureur("coureur3", "3", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur3);

            List<Coureur> result = coureurs.GetAll();

            Assert.IsTrue(result.Contains(coureur1));
            Assert.IsTrue(result.Contains(coureur2));
            Assert.IsTrue(result.Contains(coureur3));

            
        }

        [TestMethod]
        public void TestDeleteCoureur()
        {
            ICoureurRepository coureurs = new CoureurRepository();

            coureurs.DeleteALL();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur1);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur2);

            coureurs.Delete(coureur2);

            List<Coureur> result = coureurs.GetAll();

            Assert.IsTrue(result.Contains(coureur1));
            Assert.IsFalse(result.Contains(coureur2));
        }

        [TestMethod]
        public void TestExist()
        {
            ICoureurRepository coureurs = new CoureurRepository();

            coureurs.DeleteALL();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur1);

            Assert.IsTrue(coureurs.Exist(coureur1));

        }

        [TestMethod]
        public void TestDeleteAll()
        {
            ICoureurRepository coureurs = new CoureurRepository();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur1);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur2);

            coureurs.DeleteALL();

            List<Coureur> result = coureurs.GetAll();

            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestParticipation()
        {
            ICoureurRepository coureurs = new CoureurRepository();
            IParticipationRepository parts = new ParticipationRepository();
            ICourseRepository courses = new CourseRepository();

            parts.DeleteALL();
            coureurs.DeleteALL();
            courses.DeleteALL();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            
            Course course1 = new Course("", 42);
            
            Participation part1 = new Participation(coureur1, course1, 0, 42);

            coureur1.Participations.Add(part1);
            course1.Participations.Add(part1);

            coureurs.Save(coureur1);

            List<Coureur> result = coureurs.GetAll();

            Assert.IsTrue(result[0] == coureur1);

            coureurs.DeleteALL();


        }

        [TestMethod]
        public void TestConnection()
        {
            IUtilisateurRepository users = new UtilisateurRepository();

            users.DeleteALL();

            Utilisateur user1 = new Utilisateur("test", "J'aime les licornes");
            Utilisateur user2 = new Utilisateur("test", "123");
            Utilisateur user1b = new Utilisateur("test", "J'aime les licornes");

            users.Save(user1);

            Assert.IsTrue(users.Exist(user1));

            Assert.IsTrue(users.Connect(user1));
            Assert.IsFalse(users.Connect(user2));

            Assert.IsTrue(users.Connect(user1b));
        }
    }
}
