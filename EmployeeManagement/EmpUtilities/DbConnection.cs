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
    }
}