using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Management_System
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCourse_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnections"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Coursetable] (Cname,Cduration,Cfee) values (@Cname,@Cduration,@Cfee)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Cname", TextCoursename.Text);
            sqlcomm.Parameters.AddWithValue("@Cduration", TextDuration.Text);
            sqlcomm.Parameters.AddWithValue("@Cfee", TextFees.Text);
            sqlcomm.ExecuteNonQuery();
            LabelMsg.Text = "The Course " + TextCoursename.Text + " is saved succesfuly...!";
            TextCoursename.Text = "";
            TextDuration.Text = "";
            TextFees.Text = "";

            sqlconn.Close();

        }
    }
}