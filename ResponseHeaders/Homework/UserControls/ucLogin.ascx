<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="Homework.ucLogin" %>
<div id="LoginStyle" runat="server">
    <div id="UserID" runat="server" visible="false">
        <asp:Literal ID="ltUserID" runat="server" Text=""></asp:Literal>
    </div>
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
    <a href="~/Update.aspx" runat="server">編輯</a>
</div>