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
        private IList<ITeacher> teachers;

        public Subject(string name)
        {
            Name = name;
            teachers = new List<ITeacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                Console.WriteLine("Учитель " + teacher + " уже ведет предмет " + this);
            }
            else
            {
                teachers.Add(teacher);
                teacher.AddSubject(this);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                teachers.Remove(teacher);
                teacher.RemoveSubject(this);
            }
            else
            {
                Console.WriteLine("Учитель " + teacher + " не ведет предмет " + this);
            }
        }

        public void ShowTeachers()
        {
            if(teachers.Count == 0)
            {
                Console.WriteLine("Этот предмет никто не ведет");
            }
            {
                foreach (Teacher teacher in teachers)
                {
                    Console.WriteLine(teacher);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
