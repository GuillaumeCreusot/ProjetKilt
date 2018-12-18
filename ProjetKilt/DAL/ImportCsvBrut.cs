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

        public static Dictionary<string, List<string>> ImportCsv(string path)
        {
            Dictionary<string, List<string>> table = new Dictionary<string, List<string>>();
            StreamReader reader = new StreamReader(path);

            string line = reader.ReadLine();
            List<string> keys = line.Split(',').ToList();


            foreach (string key in keys)
            {
                table.Add(key, new List<string>());
            }


            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                List<string> values = line.Split(',').ToList();

                for (int i = 0; i < values.Count(); i++)
                    table[keys[i]].Add(values[i]);

            }

            return table;
        }
    }
}
