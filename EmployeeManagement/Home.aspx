<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EmployeeManagement.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="card" >
        <span class="fa fa-times"></span>
        <div class="container">            
            <h4><b><asp:LinkButton ID="LinkButton1" runat="server" OnClick="SalaryDetails_Click">Salary Details</asp:LinkButton></b></h4>
            <%--<p>Architect & Engineer</p>--%>
        </div>
    </div>
     <div class="card">
        <span class="fa fa-times"></span>
        <div class="container">
            <h4><b><asp:LinkButton ID="LinkButton2" runat="server" OnClick="PersonalDetails_Click">Personal Details</asp:LinkButton></b></h4>
            
        </div>
    </div>
     <div class="card">
        <span class="fa fa-times"></span>
        <div class="container">
            <h4><b><asp:LinkButton ID="LinkButton3" runat="server" OnClick="EmployeeHome_Click">Employee Details</asp:LinkButton></b></h4>
            <%--<p>Architect & Engineer</p>--%>
        </div>
    </div>




    <div style="margin-top: 150px">
        
        
        
    </div>
    <asp:Table ID="Table1" runat="server">



        <asp:TableRow>
            <asp:TableCell>
                <asp:LinkButton ID="SalaryDetails" runat="server" OnClick="SalaryDetails_Click">Salary Details</asp:LinkButton>
            </asp:TableCell>
            <asp:TableCell>
                <asp:LinkButton ID="PersonalDetails" runat="server" OnClick="PersonalDetails_Click">Personal Details</asp:LinkButton>
            </asp:TableCell>
            <asp:TableCell>
                <asp:LinkButton ID="EmployeeHome" runat="server" OnClick="EmployeeHome_Click">Employee Details</asp:LinkButton>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
