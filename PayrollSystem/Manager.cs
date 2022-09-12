using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Manager : Salary
    {
        // Attributes
        private double bonus;

        // constructors
        public Manager() : base()
        {
            bonus = 0.0;
        }

        public Manager(string empID, string firstName, string lastName, char gender,
            short numberOfDependents, double annualSalary, double bonus)
            : base(empID, firstName, lastName, gender, numberOfDependents, annualSalary)
        {
            Bonus = bonus;
        }

        // Behaviors
        public override double CalculatePay()
        {
            double pay = 0.0;
            double basePay = base.CalculatePay();
            double bonusPay = bonus / 26;
            pay = basePay + bonusPay;
            return  pay;
        }

        // Properties
        public double Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                if (value >= 0 && value <= 5000000.0)
                    bonus = value;
                else
                    value = 0.0;
            }
        }
    }
}
