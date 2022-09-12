using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and load a Parent array
            Employee[] emps = new Employee[5];

            emps[0] = new Hourly("H123", "Jack", "Black", 'M', 2, 36.57, 52);
            emps[1] = new Manager("M459", "Amy", "Wilson", 'F', 3, 115927.31, 25000);
            emps[2] = new Salary("S921", "Bill", "Johnson", 'M', 0, 82912.87);
            emps[3] = new Hourly("H329", "Tina", "Turner", 'F', 0, 42.11, 40);
            emps[4] = new Salary("S999", "Tom", "Jones", 'M', 7, 88492.33);

            // Pay all of our employees with a single for loop
            for (int i = 0; i < emps.Length; i++)
            {
                // Pay each employee
                Console.WriteLine("Pay to:\t\t" + emps[i].FirstName + " " + emps[i].LastName);
                Console.WriteLine("Ammount of:\t" + emps[i].CalculatePay().ToString("C2"));
                Console.WriteLine();
            }

            // Pause
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
