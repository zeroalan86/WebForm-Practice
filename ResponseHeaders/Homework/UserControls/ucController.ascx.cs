using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class ucController : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnControl_Click(object sender, EventArgs e)
        {
            
        }

        protected void cblControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> selectedList = new List<string>();
            foreach(ListItem item in cblControl.Items)
            {
                if (item.Selected)
                    selectedList.Add(item.Value);
            }
        }
    }
}