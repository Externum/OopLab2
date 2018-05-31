using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopLab2._2;

namespace UnitTest1.ParticipantsTests
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void TeacherAddRemoveGroupTest()
        {
            Teacher teacher1 = new Teacher("Препод", "Один");
            Teacher teacher2 = new Teacher("Препод", "Два");
            Group group1 = new Group("Группа1");
            Group group2 = new Group("Группа2");
            teacher1.AddStudentGroup(group1);
            teacher1.AddStudentGroup(group2);
            teacher2.AddStudentGroup(group1);
            teacher1.RemoveStudentGroup(group1);
            teacher2.RemoveStudentGroup(group2);
        }

        [TestMethod]
        public void TeacherShowGroupTest()
        {
            Teacher teacher1 = new Teacher("Препод", "Один");
            Teacher teacher2 = new Teacher("Препод", "Два");
            Group group1 = new Group("Группа1");
            Group group2 = new Group("Группа2");
            teacher1.AddStudentGroup(group1);
            teacher1.AddStudentGroup(group2);
            teacher1.ShowStudentsGroups();
            teacher2.ShowStudentsGroups();
        }
    }
}
