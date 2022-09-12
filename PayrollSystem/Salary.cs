using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Salary : Employee
    {
        // Attributes
        protected double annualSalary;

        // Constructors
        public Salary() : base()
        {
            annualSalary = 0.0;
        }

        public Salary(string empID, string firstName, string lastName, char gender, 
            short numberOfDependents, double annualSalary) 
            : base(empID, firstName, lastName, gender, numberOfDependents)
        {
            AnnualSalary = annualSalary;
        }

        // Behaviors
        public override double CalculatePay()
        {
            return annualSalary / 26;
        }

        // Properties
        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            set
            {
                if (value >= 0.0 && value <= 2000000.0)
                    annualSalary = value;
                else
                    annualSalary = 0.0;
            }
        }

    }
}
