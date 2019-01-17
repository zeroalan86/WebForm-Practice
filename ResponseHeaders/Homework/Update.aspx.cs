using Homework.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class Update : System.Web.UI.Page
    {
        private const string backUrl = "~/Update.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDataSource();
        }

        private void GetDataSource()
        {
            List<Account> AccountList = GetAccountList();
            List<Profile> profileList = GetProfilesList();
            var result = from a in AccountList
                         join p in profileList on a.Id equals p.AccountID
                         select new { p.ProfileContent };

            repList.DataSource = result;
            repList.DataBind();
        }

        static List<Profile> GetProfilesList()
        {
            List<Profile> profiles = new List<Profile>();
            return profiles;
        }

        static List<Account> GetAccountList()
        {
            List<Account> account = new List<Account>();
            return account;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(backUrl);
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            Button EditButton = FindControl("EditButton") as Button;
            Button DeleteButton = FindControl("DeleteButton") as Button;
            Button UpdateButton = FindControl("UpdateButton") as Button;
            Button CancelButton = FindControl("CancelButton") as Button;
            EditButton.Visible = false;
            DeleteButton.Visible = false;
            UpdateButton.Visible = true;
            CancelButton.Visible = true;
            //tbProfile.Visible = true;
            //todo loadProfileData
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        protected void CreateProfile_Click(object sender, EventArgs e)
        {

        }
    }
}