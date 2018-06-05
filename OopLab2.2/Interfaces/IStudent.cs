using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public interface IStudent
    {
        Group Group { get; set; }
        bool HasGroup { get; }
        void AddExamResult(ExamResult examResult);
        void RemoveExamResult(ExamResult examResult);
        bool ContainsExamResult(ExamResult examResult);
    }
}
