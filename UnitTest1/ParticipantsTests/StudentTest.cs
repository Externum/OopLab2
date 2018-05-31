using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ShowResultsTest()
        {
            Student studnet = new Student("Студентов", "Студентище");
            studnet.ShowExamResults();
        }
    }
}
