<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="TutorPage.aspx.cs" Inherits="Student_Management_System.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Tutor Page...!!</h1>
    <div style="background-color:aqua; width: 285px; height:190px;">
        <table border="1">
            <tr>
                <td>Tutor Name</td>
                <td>
                    <asp:TextBox ID="TextTutorname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone</td>
                <td>
                    <asp:TextBox ID="TextPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course</td>
                <td>
                    <asp:DropDownList ID="DDLCourse" runat="server" DataSourceID="SqlDataSource1" AppendDataBoundItems="true" DataTextField="Cname" DataValueField="Cname" OnSelectedIndexChanged="DDLCourse_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="--Select Courses--"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Myconnections %>" ProviderName="<%$ ConnectionStrings:Myconnections.ProviderName %>" SelectCommand="SELECT * FROM [Coursetable]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Qualification</td>
                <td>
                    <asp:TextBox ID="TextQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Join Date</td>
                <td>
                    <asp:Literal ID="LiteralJoindate" runat="server"></asp:Literal></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonTutor" runat="server" Text="Insert" OnClick="ButtonTutor_Click" /></td>
                <td>
                    <asp:Label ID="Labelmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
