using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICoureurRepository
    {
        Coureur[] GetAll();

        void Save(Coureur coureur);

        bool Exist(Coureur coureur);

        void Delete(Coureur coureur);

        void DeleteALL();
    }
}
