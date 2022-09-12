using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Hourly : Employee
    {
        // Attributes
        private double hourlyRate;
        private double hoursWorked;

        // Constructors
        public Hourly() : base()
        {
            hourlyRate = 0.0;
            hoursWorked = 0.0;
        }

        public Hourly(string empId, string firstName, string lastName, char gender, 
            short numberOfDependents, double hourlyRate, double hoursWorked) 
            : base(empId, firstName, lastName, gender, numberOfDependents)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        // Behaviors
        public override double CalculatePay()
        {
            double pay = 0.0;

            if (hoursWorked > 40.0)
            {
                double straightTime = 40.0 * hourlyRate;
                double overTime = (hoursWorked - 40.0) * hourlyRate * 1.5;
                pay = straightTime + overTime;
            }
            else
            {
                pay = hoursWorked * hourlyRate;
            }

            return pay;
        }

        // Properties
        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (value >= 0.0 && value <= 1000.0)
                    hourlyRate = value;
                else
                    hourlyRate = 0.0;
            }
        }

        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value >= 0.0 && value <= 140.0)
                    hoursWorked = value;
                else
                    hoursWorked = 0.0;
            }
        }
    }
}
