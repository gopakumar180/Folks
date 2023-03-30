using EmployeeManagement.EmpUtilities;
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
        protected void TimeSheet_Click(object sender, EventArgs e)
        {

            Response.Redirect("TimeSheet.aspx");
        }
        protected void GetHours_Click(object sender, EventArgs e)
        {
            Employee emp = empUtil.getCurrent();
            if (emp.GetType() == typeof(HourlyEmployee))
            {
                float hours = ((HourlyEmployee)emp).getHourworked();
                MessageBox.Show("Hours Worked is " + hours, "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (emp.GetType() == typeof(SalaryEmployee))
            {
                float salary = ((SalaryEmployee)emp).getMonthlySalary();
                MessageBox.Show("Salary is " + salary, "", MessageBoxButton.OK, MessageBoxImage.Information);
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
                if (emp != null)
                {
                    displayEmployee(emp);
                }

                else
                {
                    System.Windows.MessageBox.Show("Employee number was not found", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (KeyNotFoundException)
            {//catch null pointer exception
                Response.Write("<script>alert('This Employee number doesn't Exit') </script>");
            }
            catch (NotFiniteNumberException)
            {
                System.Windows.MessageBox.Show("Employee number shound be in number format", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            try
            {
                Address a = new Address(Street.Text, City.Text, Province.Text, PostalCode.Text);

                //Initialize employee constructor
                Employee current = empUtil.getCurrent();
                Employee emp = null;
                if (current.GetType() == typeof(SalaryEmployee))
                {
                    float monthlySalary = ((SalaryEmployee)current).getMonthlySalary();
                    emp = new SalaryEmployee(monthlySalary, Convert.ToInt32(EmployeeNo.Text),
                           JobDescription.Text, LastName.Text, FirstName.Text,
                           Convert.ToChar(MiddleInitial.Text[0]), PhoneNumber.Text, a);
                }
                else if (current.GetType() == typeof(HourlyEmployee))
                {
                    float hourlyRate = ((HourlyEmployee)current).getHourlyRate();
                    float hoursWorked = ((HourlyEmployee)current).getHourworked();
                    emp = new HourlyEmployee(hourlyRate, hoursWorked, Convert.ToInt32(EmployeeNo.Text),
                            JobDescription.Text, LastName.Text, JobDescription.Text,
                            Convert.ToChar(MiddleInitial.Text[0]), PhoneNumber.Text, a);
                }

                empUtil.updateEmployee(emp);
                MessageBox.Show("Successfully Updated", "", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = empUtil.getCurrent();
                empUtil.deleteEmployee(emp);
                MessageBox.Show("Record deleted", "", MessageBoxButton.OK, MessageBoxImage.Information);
                Response.Redirect("EmployeeMaster.aspx",false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}