﻿using EmployeeManagement.EmpUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace EmployeeManagement
{
    public partial class EmployeeMaster : System.Web.UI.Page
    {
        private static EmployeeUtilities empUtil;

        //public EmployeeMaster()
        //{
        //    empUtil = new EmployeeUtilities(); //create object of EmployeeUtilities                                              

        //}
        public void displayEmployee(Employee e)
        {
            EmployeeNo.Text = Convert.ToString(e.getEmployeeNo());
            LastName.Text = Convert.ToString(e.getLastName());
            FirstName.Text = Convert.ToString(e.getFirstName());
            MiddleInitial.Text = Convert.ToString(e.getMiddleinit());
            PhoneNumber.Text = Convert.ToString(e.getPhoneNumber());
            PostalCode.Text = Convert.ToString(e.getAddress().getPostalcode());
            Province.Text = Convert.ToString(e.getAddress().getProvince());
            Street.Text = Convert.ToString(e.getAddress().getStreet());
            City.Text = Convert.ToString(e.getAddress().getCity());
            JobDescription.Text = Convert.ToString(e.getJobDescription());

            int earnings = (int)(e.getEarnings() * 100);
            double earning = earnings;
            Earnings.Text = "$" + (Math.Round(earning) / 100);
            if (e.GetType() == typeof(HourlyEmployee))
            {
                GetHours.Text = "Get Hours";
            }
            else
            {
                GetHours.Text = "Get Salary";
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                empUtil = new EmployeeUtilities();
                Employee emp = empUtil.getCurrent(); //get current employee details first               
                displayEmployee(emp); //calling displayEmployee method to display current employee details
            }
        }

        protected void GetHours_Click(object sender, EventArgs e)
        {
            Employee emp = empUtil.getCurrent();
            if (emp.GetType() == typeof(HourlyEmployee))
            {
                float hours = ((HourlyEmployee)emp).getHourworked();
                MessageBox.Show("Employee number was not found", "", MessageBoxButton.OK, MessageBoxImage.Error);
                Response.Write("<script>alert('Hours Worked is '+" + hours + ")</script>");
            }
            else if (emp.GetType() == typeof(SalaryEmployee))
            {
                float salary = ((SalaryEmployee)emp).getMonthlySalary();
                Response.Write("<script>alert('Salary is '+" + salary + ")</script>");
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //try catch for exception handling
            try
            {
                //Parsing string to integer
                int id = Convert.ToInt32(EmployeeSearch.Text);
                //Get thev employee detail using Id
                Employee emp = empUtil.getEmployeeById(id);
                displayEmployee(emp);

            }
            catch ( KeyNotFoundException)
            {//catch null pointer exception
                Response.Write("<script>alert('This Employee number doesn't Exit') </script>");               
            }
            catch (FormatException Ex)
            {//catch number format exception
                Response.Write("<script>alert('Employee Number must be an Integer') </script>");
            }
            catch (Exception Ex)
            {//catch General exception
                Response.Write("<script>alert('An unknown error occured') </script>");                
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            Address a = new Address(Street.Text, City.Text, Province.Text, PostalCode.Text);

            //Initialize employee constructor
            Employee current = empUtil.getCurrent();
            Employee emp = null;
            if (current.GetType() == typeof(SalaryEmployee)) {
                float monthlySalary = ((SalaryEmployee)current).getMonthlySalary();
                 emp = new SalaryEmployee(monthlySalary,Convert.ToInt32(EmployeeNo.Text),
                        JobDescription.Text, LastName.Text, FirstName.Text,
                        Convert.ToChar(MiddleInitial.Text[0]), PhoneNumber.Text,a);
            } else if (current.GetType() == typeof(HourlyEmployee)) {
                float hourlyRate = ((HourlyEmployee)current).getHourlyRate();
                float hoursWorked = ((HourlyEmployee)current).getHourworked();
                emp = new HourlyEmployee(hourlyRate, hoursWorked, Convert.ToInt32(EmployeeNo.Text),
                        JobDescription.Text, LastName.Text, JobDescription.Text,
                        Convert.ToChar(MiddleInitial.Text[0]), PhoneNumber.Text, a);
            }

            empUtil.updateEmployee(emp);
        }

        protected void Previous_Click(object sender, EventArgs e)
        {
            Employee emp = empUtil.getPrevious();
            displayEmployee(emp);
        }

        protected void Next_Click(object sender, EventArgs e)
        {
            Employee emp = empUtil.getNext();
            displayEmployee(emp);
        }
    }
}