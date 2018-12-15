using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipationRepository : Repository, IParticipationRepository
    {
        public void Delete(Participation part)
        {
            var query = Session.CreateQuery("delete from Participation where Id = :Id");
            query.SetParameter("Id", part.ID);
            query.ExecuteUpdate();
        }

        public void DeleteALL()
        {
            Session.CreateQuery("delete from Participation").ExecuteUpdate();
        }

        public bool Exist(Participation part)
        {
            return Session.Query<Participation>().Any(c => c == part);
        }

        public List<Participation> GetAll()
        {
            return Session.Query<Participation>().ToList();
        }

        public void Save(Participation part)
        {
            Session.SaveOrUpdate(part);
        }

        public void Flush()
        {
            Session.Flush();
        }
    }
}
