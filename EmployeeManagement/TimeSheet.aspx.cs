using EmployeeManagement.EmpUtilities;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace EmployeeManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private object console;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;
            start_date.Text = DateTime.Now.ToShortDateString();

            // Find the day of the week for the current date
            DayOfWeek currentDayOfWeek = currentDate.DayOfWeek;

            // Calculate the number of days to subtract to get to the last Monday
            int daysToSubtract = ((int)currentDayOfWeek + 7 - (int)DayOfWeek.Monday) % 7;
            int daysToSubtractForSynday = ((int)currentDayOfWeek + 7 - (int)DayOfWeek.Sunday) % 7;
            // Subtract the calculated number of days from the current date to get the last Monday
            DateTime lastMonday = currentDate.AddDays(-daysToSubtract);
            DateTime lastSunday = lastMonday.AddDays(6);
            // Display the last Monday
            Console.WriteLine("Last Monday: " + lastMonday.ToShortDateString());
           emp_num.Text = "Default Value";
            //
            // start_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //start_date.Text = DateTime.Now.ToShortDateString();
            start_date.Text = lastMonday.ToString("yyyy-MM-dd");
            end_date.Text = lastSunday.ToString("yyyy-MM-dd");
          //  end_date.Text = lastSunday.ToString("yyyy-mm-dd");
           // MessageBox.Show(lastMonday.ToShortDateString());

        }

        protected void choosePeriod(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Timesheet  Inserted' );</script>");
            string v = timesheetPeriod.SelectedValue;

            MessageBox.Show(v);
        }
           
        protected void saveButton(object sender, EventArgs e)
        {

            try
            {
               
                //Response.Write("<script>alert('Timesheet updated');</script>");
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
                ts.totalHour = Convert.ToInt32(txt_totalHours.Text);
                DbConnection dbConnection = new DbConnection();
                bool update = dbConnection.timesheetUpdate(ts);

                if (update) {
                    Response.Write("<script>alert('Timesheet  Inserted' );</script>");
                }

              
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("You answered yes, yes and no.");
                //MessageBox.Show(new Form() { TopMost = true }, boxText, "Box Title",
                // MessageBoxButtons.OK, boxIcon);
                Response.Write("<script>alert('An Unexpected Error Occured');</script>");
                //System.Windows.MessageBox.Show("An Unexpected Error Occured", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }

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