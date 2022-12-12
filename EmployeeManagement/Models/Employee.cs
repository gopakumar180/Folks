using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{  
    public abstract class Employee : Person
    {
        private int employeeNo;
        private String jobDescription;
        float getHourlyRate;
        public Employee()
        {

        }
        public Employee(int employeeNo, string jobDescription)
        {
            this.employeeNo = employeeNo;
            this.jobDescription = jobDescription;
        }
       
        public Employee(int employeeNo, String jobDescription, String lastName, String girstName, char middleInit):base(lastName,girstName,middleInit)
        {           
           
            this.employeeNo = employeeNo;
            this.jobDescription = jobDescription;
        }
        public Employee(int employeeNo, String jobDescription, String lastName, String firstName, char middleInit, String phoneNumber, Address address):base(lastName,firstName,middleInit,phoneNumber,address)
        {           
            this.employeeNo = employeeNo;
            this.jobDescription = jobDescription;
        }
        public Employee(int employeeNo, String jobDescription, String lastName, String firstName, char middleInit, String phoneNumber):base(lastName,firstName,middleInit,phoneNumber)
        {           
            this.employeeNo = employeeNo;
            this.jobDescription = jobDescription;
        }
        public int getEmployeeNo()
        {
            return employeeNo;
        }

        public void setEmployeeNo(int employeeNo)
        {
            this.employeeNo = employeeNo;
        }

        public String getJobDescription()
        {
            return jobDescription;
        }

        public void setJobDescription(String jobDescription)
        {
            this.jobDescription = jobDescription;
        }
        public String toString()
        {
            return getEmployeeNo() + ": " + getFullName();
        }
        public abstract double getEarnings();
    }
}