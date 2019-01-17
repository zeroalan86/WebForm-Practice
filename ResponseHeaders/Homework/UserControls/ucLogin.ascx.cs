using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        public HtmlGenericControl Login
        {
            get
            {
                return LoginStyle;
            }
            set
            {
                LoginStyle = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserID"] != null)
            {
                LoginStyle.Attributes["class"] = "Login";
                UserID.Visible = true;
                ltUserID.Text = HttpContext.Current.Server.UrlDecode(Request.Cookies["UserID"].ToString());
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}