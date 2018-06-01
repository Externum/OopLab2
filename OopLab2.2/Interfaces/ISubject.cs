using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public interface ISubject
    {
        string Name { get; set; }
        void AddTeacher(Teacher teacher);
        void RemoveTeacher(Teacher teacher);
        void ShowTeachers();
    }
}
