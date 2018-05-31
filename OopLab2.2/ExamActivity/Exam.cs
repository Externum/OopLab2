using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public class Exam : IExam
    {
        private int cntExamId = 1;
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public int Id { get; private set; }

        public Exam(Group group, Teacher teacher, Subject subject)
        {
            if (!(teacher.ContainsSubject(subject)))
            {
                Console.WriteLine(teacher + " не ведет предмет " + subject);
            }
            else if (!(group.ContainsSubject(subject)))
            {
                Console.WriteLine("Группе " + group + "не назначен предмет" + subject);
            }
            else if(group.NoStudents())
            {
                Console.WriteLine("В группе " + group + "не числится ни один студент");
            }
            else
            {
                Group = group;
                Teacher = teacher;
                Subject = subject;
                group.AddExam(this);
                Id = cntExamId;
                cntExamId++;
            }
        }

        public override string ToString()
        {
            return string.Format("Экзамен ID " + Id + " для группы " + Group + ", принимает " + Teacher + ", предмет " + Subject);
        }
    }
}
