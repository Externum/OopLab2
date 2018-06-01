using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public interface IExamResult
    {
        Student Student { get; set; }
        Exam Exam { get; set; }
        bool Result { get; set; }
    }
}
