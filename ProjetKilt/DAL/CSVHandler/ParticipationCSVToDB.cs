using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipationCSVToDB
    {
        /// <summary>
        /// This function convert the data give by ImportCsvBrut to Participation and transfer it to db
        /// </summary>
        /// <param name="dico"></param>
        /// <param name="course"></param>
        public static void Import(Dictionary<string, List<string>> dico, Course course)
        {

            ParticipationCSVToDB.CSVContainsRightColumnLabel(dico);

            ParticipationCSVToDB.CSVContainsColumnWithSameNumberOfElement(dico);

            Participation part;
            Coureur coureur;

            // Save data in db
            IParticipationRepository repo = new ParticipationRepository();

            for(int i = 0; i < dico[dico.Keys.First()].Count; i++)
            {
                coureur = new Coureur(dico["nom"][i]
                    , dico["prenom"][i]
                    , dico["licence"][i]
                    , dico["courriel"][i]
                    , dico["sexe"][i]
                    ,Convert.ToDateTime(dico["annee_naissance"][i]));

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

        //Verify if the data contains same number of element in each column
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

            if (!test)
            {
                throw new Exception("Dans le csv, les colonnes n'ont pas le même nombre d'élements.");
            }
            return true;
        }

        /// <summary>
        /// Verify if the column label nom,prenom,annee_naissance,sexe ,courriel,license,dossard et temps sont présent
        /// </summary>
        /// <param name="dico"></param>
        /// <returns></returns>
        private static bool CSVContainsRightColumnLabel(Dictionary<string, List<string>> dico)
        {
            if (!((dico.ContainsKey("dossard")
                && dico.ContainsKey("temps")
                && dico.ContainsKey("nom")
                && dico.ContainsKey("prenom")
                && dico.ContainsKey("annee_naissance")
                && dico.ContainsKey("sexe")
                && dico.ContainsKey("courriel")
                && dico.ContainsKey("licence"))))
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
