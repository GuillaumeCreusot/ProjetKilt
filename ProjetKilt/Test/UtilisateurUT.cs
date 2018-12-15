using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;


namespace Test
{
    [TestClass]
    public class UtilisateurUT
    {
        [TestMethod]
        public void TestHashMDP()
        {
            string mdp = "j'aime les licornes";

            byte[] result = Utilisateur.HashMDP(mdp);

            Console.WriteLine(result.ToString());

            byte[] result2 = Utilisateur.HashMDP(mdp);

            Assert.IsTrue(String.Join("", result) == String.Join("", result2));
        }

        [TestMethod]
        public void TestHashIsEqual()
        {
            string mdp1  = "j'aime les licornes";
            string mdp1b = "j'aime les licornes";
            string mdp2 = "j'aime la licorne";

            byte[] hash1 = Utilisateur.HashMDP(mdp1);
            byte[] hash1b = Utilisateur.HashMDP(mdp1b);
            byte[] hash2 = Utilisateur.HashMDP(mdp2);

            Assert.IsTrue(Utilisateur.HashIsEqual(hash1, hash1b));
            Assert.IsFalse(Utilisateur.HashIsEqual(hash1, hash2));
        }

        [TestMethod]
        public void TestIsEqual()
        {
            Utilisateur user1 = new Utilisateur("test1", "test1");
            Utilisateur user2 = new Utilisateur("test2", "test2");
            Utilisateur user3 = new Utilisateur("test1", "test1");

            Assert.IsTrue(user1.Equals(user3));
            Assert.IsFalse(user1.Equals(user2));
        }
    }
}
