using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public interface ITeacher
    {
        void AddStudentGroup(Group group);
        void RemoveStudentGroup(Group group);
        void ShowStudentsGroups();
        void AddSubject(Subject subject);
        void RemoveSubject(Subject subject);
        bool ContainsSubject(Subject subject);
        void ShowSubjects();
    }
}
