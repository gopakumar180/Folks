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
           
            
        }

        protected void PersonalDetails_Click(object sender, EventArgs e)
        {
                        
            Response.Redirect("PersonalDetails.aspx");
        }

        protected void SalaryDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryDetails.aspx");
        }

        protected void EmployeeHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeMaster.aspx");
        }
    }
}