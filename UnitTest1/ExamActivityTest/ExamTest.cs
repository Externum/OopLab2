using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.ExamActivityTest
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void ExamCreateTest()
        {
            Teacher teacher1 = new Teacher("Петров", "Василий");
            Student student1 = new Student("Иванов", "Фома");
            Group group1 = new Group("ИВТ2");
            Subject subject1 = new Subject("Математика");
            Exam exam = new Exam(group1, teacher1, subject1);
            group1.AddStudent(student1);
            exam = new Exam(group1, teacher1, subject1);
            group1.AddSubject(subject1);
            exam = new Exam(group1, teacher1, subject1);
            subject1.AddTeacher(teacher1);
            exam = new Exam(group1, teacher1, subject1);
        }
    }
}
