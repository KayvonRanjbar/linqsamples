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
            // Named Method
            // Func<int, int> f = Square;

            // Lambda Expression
            Func<int, int> square = x => x * x;
            //Func<int, int, int> add = (x, y) => x + y;
            
            // Explicit parameter types
            // Func<int, int, int> add = (int x, int y) => x + y;

            // Full body block in lambda expression
            Func<int, int, int> add = (x, y) =>
            { 
                int temp = x + y;
                return temp;
            };

            Action<int> write = x => Console.WriteLine(x);

            // Without action
            //Console.WriteLine(square(add(3, 5)));

            // Using action
            write(square(add(3, 5)));

            var developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            var sales = new List<Employee>
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            var query = developers.Where(e => e.Name.Length == 5)
                                  .OrderBy(e => e.Name);

            // Named Method Approach
            // foreach (var employee in developers.Where(NameStartsWithS)

            // Anonymous Method Approach
            /*foreach (var employee in developers.Where(
                delegate (Employee employee)
                {
                    return employee.Name.StartsWith("S");
                }))*/

            // Lamda Expression Approach
            /*
            foreach (var employee in developers.Where(
                            e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }
            */

            // Changing the filtering criteria and adding ordering
            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static int Square(int arg)
        {
            throw new NotImplementedException();
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
