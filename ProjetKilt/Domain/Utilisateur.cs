﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Domain
{
    public class Utilisateur : IEntity
    {
        public static SHA256 crypter = new SHA256CryptoServiceProvider();


        public virtual int ID { get; set; }
        public virtual string Nom { get; set; }
        public virtual byte[] MDPHash { get;  set; }



        public Utilisateur(string nom, byte[] mdpHash)
        {
            Nom = nom;
            MDPHash = mdpHash;
        }

        public Utilisateur(string nom, string mdp) : this(nom, Utilisateur.HashMDP(mdp))
        {

        }

        public Utilisateur()
        {

        }

        public override bool Equals(object obj)
        {
            if(obj is Utilisateur)
            {
                return ((Utilisateur)obj).Nom == Nom && Utilisateur.HashIsEqual(((Utilisateur)obj).MDPHash, MDPHash);
            }

            return false;
        }

        public static byte[] HashMDP(string mdp)
        {
             return crypter.ComputeHash(Encoding.UTF8.GetBytes(mdp));
        }

        public static bool HashIsEqual(byte[] hash1, byte[] hash2)
        {
            return hash1.SequenceEqual(hash2);
        }

        public override string ToString()
        {
            return $"nom: {Nom}\nmdp: {String.Join("", MDPHash)}";
        }
    }


}
