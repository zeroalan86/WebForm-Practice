<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Homework.Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="repList" runat="server">
        <ItemTemplate>
            <div class="row">
                <div class="col-md-4">
                    <h2>個人簡介編輯清單</h2>
                    <asp:Literal ID="UpdateProfile" runat="server" Text='<%#Eval("ProfileContent") %>'></asp:Literal>
                    <asp:TextBox ID="tbProfile" runat="server" Visible="false" Text='<%#Eval("ProfileContent") %>' />
                </div>
                <div class="col-md-4">
                    <asp:Button ID="CreateProfile" runat="server" Text="新增" OnClick="CreateProfile_Click" />
                </div>
            </div>
            <div class="row mt-5">
                <div class="col-md-4"></div>
                <div class="col-md-2">
                    <asp:Button ID="UpdateButton" runat="server" Text="更新" OnClick="UpdateButton_Click" Visible="false" />
                    <asp:Button ID="EditButton" runat="server" Text="修改" OnClick="EditButton_Click" />
                </div>
                <div class="col-md-2">
                    <asp:Button ID="CancelButton" runat="server" Text="取消" OnClick="CancelButton_Click" Visible="false" />
                    <asp:Button ID="DeleteButton" runat="server" Text="刪除" OnClick="DeleteButton_Click" />
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
