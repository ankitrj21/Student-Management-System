<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Student_Management_System.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Student page ...!!</h1>
    <div style="background-color:aqua; width:300px; ">
        <table border="1">
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="TextStfname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="TextStlname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Father's Name</td>
                <td>
                    <asp:TextBox ID="TextFathername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone</td>
                <td>
                    <asp:TextBox ID="TextStPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextStEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course Join</td>
                <td>
                    <asp:DropDownList ID="DDLCoursejoin" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource1" DataTextField="Cname" DataValueField="Cname" OnSelectedIndexChanged="DDLCoursejoin_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="--Select Course--"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString %>" SelectCommand="SELECT [Cname] FROM [Coursetable]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Course Fees</td>
                <td>
                    <asp:Label ID="LabelCoursefee" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>First Installment</td>
                <td>
                    <asp:TextBox ID="TextFirstinstallment" runat="server" AutoPostBack="true" OnTextChanged="TextFirstinstallment_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fee Due</td>
                <td>
                    <asp:Label ID="LabelFeedue" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Join Date</td>
                <td>
                    <asp:Literal ID="LiteralJoindate" runat="server"></asp:Literal></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonStudent" runat="server" Text="Insert Record" OnClick="ButtonStudent_Click" /></td>
                <td>
                    <asp:Label ID="Labelmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
