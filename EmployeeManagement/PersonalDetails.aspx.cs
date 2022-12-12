﻿using EmployeeManagement.EmpUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                Message.Visible=false;
                Message.EnableViewState = false;
                try
                {

                    HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    int userId = int.Parse(ticket.UserData);
                    DbConnection dbConnection = new DbConnection();
                    PersonViewModel personViewModel = dbConnection.GetEmployee(userId);
                    if (personViewModel != null)
                    {
                        EmployeeId.Text = personViewModel.employeeNo.ToString();
                        LastName.Text = personViewModel.lastName.ToString();
                        Street.Text = personViewModel.street.ToString();
                        FirstName.Text = personViewModel.firstName.ToString();
                        City.Text = personViewModel.city.ToString();
                        MiddleInitial.Text = personViewModel.middleInit.ToString();
                        Province.Text = personViewModel.province.ToString();
                        PhoneNumber.Text = personViewModel.phoneNo.ToString();
                        PostalCode.Text = personViewModel.postalCode.ToString();
                        JobDescription.Text = personViewModel.jobDescription.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Message.Text = "Page not loaded properly. Please try again";
                }
            }
           
        }

        protected void Update_Click(object sender, EventArgs e)
        {

            try
            {
                Message.Visible = true;
                PersonViewModel personViewModel = new PersonViewModel();
                personViewModel.employeeNo = Convert.ToInt32(EmployeeId.Text);
                personViewModel.lastName = LastName.Text;
                personViewModel.street = Street.Text;
                personViewModel.firstName = FirstName.Text;
                personViewModel.city = City.Text;
                personViewModel.middleInit = MiddleInitial.Text;
                personViewModel.phoneNo = PhoneNumber.Text;
                personViewModel.postalCode = PostalCode.Text;
                personViewModel.jobDescription = JobDescription.Text;
                personViewModel.province = Province.Text;

                DbConnection dbConnection = new DbConnection();
                bool update = dbConnection.UpdateEmployee(personViewModel);
                if (update)
                {
                    Message.Text = "Successfully Updated";
                }
                else
                {
                    Message.Text = "Nothing to Update";
                }
            }
            catch(Exception ex)
            {
                Message.Text = "Please try after some time";
            }
        }
    }
}