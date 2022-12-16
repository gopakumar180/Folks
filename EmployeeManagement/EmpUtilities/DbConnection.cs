using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace EmployeeManagement.EmpUtilities
{
    public class DbConnection
    {
        public SqlConnection GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["mytest"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
        public DataTable isAuthenticated(string userName, string pwd)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("select * from UserLogin where UserName=@username and Password=@password", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@password", pwd);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }
        public PersonViewModel GetEmployee(int id)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("select * from UserLogin where UserId=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            //Address address = new Address(dt.Rows[0]["Street"].ToString(), dt.Rows[0]["City"].ToString(), dt.Rows[0]["Province"].ToString(), dt.Rows[0]["PostalCode"].ToString());
            PersonViewModel emp = new PersonViewModel(Convert.ToInt32(dt.Rows[0]["UserId"]), dt.Rows[0]["LastName"].ToString(), dt.Rows[0]["Street"].ToString(), dt.Rows[0]["FirstName"].ToString(), dt.Rows[0]["City"].ToString(), dt.Rows[0]["MiddleInt"].ToString(), dt.Rows[0]["Province"].ToString(), dt.Rows[0]["PhoneNumber"].ToString(), dt.Rows[0]["PostalCode"].ToString(), dt.Rows[0]["JobDescription"].ToString());
            conn.Close();
            return emp;
        }
        public bool UpdateEmployee(PersonViewModel personViewModel)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("UPDATE UserLogin SET LastName = @laname, Street = @strt, FirstName= @fname, City = @city, MiddleInt = @mint, Province = @prov, PhoneNumber = @phn, PostalCode = @pcode Where UserId = @uid", conn);
            cmd.Parameters.AddWithValue("@laname", personViewModel.lastName);
            cmd.Parameters.AddWithValue("@strt", personViewModel.street);
            cmd.Parameters.AddWithValue("@fname", personViewModel.firstName);
            cmd.Parameters.AddWithValue("@city", personViewModel.city);
            cmd.Parameters.AddWithValue("@mint", personViewModel.middleInit);
            cmd.Parameters.AddWithValue("@prov", personViewModel.province);
            cmd.Parameters.AddWithValue("@phn", personViewModel.phoneNo);
            cmd.Parameters.AddWithValue("@pcode", personViewModel.postalCode);
            cmd.Parameters.AddWithValue("@uid", personViewModel.employeeNo);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ArrayList GetEmployeeSalary(int id)
        {
            ArrayList employees = new ArrayList();
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(" select UserId,MonthlySalary,HourlyRate,HoursWorked,UserType,JobDescription from UserLogin left join [SalaryEmployee] on SalaryEmployee.EmployeeID=UserId left join HourlyEmployee on HourlyEmployee.EmployeeID=UserId where UserId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            SalaryEmployee emp = new SalaryEmployee();
            HourlyEmployee empHourly = new HourlyEmployee();
            if (Convert.ToInt32(dt.Rows[0]["UserType"]) == 2)
            {
                emp = new SalaryEmployee(float.Parse(dt.Rows[0]["MonthlySalary"].ToString()), Convert.ToInt32(dt.Rows[0]["UserId"].ToString()), dt.Rows[0]["JobDescription"].ToString());
                employees.Add(emp);
            }
            else if (Convert.ToInt32(dt.Rows[0]["UserType"]) == 1)
            {
                empHourly = new HourlyEmployee(float.Parse(dt.Rows[0]["HourlyRate"].ToString()), float.Parse(dt.Rows[0]["HoursWorked"].ToString()), Convert.ToInt32(dt.Rows[0]["UserId"].ToString()), dt.Rows[0]["JobDescription"].ToString());
                employees.Add(empHourly);
            }
            return employees;
        }
        public ArrayList GetEmployeeList()
        {
            ArrayList employees = new ArrayList();
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(" select * from UserLogin left join [SalaryEmployee] on SalaryEmployee.EmployeeID=UserId left join HourlyEmployee on HourlyEmployee.EmployeeID=UserId", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            
            for (int i=0;i<dt.Rows.Count;i++)
            {
                Address address = new Address(dt.Rows[i]["Street"].ToString(), dt.Rows[i]["City"].ToString(),
                    dt.Rows[i]["Province"].ToString(), dt.Rows[i]["PostalCode"].ToString());
                if (Convert.ToInt32(dt.Rows[i]["UserType"]) == 2)
                {                   
                    SalaryEmployee emp = new SalaryEmployee(float.Parse(dt.Rows[i]["MonthlySalary"].ToString()), Convert.ToInt32(dt.Rows[i]["UserId"]),
                            dt.Rows[i]["JobDescription"].ToString(), dt.Rows[i]["LastName"].ToString(), dt.Rows[i]["FirstName"].ToString(),
                            Convert.ToChar(dt.Rows[i]["MiddleInt"].ToString()[0]), dt.Rows[i]["PhoneNumber"].ToString(), address);
                    employees.Add(emp);
                }
                else if (Convert.ToInt32(dt.Rows[i]["UserType"]) == 1)
                {
                   HourlyEmployee empHourly = new HourlyEmployee(float.Parse(dt.Rows[i]["HourlyRate"].ToString()), float.Parse(dt.Rows[i]["HoursWorked"].ToString()), Convert.ToInt32(dt.Rows[i]["UserId"]),
                            dt.Rows[i]["JobDescription"].ToString(), dt.Rows[i]["LastName"].ToString(), dt.Rows[i]["FirstName"].ToString(),
                            Convert.ToChar(dt.Rows[i]["MiddleInt"].ToString()[0]), dt.Rows[0]["PhoneNumber"].ToString(), address);
                    employees.Add(empHourly);
                }
            }


            return employees;
        }
    }
}