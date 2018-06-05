using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public class ExamResult : IExamResult
    {
        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public bool Result { get; set; }

        public ExamResult(Student student, Exam exam, bool result)
        {
            try
            {
                if (!(exam.Group.ContainsStudent(student)))
                {
                    //Console.WriteLine("Данному студенту указанный экзамен назначен не был!");
                    throw new System.ArgumentException("Экзамен студенту не назначен");
                }
                else
                {
                    Student = student;
                    Exam = exam;
                    student.AddExamResult(this);
                    Result = result;
                }
            }
            catch (System.NullReferenceException)
            {
                throw new System.ArgumentException("Экзамен создан не был, ссылка пустая");
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
