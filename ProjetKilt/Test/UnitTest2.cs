using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System.Collections.Generic;
using System.IO;
using Domain;

namespace Test
{
    [TestClass]
    public class TestCSVImport
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Dictionary<string, List<string>> dico = ImportCsvBrut.ImportCsv(path + "\\Resultat.csv");

            ICourseRepository courses = new CourseRepository();
            Course course = courses.GetAll()[0];

            ParticipationCSVToDB.Import(dico, course);
        }
    }
}
