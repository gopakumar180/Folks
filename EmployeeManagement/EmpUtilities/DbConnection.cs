using System;
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
            SqlDataAdapter sda= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            //Address address = new Address(dt.Rows[0]["Street"].ToString(), dt.Rows[0]["City"].ToString(), dt.Rows[0]["Province"].ToString(), dt.Rows[0]["PostalCode"].ToString());
            PersonViewModel emp = new PersonViewModel(Convert.ToInt32(dt.Rows[0]["UserId"]), dt.Rows[0]["LastName"].ToString(), dt.Rows[0]["Street"].ToString(), dt.Rows[0]["FirstName"].ToString(), dt.Rows[0]["City"].ToString(),dt.Rows[0]["MiddleInt"].ToString(), dt.Rows[0]["Province"].ToString(), dt.Rows[0]["PhoneNumber"].ToString(), dt.Rows[0]["PostalCode"].ToString(), dt.Rows[0]["JobDescription"].ToString());
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
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}