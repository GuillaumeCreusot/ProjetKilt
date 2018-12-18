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
        public static void Import(Dictionary<string, List<string>> dico)
        {
            if(dico.Keys.Contains("dossard") && dico.Keys.Contains("temps"))
            {

            }
            else
            {
                throw new Exception("Csv colonne label manquant pour l'import des résultats" +
                    " (\"dossard\" et \"temps\"");
            }
        }
    }
}
