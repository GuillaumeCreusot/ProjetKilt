using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepoTest : Repository, ICoureurRepository
    {

        public List<Coureur> CoureurCollection;

        public CoureurRepoTest()
        {
            CoureurCollection = new List<Coureur>();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            CoureurCollection.Add( coureur1);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            CoureurCollection.Add(coureur2);
            Coureur coureur3 = new Coureur("coureur3", "3", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            CoureurCollection.Add(coureur3);
        }

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
            throw new NotImplementedException();
        }

        public Coureur[] GetAll()
        {

            return CoureurCollection.ToArray();

        }

        public void Save(Coureur coureur)
        {
            CoureurCollection.Add(coureur);
        }
    }
}
