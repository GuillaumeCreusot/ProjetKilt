using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sponsor
    {

        public virtual int ID { get; private set; }
        public virtual string Nom { get; private set; }



        public Sponsor(string nom)
        {
            Nom = nom;
        }
    }
}
