<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeMaster.aspx.cs" Inherits="EmployeeManagement.EmployeeMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-box" style="margin-top: 20%; margin-bottom: 20px">
        <h2 class="loginLabel" style="text-align: center; margin-bottom: 20px">Employee Details </h2>

        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label12" runat="server" Text="Employee No"></asp:Label>
                <asp:TextBox CssClass="lognText form-control" ID="EmployeeNo" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-lg-6">
            </div>
        </div>
        <%--name--%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label4" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="FirstName" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label11" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="LastName" runat="server"></asp:TextBox>
            </div>
        </div>

        <%--middle name  and street--%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label2" runat="server" Text="Middle Name"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="MiddleInitial" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label3" runat="server" Text="Street"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="Street" runat="server"></asp:TextBox>
            </div>
        </div>

        <%--City  and province--%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label5" runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="City" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label7" runat="server" Text="Province"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="Province" runat="server"></asp:TextBox>
            </div>
        </div>
        <%--Phone  and  Postal Code --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label8" runat="server" Text="Phone Number"></asp:Label>
                <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label9" runat="server" Text="Postal Code"></asp:Label>
                <asp:TextBox CssClass="lognText" ID="PostalCode" runat="server"></asp:TextBox>
            </div>
        </div>
        <%-- Job  Des --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label10" runat="server" Text="Job Description"></asp:Label>
                <asp:TextBox ID="JobDescription" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label1" runat="server" Text="Earnings"></asp:Label>
                <asp:TextBox ID="Earnings" runat="server"></asp:TextBox>
            </div>

        </div>



        <%-- next Prev Buttons--%>
        <div class="row margin-left-20" style="margin-top: 15px; margin-left: 148px; margin-bottom: 15px;">
            <div class="col-lg-6">
                <asp:Button ID="Previous" runat="server" Text="<<" OnClick="Previous_Click" />
            </div>
            <div class="col-lg-6">
                <asp:Button ID="Next" runat="server" Text=">>" OnClick="Next_Click" />
            </div>
        </div>
        <%--search--%>
        <div class="row margin-left-20" style=" margin-bottom: 15px;">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" runat="server" Text="Employee No"></asp:Label>
                <asp:TextBox ID="EmployeeSearch" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Button ID="Button1" CssClass="loginLabel btn btn-primary mb-4" OnClick="Search_Click" runat="server" Text="Search" />
                <asp:Button ID="Save" CssClass="loginLabel btn btn-danger mb-4" OnClick="Save_Click" runat="server" Text="Save" />
            </div>

        </div>

    </div>



    <asp:Table ID="Table1" runat="server">






        <asp:TableRow>


            <asp:TableCell>
                <asp:Button ID="GetHours" OnClick="GetHours_Click" runat="server" Text="Get Hours" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <%--<asp:TableCell>
                  <asp:Label runat="server" Text="Employee No"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="EmployeeSearch" runat="server"></asp:TextBox>
            </asp:TableCell>--%>
            <asp:TableCell>
                <%--<asp:Button ID="Search" OnClick="Search_Click" runat="server" Text="Search" />--%>
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
