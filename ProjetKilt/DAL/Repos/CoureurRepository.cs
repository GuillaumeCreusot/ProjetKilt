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
        public void Delete(Coureur coureur)
        {
            throw new NotImplementedException();
        }

        public void DeleteALL()
        {
            throw new NotImplementedException();
        }

        public bool Exist(Coureur coureur)
        {
            return Session.Query<Coureur>().Where((c) => c == coureur).LastOrDefault() != null;
        }

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
