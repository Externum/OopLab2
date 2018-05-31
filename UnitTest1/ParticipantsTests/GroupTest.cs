using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.ParticipantsTests
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void GroupAddRemoveStudent()
        {
            Group group1 = new Group("Группа1");
            Group group2 = new Group("Группа2");
            Student student1 = new Student("Студент", "Один");
            Student student2 = new Student("Студент", "Два");
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group2.AddStudent(student2);
            group1.RemoveStudent(student2);
            Assert.IsTrue(group1.ContainsStudent(student1) && !(group1.ContainsStudent(student2)));
            Assert.IsTrue(!(group2.ContainsStudent(student2)));
        }

        [TestMethod]
        public void GroupShowStudentsTest()
        {
            Group group1 = new Group("Группа1");
            Group group2 = new Group("Группа2");
            Student student1 = new Student("Студент", "Один");
            Student student2 = new Student("Студент", "Два");
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.ShowStudents();
            group2.ShowStudents();
        }

        [TestMethod]
        public void GroupAddRemoveSubjectTest()
        {
            Group group1 = new Group("Группа1");
            Subject subject1 = new Subject("Предмет1");
            Subject subject2 = new Subject("Предмет2");
            group1.AddSubject(subject1);
            group1.RemoveSubject(subject2);
            group1.RemoveSubject(subject1);
            Assert.IsTrue(!(group1.ContainsSubject(subject1)) && !(group1.ContainsSubject(subject2)));
        }

        [TestMethod]
        public void GroupShowSubjectTest()
        {
            Group group1 = new Group("Группа1");
            Group group2 = new Group("Группа2");
            Subject subject1 = new Subject("Предмет1");
            Subject subject2 = new Subject("Предмет2");
            group1.AddSubject(subject1);
            group1.AddSubject(subject2);
            group1.ShowSubjects();
            group2.ShowSubjects();
        }
    }
}
