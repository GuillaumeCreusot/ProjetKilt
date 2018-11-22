using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {


        public virtual int ID { get; set; }
        public virtual string Nom { get; set; }
        public virtual int MDPHash { get;  set; }



        public Utilisateur(string nom, int mdpHash)
        {
            Nom = nom;
            MDPHash = mdpHash;
        }

        public Utilisateur()
        {

        }
    }


}
