using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
        public class Teacher: Human, ITeacher
        {
            private static int cntTeacherId = 1;
            private IList<IGroup> studentGroups;
            private IList<ISubject> subjects;

            public Teacher(string lastName, string firstName) : base(lastName, firstName)
            {
                studentGroups = new List<IGroup>();
                Id = cntTeacherId;
                cntTeacherId++;
                subjects = new List<ISubject>();
            }

        public void AddStudentGroup(Group group)
        {
            if (studentGroups.Contains(group))
            {
                Console.WriteLine(this + " уже преподает в группе " + group);
            }
            else
            {
                studentGroups.Add(group);
            }
        }

        public void RemoveStudentGroup(Group group)
        {
            if (studentGroups.Contains(group))
            {
                studentGroups.Remove(group);
            }
            else
            {
                Console.WriteLine("Группа " + group + " не числится у преподавателя " + this);
            }
        }

        public void ShowStudentsGroups()
        {
            if (studentGroups.Count == 0)
            {
                Console.WriteLine("У перподавателя " + this + " нет студенческих групп");
            }
            else
            {
                foreach (Group group in studentGroups)
                {
                    Console.WriteLine(group);
                }
            }
        }

        public void AddSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                Console.WriteLine("Преподаватель " + this + " уже ведет предмет " + subject);
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
                Console.WriteLine("Преподаватель " + this + " не ведет предмет " + subject);
            }
        }

        public bool ContainsSubject(Subject subject)
        {
            return subjects.Contains(subject);
        }
        
        public void ShowSubjects()
        {
            if (subjects.Count == 0)
            {
                Console.WriteLine("Преподаватель " + this + " не ведет никаких предметов");
            }
            else
            {
                foreach (Subject subject in subjects)
                {
                    Console.WriteLine(subject);
                }
            }
        }
    }
}
