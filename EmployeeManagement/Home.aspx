<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EmployeeManagement.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
      <%--  <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="EmployeeLabel" runat="server" Text="Employee No"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="EmployeeNo" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Search" runat="server" Text="Search" />
            </asp:TableCell>
        </asp:TableRow>--%>
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
