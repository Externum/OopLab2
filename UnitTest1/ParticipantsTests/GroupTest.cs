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
            group2.AddStudent(student2);
            group1.AddStudent(student2);
            group1.RemoveStudent(student2);
            group1.RemoveStudent(student1);
        }
    }
}
