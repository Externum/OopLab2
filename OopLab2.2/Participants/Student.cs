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
            results.Add(examResult);
        }

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
    }
}
