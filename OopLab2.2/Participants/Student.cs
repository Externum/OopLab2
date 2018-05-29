using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    class Student: Human, IStudent
    {
        private static int cntStudentId = 1;
        private IList<IExamResult> results;
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
            foreach(ExamResult result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
