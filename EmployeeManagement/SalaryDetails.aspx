<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalaryDetails.aspx.cs" Inherits="EmployeeManagement.SalaryDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Employee No"></asp:Label>
    <asp:TextBox ID="EmployeeNo" runat="server" Enabled="false"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Label">Total Earnings</asp:Label>
    <asp:TextBox ID="Earnings" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Hours" />
</asp:Content>
