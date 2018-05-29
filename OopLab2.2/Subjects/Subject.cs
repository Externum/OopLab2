using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    class Subject : ISubject
    {
        public string Name { get; set; }
        private List<ITeacher> teachers;

        public Subject(string name)
        {
            Name = name;
            teachers = new List<ITeacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
            teacher.AddSubject(this);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
            teacher.RemoveSubject(this);
        }

        public void ShowTeachers()
        {
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
