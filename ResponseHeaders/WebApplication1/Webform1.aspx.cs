using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //http://msdn2.microsoft.com/zh-tw/library/system.uri(VS.80).aspx

                Uri url = new Uri("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=netframework-4.7.2");
                Response.Write("Request.Url.OriginalString ： " + url.OriginalString + "<br/>");
                Response.Write("Request.Url.AbsoluteUri ： " + url.AbsoluteUri + "<br/>");
                Response.Write("Request.Url.Scheme ： " + url.Scheme + "<br/>");
                Response.Write("Request.Url.Host ： " + url.Host + "<br/>");
                Response.Write("Request.Url.Authority ： " + url.Authority + "<br/>");
                Response.Write("Request.Url.Port ： " + url.Port + "<br/>");
                Response.Write("Request.Url.PathAndQuery ： " + url.PathAndQuery + "<br/>");
                Response.Write("Request.Url.AbsolutePath ： " + url.AbsolutePath + "<br/>");
                Response.Write("Request.Url.Query ： " + url.Query + "<br/>");
                Response.Write("Request.QueryString ： " + Request.QueryString.ToString() + "<br/>");
                Response.Write("Request.UserHostAddress ： " + Request.UserHostAddress + "<br/>");
                Response.Write("Request.UserHostName ： " + Request.UserHostName + "<br/>");
                Response.Write("----------------------------------------------------<br/>");

                Uri uri = Request.Url;
                Response.Write("Request.Url.OriginalString ： " + uri.OriginalString + "<br/>");
                Response.Write("Request.Url.AbsoluteUri ： " + uri.AbsoluteUri + "<br/>");
                Response.Write("Request.Url.Scheme ： " + uri.Scheme + "<br/>");
                Response.Write("Request.Url.Host ： " + uri.Host + "<br/>");
                Response.Write("Request.Url.Authority ： " + uri.Authority + "<br/>");
                Response.Write("Request.Url.Port ： " + uri.Port + "<br/>");
                Response.Write("Request.Url.PathAndQuery ： " + uri.PathAndQuery + "<br/>");
                Response.Write("Request.Url.AbsolutePath ： " + uri.AbsolutePath + "<br/>");
                Response.Write("Request.Url.Query ： " + uri.Query + "<br/>");
                Response.Write("Request.QueryString ： " + Request.QueryString.ToString() + "<br/>");
                Response.Write("Request.UserHostAddress ： " + Request.UserHostAddress + "<br/>");
                Response.Write("Request.UserHostName ： " + Request.UserHostName + "<br/>");

                Response.Write("伺服器:" + Server.MachineName + "<br/>");
                Response.Write("逾時時間:" + Server.ScriptTimeout + "<br/>");

                Response.Write("實體路徑:" + Server.MapPath("/"));
                Request.HttpMethod
            }
        }
    }
}