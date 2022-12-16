using EmployeeManagement.EmpUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace EmployeeManagement
{
    public partial class SalaryDetails : System.Web.UI.Page
    {
        private Employee[] employees = new Employee[1];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    int userId = int.Parse(ticket.UserData);
                    DbConnection dbConnection = new DbConnection();
                    dynamic obj = dbConnection.GetEmployeeSalary(userId);
                    if (obj != null)
                    {
                        employees[0] = (Employee)obj[0];
                        Earnings.Text = Convert.ToString(employees[0].getEarnings());
                        EmployeeNo.Text = Convert.ToString(employees[0].getEmployeeNo());
                        GetHours.EnableViewState = false;
                        if (employees[0].GetType() == typeof(HourlyEmployee))
                        {
                            GetHours.Text = "Get Hours";
                        }
                        else
                        {
                            GetHours.Text = "Get Salary";
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        protected void GetHours_Click1(object sender, EventArgs e)
        {
            try
            {
                EmployeeUtilities empUtilities = new EmployeeUtilities();
                int empId = Convert.ToInt32(EmployeeNo.Text);
                Employee emp = empUtilities.getEmployeeById(empId);
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
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}