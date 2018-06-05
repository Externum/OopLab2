using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OopLab2._2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            new MainForm().ShowDialog();
            
            Teacher teacher1 = new Teacher("Петров", "Василий");
            Student student1 = new Student("Иванов", "Фома");
            Group group1 = new Group("ИВТ2");
            Subject subject1 = new Subject("Математика");           
        }
    }
}
