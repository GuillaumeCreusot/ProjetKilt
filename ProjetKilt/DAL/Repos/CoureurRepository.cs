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
            var query = Session.CreateQuery("delete from Coureur where Id = :Id");
            query.SetParameter("Id", coureur.ID);
            query.ExecuteUpdate();
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Coureur").ExecuteUpdate();
        }

        public bool Exist(Coureur coureur)
        {
            return Session.Query<Coureur>().Any(c => c == coureur);
        }

        public List<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
        }

        public void Flush()
        {
            Session.Flush();
        }
    }
}
