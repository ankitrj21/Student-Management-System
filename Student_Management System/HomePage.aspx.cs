using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_System
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(TextAdminId.Text == "Admin" && TextAdminPswd.Text == "admin@123")
            {
                Session["Adminname"] = "Welcome " + TextAdminId.Text;
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                LabelMsg.Text = "Failed Login Details...";
            }
        }
    }
}