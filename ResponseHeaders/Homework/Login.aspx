<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Homework.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登入頁</title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/css/bootstrap.min.css" integrity="sha384-Smlep5jCw/wG7hdkwQ/Z5nLIefveQRIY9nfy6xoR1uRYBtpZgI6339F5dgvm/e9B"
        crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <h1 style="text-align:center;"><strong>登入</strong></h1>
                </div>
                <div class="col-12">
                    <asp:TextBox ID="tbAccount" runat="server" CssClass="form-control mt-5" placeholder="帳號" />
                </div>
                <div class="col-12">
                    <asp:TextBox ID="tbPassword" type="password" runat="server" CssClass="form-control mt-5" placeholder="密碼" />
                </div>
                <div class="col-12">
                    <asp:Button ID="btnLogin" runat="server" Text="登入" CssClass="btn btn-info mt-5" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
