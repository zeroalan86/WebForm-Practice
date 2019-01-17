<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucController.ascx.cs" Inherits="Homework.ucController" %>
<%--<%@ Register Src="~/UserControls/ucLogin.ascx" TagPrefix="uc1" TagName="ucLogin" %>--%>

<div class="form-check">
    <%--<uc1:ucLogin runat="server" ID="ucLogin" Visible="false" />--%>
    <asp:CheckBoxList ID="cblControl" runat="server" CssClass="form-check-input" OnSelectedIndexChanged="cblControl_SelectedIndexChanged">
        <asp:ListItem Text="顯示登入區域" Value="Login"></asp:ListItem>
        <asp:ListItem Text="顯示線上人數" Value="PersonNumber"></asp:ListItem>
        <asp:ListItem Text="顯示LOGO" Value="Logo"></asp:ListItem>
    </asp:CheckBoxList>
</div>
<div class="subButton">
    <asp:Button ID="btnControl" CssClass="btn btn-primary" runat="server" OnClick="btnControl_Click"/>
</div>