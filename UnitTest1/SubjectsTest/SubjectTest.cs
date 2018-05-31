using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.SubjectsTest
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void SubjectAddRemoveTeacherTest()
        {
            Subject subject1 = new Subject("Предмет1");
            Subject subject2 = new Subject("Предмет2");
            Teacher teacher1 = new Teacher("Препод", "Один");
            Teacher teacher2 = new Teacher("Препод", "Два");
            subject1.AddTeacher(teacher1);
            subject1.AddTeacher(teacher2);
            subject1.AddTeacher(teacher1);
            subject2.AddTeacher(teacher1);
            subject1.RemoveTeacher(teacher1);
            subject2.RemoveTeacher(teacher2);
        }

        [TestMethod]
        public void SubjectShowTeacherTest()
        {
            Subject subject1 = new Subject("Предмет1");
            Subject subject2 = new Subject("Предмет2");
            Teacher teacher1 = new Teacher("Препод", "Один");
            Teacher teacher2 = new Teacher("Препод", "Два");
            subject1.AddTeacher(teacher1);
            subject1.AddTeacher(teacher2);
            subject1.ShowTeachers();
            subject2.ShowTeachers();
        }
    }
}
