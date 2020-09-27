using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Features.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            // Named Method Approach
            // foreach (var employee in developers.Where(NameStartsWithS)

            // Anonymous Method Approach
            /*foreach (var employee in developers.Where(
                delegate (Employee employee)
                {
                    return employee.Name.StartsWith("S");
                }))*/

            // Lamda Expression Approach
            foreach (var employee in developers.Where(
                            e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
