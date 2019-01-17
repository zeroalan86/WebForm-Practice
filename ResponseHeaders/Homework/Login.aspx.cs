using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DataCheck())
                return;
            else
                Response.Redirect("~/Default.aspx");
        }

        private bool DataCheck()
        {
            if (string.IsNullOrEmpty(tbAccount.Text))
            {
                PageUtility.MessageBox(this, "請輸入帳號");
                return false;
            }

            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                PageUtility.MessageBox(this, "請輸入密碼");
                return false;
            }


            var context = new DBForum();

            var result = context.Account.ToList();

            
            if (result.Count() > 0)
            {
                foreach (var item in result)
                {
                    if (item.Account1 == tbAccount.Text && item.Password == tbPassword.Text)
                    {
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                        1,
                        tbAccount.Text,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(60),
                        false,
                        tbAccount.Text,
                        FormsAuthentication.FormsCookiePath);

                        var encryptTicket = FormsAuthentication.Encrypt(ticket);
                        HttpCookie cookie = new HttpCookie("UserID", encryptTicket);
                        cookie.HttpOnly = true;
                        this.Response.AppendCookie(cookie);
                        break;
                    }
                    else
                    {
                        PageUtility.MessageBox(this, "帳號密碼有錯誤");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                PageUtility.MessageBox(this, "無此帳號密碼");
                return false;
            }
            
        }

        public class ViewAccount
        {
            public string Account { get; set; }
            public string Password { get; set; }
        }

        public class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                //+ character added after strMsg "')"
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('" + strMsg + "')", true);

            }
        }
    }
}