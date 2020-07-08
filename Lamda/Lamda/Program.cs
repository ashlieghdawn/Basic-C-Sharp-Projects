using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List of 10 employees

            Employee em1 = new Employee()
            {
                fname = "Jesse",
                lname = "Parker",
                Id = 1
            };

            Employee em2 = new Employee()
            {
                fname = "Jack",
                lname = "Perker",
                Id = 2
            };

            Employee em3 = new Employee()
            {
                fname = "Joe",
                lname = "Johnson",
                Id = 3
            };

            Employee em4 = new Employee()
            {
                fname = "Mary",
                lname = "Jetson",
                Id = 4
            };

            Employee em5 = new Employee()
            {
                fname = "Bob",
                lname = "Smith",
                Id = 5
            };

            Employee em6 = new Employee()
            {
                fname = "Daniel",
                lname = "Beacher",
                Id = 6
            };

            Employee em7 = new Employee()
            {
                fname = "Hermione",
                lname = "Granger",
                Id = 7
            };

            Employee em8 = new Employee()
            {
                fname = "Joe",
                lname = "Weasley",
                Id = 8
            };

            Employee em9 = new Employee()
            {
                fname = "Harry",
                lname = "Potter",
                Id = 9
            };

            Employee em10 = new Employee()
            {
                fname = "Minerva",
                lname = "Beastley",
                Id = 10
            };

            List<Employee> Employees = new List<Employee>();
            Employees.Add(em1);
            Employees.Add(em2);
            Employees.Add(em3);
            Employees.Add(em4);
            Employees.Add(em5);
            Employees.Add(em6);
            Employees.Add(em7);
            Employees.Add(em8);
            Employees.Add(em9);
            Employees.Add(em10);

            /*List<Employee> Jesse = new List<Employee>();
            foreach (Employee e in Employees)
            {
                if (e.fname == "Jesse")
                {
                    Jesse.Add(e);
                }
            foreach (Employee j in Jesse)
                {
                    Console.WriteLine("{0} {1} {2}", j.fname, j.lname, j.Id);
                }*/

            List<Employee> Joe = Employees.FindAll(x => x.fname == "Joe").ToList();
            foreach (Employee j in Joe)
            {
                Console.WriteLine("{0} {1} {2}", j.fname, j.lname, j.Id);
            }

            List<Employee> Over5 = Employees.FindAll(x =>x.Id > 5).ToList();
            foreach (Employee j in Over5)
            {
                Console.WriteLine("{0} {1} {2}", j.fname, j.lname, j.Id);
            }
            Console.ReadLine();
            }
        }
    }


