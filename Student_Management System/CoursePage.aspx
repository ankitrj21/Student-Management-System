<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Student_Management_System.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Course Page ....!!</h1>
    <div style="background-color:aqua; width: 332px; height:119px;">
        <table border="1" style="height: 86px; width: 326px">
            <tr>
                <td>Course Name</td>
                <td>
                    <asp:TextBox ID="TextCoursename" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 28px">Course Duration</td>
                <td style="height: 28px">
                    <asp:TextBox ID="TextDuration" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course Fees</td>
                <td>
                    <asp:TextBox ID="TextFees" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonCourse" runat="server" Text="Insert New Course" OnClick="ButtonCourse_Click" /></td>
                <td>
                    <asp:Label ID="LabelMsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
