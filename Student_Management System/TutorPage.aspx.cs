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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralJoindate.Text = DateTime.Now.ToString();

        }

        protected void ButtonTutor_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnections"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[tutor] (Tname,Tphone,Temail,Tcourse,Tqualifiaction,Tjoindate) values (@Tname,@Tphone,@Temail,@Tcourse,@Tqualifiaction,@Tjoindate)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Tname", TextTutorname.Text);
            sqlcomm.Parameters.AddWithValue("@Tphone", TextPhone.Text);
            sqlcomm.Parameters.AddWithValue("@Temail", TextEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Tcourse", DDLCourse.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@Tqualifiaction", TextQualification.Text);
            sqlcomm.Parameters.AddWithValue("@Tjoindate", LiteralJoindate.Text);
            sqlcomm.ExecuteNonQuery();
            Labelmsg.Text = "The Tutor " + TextTutorname.Text + " is saved successfuly ...!";
            TextTutorname.Text = "";
            TextPhone.Text = "";
            TextEmail.Text = "";
            TextQualification.Text = "";

            sqlconn.Close();

        }

        protected void DDLCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}