using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class CoureurTest
    {
        [TestMethod]
        public void TestAge()
        {
            Coureur coureur = new Coureur("test", "test", "TEST", "test@gmail.com", "test",
                new DateTime(1997, 2, 16));

            Assert.IsTrue(coureur.Age == 21);

            Coureur coureur2 = new Coureur("test", "test", "TEST", "test@gmail.com", "test",
                new DateTime(1997, 12, 18));

            Assert.IsTrue(coureur2.Age == 20);
        }
    }
}
