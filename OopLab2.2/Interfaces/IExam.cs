using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    interface IExam
    {
        Group Group { get; set; }
        Teacher Teacher { get; set; }
        Subject Subject { get; set; }
    }
}
