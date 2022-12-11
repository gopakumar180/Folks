using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
    public class Address
    {
        private String street;
        private String city;
        private String province;
        private String postalCode;


        public Address(string street, string city, string province, string postalCode)
        {
            this.street = street;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
        }
        public void setCity(String city)
        {
            this.city = city;
        }

        public String getCity()
        {
            return city;
        }

        public void setPostalcode(String postalcode)
        {
            this.postalCode = postalcode;
        }

        public String getPostalcode()
        {
            return postalCode;
        }

        public void setProvince(String province)
        {
            this.province = province;
        }

        public String getProvince()
        {
            return province;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String getStreet()
        {
            return street;
        }

        public String getfullAddress()
        {

            return getStreet() + "," + getCity() + "," + getProvince() + "," + getPostalcode() + ".";

        }
    }
}