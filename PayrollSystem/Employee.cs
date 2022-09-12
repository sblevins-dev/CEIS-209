using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Employee
    {
        // Attributes
        protected string empID;
        protected string firstName;
        protected string lastName;
        protected char gender;
        protected short numberOfDependents;

        // Constructors
        public Employee()
        {
            empID = "unknown";
            firstName = "unknown";
            lastName = "unknown";
            gender = 'U';
            numberOfDependents = 0;
        }

        public Employee(string empID, string firstName, string lastName, char gender, short numberOfDependents)
        {
            EmpID = empID;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            NumberOfDependents = numberOfDependents;
        }

        // Behaviors
        public virtual double CalculatePay()
        {
            return 0;
        }

        // Properties
        public string EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                if (value.Length > 2)          // Employee emp = new Employee();
                    empID = value;        // emp.EmpID = "D123";
                else
                    empID = "unknown";
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 1)
                    firstName = value;
                else
                    firstName = "unknown";
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 1)
                    lastName = value;
                else
                    lastName = "unknown";
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                value = Char.ToUpper(value);

                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    gender = 'U';
            }
        }

        public short NumberOfDependents
        {
            get
            {
                return numberOfDependents;
            }
            set
            {
                if (value >= 0)
                    numberOfDependents = value;
                else
                    numberOfDependents = 0;
            }
        }
    }
}
