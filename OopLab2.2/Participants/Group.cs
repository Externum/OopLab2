using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    class Group : IGroup
    {
        private IList<IStudent> studentsList;
        private IList<ISubject> subjects;
        private IList<IExam> exams;
        public string Code { get; set; }

        public Group(string code)
        {
            Code = code;
            studentsList = new List<IStudent>();
            subjects = new List<ISubject>();
            exams = new List<IExam>();
        }

        public void AddStudent(Student student)
        {
            if (student.HasGroup)
            {
                Console.WriteLine("Студент уже числится в другой группе");
            }
            else
            {
                studentsList.Add(student);
                student.Group = this;
            }
        }

        public void RemoveStudent(Student student)
        {
            studentsList.Remove(student);
        }

        public void ShowStudents()
        {
            foreach(Student student in studentsList)
            {
                Console.WriteLine(student);
            }
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
        }

        public void ShowSubjects()
        {
            foreach(Subject subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public override string ToString()
        {
            return Code;
        }

        public bool ContainsSubject(Subject subject)
        {
            return subjects.Contains(subject);
        }

        public void AddExam(Exam exam)
        {
            exams.Add(exam);
        }

        public void RemoveExam(Exam exam)
        {
            exams.Remove(exam);
        }

        public void ShowExams()
        {
            foreach(Exam exam in exams)
            {
                Console.WriteLine(exam);
            }
        }

        public bool ContainsStudent(Student student)
        {
            return studentsList.Contains(student);
        }
    }
}
