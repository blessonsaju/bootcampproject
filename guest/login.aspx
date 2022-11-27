<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="complaintProject.guest.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



    <style type="text/css">
            .txtbox{
                -webkit-border-radius: 20px;
                -moz-border-radius: 5px;
                border-radius: 5px;
                width: 190px;
            }
            body {
                background-image:url('https://dm0qx8t0i9gc9.cloudfront.net/thumbnails/video/GTYSdDW/videoblocks-blue-business-background-2_h3cvzluwb_thumbnail-1080_01.png');
                background-repeat:no-repeat;
                background-attachment:fixed;
                }
       
            
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <h3 align="center" style="height: 37px">Login</h3>
    
    <table align="center">
        <tr>
            <td>User Name</td>
            <td><asp:TextBox ID="luser" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="username" ></asp:TextBox></td>
        </tr>

        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="lpass" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="lbutton" runat="server" Text="Login" CssClass="btn btn=primary" Width="170px" OnClick="lbutton_Click"  /></td>
        </tr>
    </table>

</div>
</asp:Content>
