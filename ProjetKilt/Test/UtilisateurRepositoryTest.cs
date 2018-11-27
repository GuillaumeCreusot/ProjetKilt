using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;

namespace Test
{
    [TestClass]
    public class UtilisateurRepositoryTest
    {
        [TestMethod]
        public void TestGetAll()
        {
            IUtilisateurRepository users = new UtilisateurRepository();
            Utilisateur user1 = new Utilisateur("user1", 1);
            users.Save(user1);
            Utilisateur user2 = new Utilisateur("user2", 2);
            users.Save(user2);
            Utilisateur user3 = new Utilisateur("user3", 3);
            users.Save(user3);
        }
    }
}
