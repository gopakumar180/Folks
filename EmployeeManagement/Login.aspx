<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeManagement.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 


    <div class="loginbox" >
      <div class="circular--landscape">
           <img  class="user" src="Content/avtar.jpg" />


      </div>
        <div class="padding-top-10">
            <asp:Label ID="Label1" runat="server" Text="User Name" CssClass="loginLabel" class="form-label"></asp:Label>
            <asp:TextBox ID="UserName" runat="server" CssClass="lognText form-control"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" CssClass="loginLabel"  Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="lognText form-control"></asp:TextBox>
            <asp:Button ID="LoginBtn" runat="server" Text="Sign in" CssClass="loginLabel btn btn-primary btn-block mb-4" OnClick="LoginBtn_Click" />
            <span><asp:Literal id="alert" runat="server" /></span>
        </div>
        

     </div>

</asp:Content>
