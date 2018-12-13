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
            Session.Delete(coureur);
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Coureur").ExecuteUpdate();
        }

        public bool Exist(Coureur coureur)
        {
            return (long)Session.CreateQuery($"Select Count(*) from Coureur c where c.ID == coureur.ID").UniqueResult() > 0;
        }

        public List<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }
    }
}
