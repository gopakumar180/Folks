<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalaryDetails.aspx.cs" Inherits="EmployeeManagement.SalaryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-box" style="margin-top: 100px; margin-bottom: 20px">
        <h2 class="loginLabel" style="text-align: center; margin-bottom: 20px">Salary Details </h2>

        <div class="row margin-left-20">

            <div class="col-lg-6">


                <asp:Label ID="Label2" runat="server" Text="Employee No" CssClass="loginLabel" class="form-label"></asp:Label>
                <asp:TextBox ID="EmployeeNo" runat="server" Enabled="false" CssClass="lognText form-control"></asp:TextBox>

            </div>
            <div class="col-lg-6">
                <asp:Label class="form-label" ID="Label1" runat="server" Text="Label" CssClass="loginLabel">Total Earnings</asp:Label>
                <asp:TextBox ID="Earnings" runat="server" CssClass="lognText form-control"></asp:TextBox>
            </div>
        </div>
        <div style="display: flex; align-items: center; margin-left: 73%;">
            <asp:Button ID="GetHours" runat="server" CssClass="loginLabel btn btn-primary mb-4" OnClick="GetHours_Click1" Text="Get Hours" />
        </div>

    </div>



</asp:Content>
