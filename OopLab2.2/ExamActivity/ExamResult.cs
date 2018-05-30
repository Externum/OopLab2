using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    class ExamResult : IExamResult
    {
        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public bool Result { get; set; }

        public ExamResult(Student student, Exam exam, bool result)
        {
            if (exam.Group.ContainsStudent(student))
            {
                Student = student;
                Exam = exam;
                student.AddExamResult(this);
                Result = result;
            }
            else
            {
                Console.WriteLine("Данному студенту указанный экзамен назначен не был!");
            }
        }

        public override string ToString()
        {
            if (Result)
            {
                return string.Format("Студент " + Student + " экзамен ID " + Exam.Id + " сдал");
            }
            else
            {
                return string.Format("Студент " + Student + " экзамен ID " + Exam.Id + " не сдал");
            }
        }
    }
}
