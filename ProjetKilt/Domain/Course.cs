using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course : IEntity
    {

        public virtual int ID { get; set; }
        public virtual string Nom { get; set; }
        public virtual int Kilometrage { get; set; }

        public virtual IList<Participation> Participations { get; set; }



        public Course(string nom, int kilometrage)
        {
            Nom = nom;
            Kilometrage = kilometrage;
        }

        public Course()
        {

        }

    }
}
