using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OopLab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("Петров", "Василий");
            Student student1 = new Student("Иванов", "Фома");
            Group group1 = new Group("ИВТ2");
            Subject subject1 = new Subject("Математика");
            subject1.AddTeacher(teacher1);
            group1.AddStudent(student1);
            group1.AddSubject(subject1);
            Exam exam1 = new Exam(group1, teacher1, subject1);
            ExamResult exResult1 = new ExamResult(student1, exam1, true);
            Console.WriteLine(exam1);
            Console.WriteLine(exResult1);
            Group group2 = new Group("М45");
            group2.AddStudent(student1);
            Student student2 = new Student("Попов", "Егор");
            student2.ShowExamResults();
            Console.ReadLine();

        }
    }
}
