using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
        class Teacher: Human, ITeacher
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
            studentGroups.Add(group);
        }

        public void RemoveStudentGroup(Group group)
        {
            studentGroups.Remove(group);
        }

        public void ShowStudentsGroups()
        {
            foreach(Group group in studentGroups)
            {
                Console.WriteLine(group);
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

        public bool ContainsSubject(Subject subject)
        {
            return subjects.Contains(subject);
        }
        
        public void ShowSubjects()
        {
            foreach(Subject subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
