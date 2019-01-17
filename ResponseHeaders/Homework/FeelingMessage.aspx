<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FeelingMessage.aspx.cs" Inherits="Homework.FeelingMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h2>心情留言</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <asp:TextBox ID="tbProfile" runat="server" CssClass="form-control" Rows="3" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:Button ID="InsertMessage" runat="server" Text="儲存" OnClick="InsertMessage_Click" />
        </div>
    </div>
</asp:Content>
