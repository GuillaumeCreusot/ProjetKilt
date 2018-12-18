using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.ImportFromCSVToDB
{
    class ParticipationCSVToDB
    {
        public static void Import(Dictionary<string, List<string>> dico, Course course)
        {
            ParticipationCSVToDB.CSVContainsRightColumnLabel(dico);

            ParticipationCSVToDB.CSVContainsColumnWithSameNumberOfElement(dico);

            Participation part;
            Coureur coureur;

            IParticipationRepository repo = new ParticipationRepository();

            for(int i = 0; i < dico[dico.Keys.First()].Count; i++)
            {
                coureur = new Coureur(dico["nom"][i]
                    , dico["prenom"][i]
                    , dico["license"][i]
                    , dico["courriel"][i]
                    , dico["sexe"][i]
                    ,Convert.ToDateTime(dico["date_naissance"][i]));

                part = new Participation();
                part.Course = course;
                part.Participant = coureur;
                part.NumDossard = Convert.ToInt32(dico["dossard"][i]);
                if (dico.Keys.Contains("temps"))
                {
                    part.Temps = Convert.ToDouble(dico["temps"][i].Replace('.', ','));
                }

                repo.Save(part);

            }
        }

        private static bool CSVContainsColumnWithSameNumberOfElement(Dictionary<string, List<string>> dico)
        {
            bool test = true;
            int nbValue = -1;
            foreach (List<string> list in dico.Values)
            {
                if (nbValue == -1)
                {
                    nbValue = list.Count;
                }
                else
                {
                    if (nbValue != list.Count)
                    {
                        test = false;
                    }
                }
            }

            if (test)
            {
                throw new Exception("Dans le csv, les colonnes n'ont pas le même nombre d'élements.");
            }
            return true;
        }

        private static bool CSVContainsRightColumnLabel(Dictionary<string, List<string>> dico)
        {
            if (!(dico.Keys.Contains("dossard")
                && dico.Keys.Contains("temps")
                && dico.Keys.Contains("nom")
                && dico.Keys.Contains("prenom")
                && dico.Keys.Contains("annee_naissance")
                && dico.Keys.Contains("sexe")
                && dico.Keys.Contains("courriel")
                && dico.Keys.Contains("license")
                ||
                dico.Keys.Contains("dossard")
                && dico.Keys.Contains("nom")
                && dico.Keys.Contains("prenom")
                && dico.Keys.Contains("annee_naissance")
                && dico.Keys.Contains("sexe")
                && dico.Keys.Contains("courriel")
                && dico.Keys.Contains("license")))
            {
                throw new Exception("Dans le Csv, il manque une colonne pour l'import des résultats" +
                    " (\"nom\",\"prenom\",\"annee_naissance\",\"sexe\"" +
                    ",\"courriel\",\"license\",\"dossard\" et \"temps\"");
                return false;
            }
            return true;
        }
    }
}
