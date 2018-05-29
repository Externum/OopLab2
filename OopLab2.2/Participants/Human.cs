using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab2._2
{
    abstract class Human
    {
        public int Id { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string lastName, string firstName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format(LastName + " " + FirstName);
        }
    }
}
