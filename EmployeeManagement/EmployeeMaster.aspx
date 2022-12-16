<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeMaster.aspx.cs" Inherits="EmployeeManagement.EmployeeMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">          
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label11" runat="server" Text="Employee No"></asp:Label>    
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="EmployeeNo" runat="server" Enabled="false"></asp:TextBox>
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
                <asp:TextBox ID="JobDescription" runat="server" Enabled="false"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
              <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Previous" runat="server" Text="<<" onclick="Previous_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Next" runat="server" Text=">>" onclick="Next_Click"/>
            </asp:TableCell>
                  <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Earnings"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Earnings" runat="server" Enabled="false"></asp:TextBox>
            </asp:TableCell>
                  <asp:TableCell>
               <asp:Button ID="GetHours" onclick="GetHours_Click" runat="server" Text="Get Hours" />
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>
                  <asp:Label runat="server" Text="Employee No"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                   <asp:TextBox ID="EmployeeSearch" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Search" OnClick="Search_Click" runat="server" Text="Search" />
            </asp:TableCell>
               <asp:TableCell>
                <asp:Button ID="Save" OnClick="Save_Click" runat="server" Text="Save" />
            </asp:TableCell>
        </asp:TableRow> 
    </asp:Table>
</asp:Content>
