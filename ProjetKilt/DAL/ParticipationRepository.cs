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
        public Participation[] GetAll()
        {
            return Session.Query<Participation>().ToArray();
        }

        public void Save(Participation part)
        {
            Session.SaveOrUpdate(part);
            Session.Flush();
        }
    }
}
