using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_System
{
    public partial class SMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Adminname"] != null)
            {
                LabelUserlogin.Text = Session["Adminname"].ToString();
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }

        }

        protected void LinkCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursePage.aspx");
        }

        protected void LinkTutor_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorPage.aspx");
        }

        protected void LinkStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPage.aspx");
        }

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }
    }
}