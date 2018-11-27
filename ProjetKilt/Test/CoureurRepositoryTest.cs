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
            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur1);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur2);
            Coureur coureur3 = new Coureur("coureur3", "3", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            coureurs.Save(coureur3);

            Coureur[] result = coureurs.GetAll();



        }
    }
}
