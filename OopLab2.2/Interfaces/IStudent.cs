using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    interface IStudent
    {
        Group Group { get; set; }
        void AddExamResult(ExamResult examResult);
        void ShowExamResults();
    }
}
