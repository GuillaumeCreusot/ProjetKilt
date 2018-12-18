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

            for(int i = 0; i < dico[dico.Keys.First()].Count; i++)
            {
                coureur = new Coureur();
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
