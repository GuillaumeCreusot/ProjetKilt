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



        public Course(string nom, int kilometrage) : this()
        {
            Nom = nom;
            Kilometrage = kilometrage;
            Participations = new List<Participation>();
        }

        public Course()
        {
        }

        public override bool Equals(object obj)
        {
            if(obj is Course)
            {
                Course c = (Course)obj;
                return c.Kilometrage == Kilometrage && c.Nom == Nom;
            }
            return false;
        }

    }
}
