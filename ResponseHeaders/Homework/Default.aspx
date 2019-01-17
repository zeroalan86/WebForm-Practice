<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Homework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h2>個人簡介</h2>
            <p>
                <asp:Literal ID="defaultProfile" runat="server" Text="" />
            </p>
        </div>
    </div>

</asp:Content>
