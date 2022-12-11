using EmployeeManagement.EmpUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dt = dbConnection.isAuthenticated(UserName.Text, Password.Text);
            if (dt.Rows.Count>0)
            {
                var ticket = new FormsAuthenticationTicket(1, UserName.Text, DateTime.Now, DateTime.Now.AddMinutes(60), false, dt.Rows[0].ItemArray[0].ToString());
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)) { HttpOnly = true });
                Response.Redirect("Home.aspx");

            }
            
            else
            {
                Label1.Text = "Your username and word is incorrect";
            }
        }
    }
}