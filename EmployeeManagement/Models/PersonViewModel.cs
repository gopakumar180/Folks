using EmployeeManagement.EmpUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
    public class PersonViewModel
    {
        public int employeeNo;
        public String lastName;
        public String street;
        public String firstName;
        public String city;
        public String middleInit;
        public String province;
        public String phoneNo;
        public String postalCode;
        public String jobDescription;

        public PersonViewModel()
        {
        }

        public PersonViewModel(int employeeNo, string lastName, string street, string firstName, string city, string middleInit, string province, string phoneNo, string postalCode, string jobDescription)
        {
            this.employeeNo = employeeNo;
            this.lastName = lastName;
            this.street = street;
            this.firstName = firstName;
            this.city = city;
            this.middleInit = middleInit;
            this.province = province;
            this.phoneNo = phoneNo;
            this.postalCode = postalCode;
            this.jobDescription = jobDescription;           
        }
    }
}