using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    public interface IGroup
    {
        string Code { get; set; }
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        bool ContainsStudent(Student student);
        void AddSubject(Subject subject);
        void RemoveSubject(Subject subject);
        bool ContainsSubject(Subject subject);
        void AddExam(Exam exam);
        void RemoveExam(Exam exam);
        bool ContainsExam(Exam exam);
    }
}
