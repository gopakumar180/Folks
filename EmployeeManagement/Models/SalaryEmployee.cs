using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
    public class SalaryEmployee : Employee
    {
        private float monthlySalary;
        public override double getEarnings()
        {
            float earnings = monthlySalary * 12 / 26;
            //double earnings=Math.E;
            return earnings;
        }
        public float getMonthlySalary()
        {
            return monthlySalary;
        }

        public void setMonthlySalary(float monthlySalary)
        {
            if (monthlySalary < 0)
            {

                monthlySalary = 0;
            }
            else
            {
                this.monthlySalary = monthlySalary;
            }
            this.monthlySalary = monthlySalary;
        }

        public SalaryEmployee(float monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        public SalaryEmployee(float monthlySalary, int employeeNo, String jobDescription) : base(employeeNo, jobDescription)
        {
            this.monthlySalary = monthlySalary;
        }

        public SalaryEmployee(float monthlySalary, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit) : base(employeeNo, jobDescription, LastName, FirstName, Middleinit)
        {
            this.monthlySalary = monthlySalary;
        }

        public SalaryEmployee(float monthlySalary, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit, String PhoneNumber) : base(employeeNo, jobDescription, LastName, FirstName, Middleinit, PhoneNumber)
        {
            this.monthlySalary = monthlySalary;
        }

        public SalaryEmployee(float monthlySalary, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit, String PhoneNumber, Address address):base(employeeNo, jobDescription, LastName, FirstName, Middleinit, PhoneNumber, address)
        {           
            this.setMonthlySalary(monthlySalary);
        }

    }
}