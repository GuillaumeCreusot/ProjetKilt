using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {

        public virtual int ID { get; private set; }
        public virtual string Nom { get; private set; }
        public virtual int Kilometrage { get; private set; }



        public Course(string nom, int kilometrage)
        {
            Nom = nom;
            Kilometrage = kilometrage;
        }


    }
}
