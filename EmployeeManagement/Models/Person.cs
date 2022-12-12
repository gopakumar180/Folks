using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
    public class Person
    {
        private String LastName;
        private String FirstName;
        private char Middleinit;
        private String PhoneNumber;
        private Address Address;

        public Person()
        {

        }

        public Person(string lastName, string firstName, char middleinit, string phoneNumber, Address address)
        {
            LastName = lastName;
            FirstName = firstName;
            Middleinit = middleinit;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Person(string lastName, string firstName, char middleinit)
        {
            LastName = lastName;
            FirstName = firstName;
            Middleinit = middleinit;
        }

        public Person(string lastName, string firstName, char middleinit, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            Middleinit = middleinit;
            PhoneNumber = phoneNumber;
        }

        public Person(Address address)
        {
            Address = address;
        }

        public Address getAddress()
        {
            return Address;
        }

        public void setAddress(Address Address)
        {
            this.Address = Address;
        }


        public void setLastName(String LastName)
        {

            this.LastName = LastName;
        }

        public String getLastName()
        {
            return LastName;
        }

        public void setFirstName(String FirstName)
        {
            this.FirstName = FirstName;
        }

        public String getFirstName()
        {
            return FirstName;
        }

        public void setMiddleinit(char Middleinit)
        {
            this.Middleinit = Middleinit;
        }

        public char getMiddleinit()
        {
            return Middleinit;
        }

        public void setPhoneNumber(String PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public String getPhoneNumber()
        {
            return PhoneNumber;
        }

        public String getFullName()
        {

            return (FirstName + "," + Middleinit + "," + LastName + ".");
        }

    }
}