using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipationRepoTest : Repository, IParticipationRepository
    {

        public List<Participation> ParticipationCollection;

        public ParticipationRepoTest()
        {
            ParticipationCollection = new List<Participation>();

            Coureur coureur1 = new Coureur("coureur1", "1", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            Coureur coureur2 = new Coureur("coureur2", "2", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);
            Coureur coureur3 = new Coureur("coureur3", "3", "XXXXXXXXX", "XXX@gmail.com", "X", DateTime.Today);

            Course course1 = new Course("course1", 1);
            Course course2 = new Course("course2", 2);

            Participation participation1 = new Participation(coureur1, course1, 042, 10);
            ParticipationCollection.Add(participation1);
            Participation participation2 = new Participation(coureur2, course1, 240, 12);
            ParticipationCollection.Add(participation2);
            Participation participation3 = new Participation(coureur1, course2, 420, 110);
            ParticipationCollection.Add(participation3);
        }



        public Participation[] GetAll()
        {

            return ParticipationCollection.ToArray();

        }

        public void Save(Participation participation)
        {
            ParticipationCollection.Add(participation);
        }
    }
}