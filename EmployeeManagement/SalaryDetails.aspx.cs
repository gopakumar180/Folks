using EmployeeManagement.EmpUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class SalaryDetails : System.Web.UI.Page
    {
        private Employee[] employees = new Employee[1];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                    Button1.EnableViewState = false;
                    if (employees[0].GetType() == typeof(HourlyEmployee))
                    {
                        Button1.Text = "Get Hours";
                    }
                    else
                    {
                        Button1.Text = "Get Salary";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeUtilities empUtilities = new EmployeeUtilities();
            int empId = Convert.ToInt32(EmployeeNo.Text);
            Employee emp = empUtilities.getEmployeeById(empId);
            if (emp.GetType() == typeof(HourlyEmployee))
            {
                float hours = ((HourlyEmployee)emp).getHourworked();
                Response.Write("<script>alert('Hours Worked is '+"+hours+")</script>");
            }
            else if (emp.GetType() == typeof(SalaryEmployee))
            {
                float salary = ((SalaryEmployee)emp).getMonthlySalary();
                Response.Write("<script>alert('Salary is '+" + salary + ")</script>");
            }

        }
    }
}