using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
    public class HourlyEmployee : Employee
    {
        private float hourlyRate;
        private float hourworked;

        public HourlyEmployee()
        {
        }
        public HourlyEmployee(float hourlyRate, float hourworked)
        {
            this.hourlyRate = hourlyRate;
            this.hourworked = hourworked;
        }
        public HourlyEmployee(float hourlyRate, float hourworked, int employeeNo, String jobDescription) : base(employeeNo, jobDescription)
        {
            this.hourlyRate = hourlyRate;
            this.hourworked = hourworked;
        }

        public HourlyEmployee(float hourlyRate, float hourworked, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit) : base(employeeNo, jobDescription, LastName, FirstName, Middleinit)
        {
            this.hourlyRate = hourlyRate;
            this.hourworked = hourworked;
        }

        public HourlyEmployee(float hourlyRate, float hourworked, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit, String PhoneNumber) : base(employeeNo, jobDescription, LastName, FirstName, Middleinit, PhoneNumber)
        {
            this.hourlyRate = hourlyRate; 
            this.hourworked = hourworked;
        }

        public HourlyEmployee(float hourlyRate, float hourworked, int employeeNo, String jobDescription, String LastName, String FirstName, char Middleinit, String PhoneNumber, Address address):base(employeeNo, jobDescription, LastName, FirstName, Middleinit, PhoneNumber, address)
        {           
            this.setHourlyRate(hourlyRate);
            this.setHourworked(hourworked);
        }
        public void setHourlyRate(float hourlyRate)
        {

            if (hourlyRate < 0)
            {
                this.hourlyRate = 0;
            }
            else
            {
                this.hourlyRate = hourlyRate;
            }

        }
        public void setHourworked(float hourworked)
        {
            this.hourworked = hourworked;
        }

        public float getHourlyRate()
        {
            return hourlyRate;
        }

        public float getHourworked()
        {
            return hourworked;
        }
        public override double getEarnings()
        {
            double earnings = 0;
            if (hourworked > 80)
            {
                earnings = 80 * hourlyRate + (hourworked - 80) * hourlyRate * 1.5;
            }
            else
            {
                earnings = hourworked * hourlyRate;
            }

            return earnings;
        }
    }
}