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
            Student studnetTest = new Student("Студентов", "Студентище");
            studnetTest.ShowExamResults();
        }
    }
}
