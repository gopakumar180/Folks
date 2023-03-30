using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace EmployeeManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void saveButton(object sender, EventArgs e)
        {
            TimeSheet ts = new TimeSheet();
            ts.empNo = Convert.ToInt32(emp_num.Text);
            ts.startDate = Convert.ToDateTime(start_date.Text);
            ts.endDate = Convert.ToDateTime(end_date.Text);
            ts.sunday = Convert.ToInt32(txt_sunday.Text);
            ts.monday = Convert.ToInt32(txt_monday.Text);
            ts.thursday = Convert.ToInt32(txt_thursday.Text);
            ts.wednesday = Convert.ToInt32(txt_wednesday.Text);
            ts.thursday = Convert.ToInt32(txt_thursday.Text);
            ts.friday = Convert.ToInt32(txt_friday.Text);

            Response.Write("<script>alert('Timesheet updated');</script>");
 
        }
        protected void calculateHours(object senders, EventArgs e)
        {
            int ss = Convert.ToInt32(txt_sunday.Text) + Convert.ToInt32(txt_monday.Text) + Convert.ToInt32(txt_tuesday.Text)
                + Convert.ToInt32(txt_wednesday.Text) + Convert.ToInt32(txt_thursday.Text)+ Convert.ToInt32(txt_friday.Text) + Convert.ToInt32(txt_saturday.Text);
            txt_totalHours.Text = Convert.ToString(ss);
             // txt_totalHours.Text = Convert.ToString(txt_sunday.Text) + Convert.ToString(txt_monday.Text);
        }
    }
}