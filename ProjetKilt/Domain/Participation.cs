using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Participation : IEntity
    {

        public virtual int ID { get; set; }
        public virtual Coureur Participant { get; set; }
        public virtual Course Course { get; set; }
        public virtual int NumDossard { get; set; }
        public virtual DateTime Temps { get; set; }



        //public int Classement { get; private set; }
        //public double VitesseMoyenne { get; private set; }
        //public double AllureMoyenne { get; private set; }



        public Participation(Coureur participant, Course course, int numDossard, DateTime temps)
        {
            Participant = participant;
            Course = course;
            NumDossard = numDossard;
            Temps = temps;
        }

        public Participation()
        {

        }
    }
}
