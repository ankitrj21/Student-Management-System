using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Student_Management_System
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralJoindate.Text = DateTime.Now.ToString();

        }

        protected void DDLCoursejoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnections"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[Coursetable] where Cname=@Cname";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Cname", DDLCoursejoin.SelectedItem.Text);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                LabelCoursefee.Text = sdr["Cfee"].ToString();
            }
            sqlconn.Close();

        }

        protected void TextFirstinstallment_TextChanged(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(LabelCoursefee.Text) - Convert.ToInt32(TextFirstinstallment.Text);
            LabelFeedue.Text = balance.ToString();
        }

        protected void ButtonStudent_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnections"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[student] (Stfname,Stlname,Stfathername,Stphone,Stemail,Coursejoin,Coursefee,Firstinstallment,FeeDue,Joindate) values (@Stfname,@Stlname,@Stfathername,@Stphone,@Stemail,@Coursejoin,@Coursefee,@Firstinstallment,@FeeDue,@Joindate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Stfname", TextStfname.Text);
            sqlcomm.Parameters.AddWithValue("@Stlname", TextStlname.Text);
            sqlcomm.Parameters.AddWithValue("@Stfathername", TextFathername.Text);
            sqlcomm.Parameters.AddWithValue("@Stphone", TextStPhone.Text);
            sqlcomm.Parameters.AddWithValue("@Stemail", TextStEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Coursejoin", DDLCoursejoin.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@Coursefee", LabelCoursefee.Text);
            sqlcomm.Parameters.AddWithValue("@Firstinstallment", TextFirstinstallment.Text);
            sqlcomm.Parameters.AddWithValue("@FeeDue", LabelFeedue.Text);
            sqlcomm.Parameters.AddWithValue("@Joindate", LiteralJoindate.Text);
            sqlcomm.ExecuteNonQuery();
            Labelmsg.Text = "The Student " + TextStfname.Text + " " + TextStlname.Text + " is saved succesfully...<br/> The Fees recipt has been sent to email - " + TextStEmail.Text;

            MailMessage mm = new MailMessage("whitedevil130999@gmail.com", TextStEmail.Text);
            mm.Subject = "Recipt Details...!";
            mm.Body = "The Course name " + DDLCoursejoin.SelectedItem.Text + " You have joined and The Course fee is " + LabelCoursefee.Text + " and the installment you have paid " + TextFirstinstallment.Text + "<br/> The Balance Fees is " + LabelFeedue.Text + "<br/><h3 style='color:red'> Note: The Certificate will not be issued until the Balance Amount is clear...!</h3>";
            mm.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("whitedevil130999@gmail.com", "yoyoanurag13");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);

            sqlconn.Close();

        }
    }
}