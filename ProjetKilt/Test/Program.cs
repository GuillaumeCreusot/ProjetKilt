using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            // Update database according to mapping files and DB credentials
            var test  = new SchemaExport(cfg);
            test.Execute(true, true, false);
        }
    }
}
