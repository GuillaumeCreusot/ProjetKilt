using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class ImportCsvBrut
    {
        /// <summary>
        /// Import data from csv without treatement
        /// </summary>
        /// <param name="path"></param>
        /// <returns>dictionnay contains a list of data and as key a label for each column</returns>
        public static Dictionary<string, List<string>> ImportCsv(string path)
        {
            Dictionary<string, List<string>> table = new Dictionary<string, List<string>>();

            StreamReader reader = new StreamReader(path);

            // get label
            string line = reader.ReadLine();
            List<string> keys = line.Split(',').ToList();

            // init dictionnary pairs
            foreach (string key in keys)
            {
                table.Add(key, new List<string>());
            }

            // add value in dictionnary
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                List<string> values = line.Split(',').ToList();

                for (int i = 0; i < values.Count(); i++)
                    table[keys[i]].Add(values[i]);

            }

            reader.Close();

            return table;
        }
    }
}
