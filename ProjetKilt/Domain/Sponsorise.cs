using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sponsorise
    {

        public virtual int ID { get; private set; }
        public virtual Sponsor Sponsor { get; private set; }
        public virtual Coureur Coureur { get; private set; }



        public Sponsorise(Sponsor sponsor, Coureur coureur)
        {
            Sponsor = sponsor;
            Coureur = coureur;
        }
    }
}
