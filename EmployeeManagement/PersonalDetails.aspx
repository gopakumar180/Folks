<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="EmployeeManagement.PersonalDetails" %>









<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-box" style="margin-top: 20%; margin-bottom: 20px">
        <h2 class="loginLabel" style="text-align: center; margin-bottom: 20px">Employee Details </h2>

        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label1" runat="server" Text="Employee No"></asp:Label>
                <asp:TextBox CssClass="lognText form-control" ID="EmployeeId" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-lg-6">
            </div>
        </div>

        <%--first and last--%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" class="form-label" ID="Label4" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox CssClass="lognText form-control" ID="FirstName" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label CssClass="loginLabel" ID="Label11" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox CssClass="lognText form-control" ID="LastName" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- street and middle   --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                <asp:Label ID="Label6" CssClass="loginLabel" runat="server" Text="Middle Initial"></asp:Label>
                <asp:TextBox CssClass="lognText form-control" ID="MiddleInitial" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label ID="Label3" CssClass="loginLabel" runat="server" Text="Street"></asp:Label>
                <asp:TextBox ID="Street" CssClass="lognText form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- phone and city --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                  <asp:Label ID="Label8" runat="server" Text="Phone Number"></asp:Label>
                <asp:TextBox ID="PhoneNumber"  CssClass="lognText form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-6">
                <asp:Label ID="Label5" CssClass="loginLabel"  runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="City" CssClass="lognText form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- province  and post --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                    <asp:Label ID="Label7" CssClass="loginLabel" runat="server" Text="Province"></asp:Label>
                <asp:TextBox ID="Province" CssClass="lognText form-control" runat="server"></asp:TextBox>
             </div>
            <div class="col-lg-6">
                 <asp:Label ID="Label9"  CssClass="loginLabel" runat="server" Text="Postal Code"></asp:Label>
                <asp:TextBox ID="PostalCode" CssClass="lognText form-control" runat="server"></asp:TextBox> 
            </div>
        </div>

          <%-- des --%>
        <div class="row margin-left-20">
            <div class="col-lg-6">
                    <asp:Label ID="Label10" CssClass="loginLabel" runat="server" Text="Job Description"></asp:Label>
                <asp:TextBox ID="JobDescription"  CssClass="lognText form-control" runat="server" Enabled="false"></asp:TextBox>
             </div>
            
        </div>

        <div style="display: flex; align-items: center; margin-bottom:10px; margin-left: 73%;">
         <asp:Button ID="Update" runat="server" CssClass="loginLabel btn btn-primary mb-4" Text="Update" OnClick="Update_Click" />
            </div>

    </div>

 


    <asp:Table ID="Table1" runat="server">


        <asp:TableRow>

            <asp:TableCell>
               
            </asp:TableCell>
            <asp:TableCell>
                 
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
              
            </asp:TableCell>
            <asp:TableCell>
               
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
               
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
               
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
