using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IParticipationRepository
    {
        List<Participation> GetAll();

        void Save(Participation part);

        bool Exist(Participation part);

        void Delete(Participation part);

        void DeleteALL();

        void Flush();
    }
}
