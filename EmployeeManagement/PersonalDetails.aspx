<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="EmployeeManagement.PersonalDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Employee No"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="EmployeeId" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Street"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Street" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="First Name"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="City" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label6" runat="server" Text="Middle Initial"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="MiddleInitial" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label7" runat="server" Text="Province"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Province" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label8" runat="server" Text="Phone Number"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label9" runat="server" Text="Postal Code"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label10" runat="server" Text="Job Description"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="JobDescription" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
