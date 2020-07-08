using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.id = 1;
            person.SayName();

            person.FirstName = "Sara";
            person.LastName = "Pommer";
            person.id = 2;
            person.SayName();

        }
    }
}
