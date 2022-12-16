<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeManagement.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <%-- <div>
        <asp:Label ID="Label1" runat="server" Text="User Name" class="form-label"></asp:Label>
        <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password" runat="server" CssClass="form-control"></asp:TextBox>
    </div>--%>
    <div>
        <%--<asp:Button ID="Button1" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block mb-4" OnClick="Button1_Click" />--%>
   
       <%-- <asp:Login ID = "Login1" runat = "server" OnAuthenticate= "ValidateUser"></asp:Login>--%>
    </div>


    <div class="loginbox" >
      <div class="circular--landscape">
           <img  class="user" src="Content/avtar.jpg" />


      </div>
        <div class="padding-top-10">
            <asp:Label ID="Label1" runat="server" Text="User Name" CssClass="loginLabel" class="form-label"></asp:Label>
            <asp:TextBox ID="UserName" runat="server" CssClass="lognText form-control"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" CssClass="loginLabel"  Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" CssClass="lognText form-control"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Sign in" CssClass=" loginLabel btn btn-primary btn-block mb-4" OnClick="Button1_Click" />
        </div>
        

     </div>

</asp:Content>
