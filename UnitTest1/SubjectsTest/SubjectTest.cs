using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.SubjectsTest
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void SubjectAddTeacherTest()
        {
            Subject subject1 = new Subject("Предмет");
            Teacher teacher = new Teacher("Препод", "Один");
            subject1.AddTeacher(teacher);
        }
    }
}
