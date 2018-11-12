using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {


        public virtual int ID { get; private set; }
        public virtual string Nom { get; private set; }
        public virtual int MDPHash { get;  private set; }



        public Utilisateur(string nom, int mdpHash)
        {
            Nom = nom;
            MDPHash = mdpHash;
        }
    }


}
