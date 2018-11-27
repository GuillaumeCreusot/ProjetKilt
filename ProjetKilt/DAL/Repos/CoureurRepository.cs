using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        public Coureur[] GetAll()
        {
            return Session.Query<Coureur>().ToArray();
        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }
    }
}
