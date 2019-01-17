<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="WebApplication1.Webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <script type="text/javascript">
        //http://www.w3schools.com/htmldom/dom_obj_location.asp
        document.write("----------JavaScript location--------------------------------" + "<br/>");   
        document.write("location.href ： " + location.href + "<br/>");
        document.write("location.protocol ： " + location.protocol + "<br/>");
        document.write("location.hostname ： " + location.hostname + "<br/>");
        document.write("location.host ： " + location.host + "<br/>");
        document.write("location.port ： " + location.port + "<br/>");
        document.write("location.pathname ： " + location.pathname + "<br/>");
        document.write("location.search ： " + location.search + "<br/>");
        document.write("location.hash ： " + location.hash + "<br/>");
    </script>
</body>
</html>
