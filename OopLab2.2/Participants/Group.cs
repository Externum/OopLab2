using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public class Group : IGroup
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
            if (studentsList.Contains(student))
            {
                studentsList.Remove(student);
                student.Group = null;
            }
            else
            {
                Console.WriteLine("Студент " + student + "в группе " + this + " не числится");
            }
        }

        public void ShowStudents()
        {
            if (studentsList.Count == 0)
            {
                Console.WriteLine("В группе " + this + " нет студентов");
            }
            else
            {
                foreach (Student student in studentsList)
                {
                    Console.WriteLine(student);
                }
            }
        }

        public bool NoStudents()
        {
            if(studentsList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                Console.WriteLine("Предмет " + subject + " уже назначен группе " + this);
            }
            else
            {
                subjects.Add(subject);
            }
        }

        public void RemoveSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                subjects.Remove(subject);
            }
            else
            {
                Console.WriteLine("Предмет " + subject + " не назначен группе " + this);
            }
        }

        public void ShowSubjects()
        {
            if (subjects.Count == 0)
            {
                Console.WriteLine("Группе " + this + "еще не назначены никакие предметы");
            }
            else
            {
                foreach (Subject subject in subjects)
                {
                    Console.WriteLine(subject);
                }
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
            if (exams.Count == 0)
            {
                Console.WriteLine("Группе " + this + " еще не назначены экзамены");
            }
            else
            {
                foreach (Exam exam in exams)
                {
                    Console.WriteLine(exam);
                }
            }
        }

        public bool ContainsStudent(Student student)
        {
            return studentsList.Contains(student);
        }
    }
}
