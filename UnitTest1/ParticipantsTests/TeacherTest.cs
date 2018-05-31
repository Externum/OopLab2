using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.ParticipantsTests
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void TeacherAddSubject()
        {
            Teacher teacher1 = new Teacher("Препод", "Один");
            Subject subject1 = new Subject("Предмет");
            teacher1.AddSubject(subject1);
        }
    }
}
