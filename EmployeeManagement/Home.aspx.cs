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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                string Name = Application["Name"].ToString();
                if (Name == "1") { 
                    LinkButton3.Visible = true;
                    HrDiv.Visible = true;
                }
                LinkButton3.EnableViewState = false;
                
            }

        }

        protected void PersonalDetails_Click(object sender, EventArgs e)
        {

            Response.Redirect("PersonalDetails.aspx", false);
        }

        protected void SalaryDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryDetails.aspx", false);
        }

        protected void EmployeeHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeMaster.aspx", false);
        }
    }
}