<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimeSheet.aspx.cs" Inherits="EmployeeManagement.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <section id="main-content">
       <section id="wrapper">
           <div class="row">
               <div class="col-lg-12">
                   <section class="panel" style="margin-top:5%">
                       <header  class="panel-heading">
                           <div  class="col-md-12">
                              <h1 style="text-align:center;color: #297272;"> Timesheet</h1>
                           </div>
                       </header>
                       <div class="panel-body">
                           <div class="row">
                               <div class="form-group col-md-6">
                                   <asp:Label CssClass="form-control">Employee Number</asp:Labe>
                                   <asp:TextBox id="emp_num" CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                          </div>
                            <div class="row">
                               <div class="form-group col-md-6" >
                                   <asp:Label CssClass="form-control">Starting week date</asp:Labe>
                                   <asp:TextBox ID="start_date"  CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           
                               <div class="form-group col-md-6">
                                   <asp:Label CssClass="form-control">Ending week date</asp:Labe>
                                   <asp:TextBox ID="end_date"  CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           </div>
                            <div class="row">
                               <div class="col-md-6">
                                   <asp:Label  CssClass="form-control">Sunday</asp:Labe>
                                   <asp:TextBox ID="txt_sunday" TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours" CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           
                               <div class="col-md-6">
                                   <asp:Label  CssClass="form-control">Monday</asp:Labe>
                                   <asp:TextBox ID="txt_monday" TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours" CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           </div>
                            <div class="row">
                               <div class="col-md-6">
                                   <asp:Label CssClass="form-control">Tuesday</asp:Labe>
                                   <asp:TextBox ID="txt_tuesday" TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours"   CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           
                               <div class="col-md-6">
                                   <asp:Label  CssClass="form-control">Wednesday</asp:Labe>
                                   <asp:TextBox ID="txt_wednesday"  TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours"  CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           </div>
                            <div class="row">
                               <div class="col-md-6">
                                   <asp:Label CssClass="form-control">Thursday</asp:Labe>
                                   <asp:TextBox ID="txt_thursday"  TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours"  CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                          
                               <div class="col-md-6">
                                   <asp:Label CssClass="form-control">Friday</asp:Labe>
                                   <asp:TextBox id="txt_friday" CssClass="form-control"  TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours"  runat="server"></asp:TextBox>
                               </div>
                           </div>
                           <div class="row">
                               <div class="col-md-6">
                                   <asp:Label CssClass="form-control">Saturday</asp:Labe>
                                   <asp:TextBox  ID="txt_saturday" CssClass="form-control"  TextMode="Number" Text="0" AutoPostBack="True" OnTextChanged="calculateHours"  runat="server"></asp:TextBox>
                               </div>
                           </div>
                           <div class="row">
                               <div class="col-md-6">
                                   <asp:Label CssClass="form-control">Total Hours</asp:Labe>
                                   <asp:TextBox ID="txt_totalHours"  CssClass="form-control" runat="server"></asp:TextBox>
                               </div>
                           </div>
                           <div class="row">
                               <div style="margin-top:5px" class="col-md-4">
                                    <asp:Button ID="timesheetSave" runat="server" Text="Save" CssClass="loginLabel btn btn-primary btn-block mb-4" OnClick="saveButton" />
                               </div>
                           </div>
                       </div>
                   </section>
               </div>
           </div>
       </section>
   </section>
   
    
</asp:Content>
