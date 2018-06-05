using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public class Student: Human, IStudent
    {
        private static int cntStudentId = 1;
        private IList<IExamResult> results;
        public bool HasGroup
        { get
            {
                return Group != null;
            }
                }

        public Group Group { get; set; }


        public Student(string lastName, string firstName) : base(lastName, firstName)
        {
            Id = cntStudentId;
            cntStudentId++;
            results = new List<IExamResult>();
        }

        public void AddExamResult(ExamResult examResult)
        {
            if (results.Contains(examResult))
            {
                throw new ArgumentException("Этот результат уже есть");
            }
            else
            {
                results.Add(examResult);
            }
        }

        public void RemoveExamResult(ExamResult examResult)
        {
            if(!(results.Contains(examResult)))
            {
                throw new ArgumentException("Этого результата нет");
            }
            else
            {
                results.Remove(examResult);
            }
        }

        public bool ContainsExamResult(ExamResult examResult)
        {
            return results.Contains(examResult);
        }
        /*
        public void ShowExamResults()
        {
            if (results.Count == 0)
            {
                Console.WriteLine("Студент " + this + " еще не сдавал экзамены");
            }
            else
            {
                foreach (ExamResult result in results)
                {
                    Console.WriteLine(result);
                }
            }
        }
        */
    }
}
