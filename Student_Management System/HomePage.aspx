<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Student_Management_System.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Student Management System</h1>
                <h2>ASP.Net C# Project</h2>
                <hr />
                <div style="background-color:aqua; height:100px; width:250px;">
                    <table border="1">
                        <tr>
                            <td>Admin User Id</td>
                            <td><asp:TextBox ID="TextAdminId" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td><asp:TextBox ID="TextAdminPswd" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="ButtonLogin" runat="server" Text="login" OnClick="ButtonLogin_Click"></asp:Button></td>
                            <td><asp:Label ID="LabelMsg" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                        </tr>
                    </table>
                </div>
            </center>
        </div>
    </form>
</body>
</html>
