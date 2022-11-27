<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="reguser.aspx.cs" Inherits="complaintProject.guest.reguser1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
            .txtbox{
                -webkit-border-radius: 20px;
                -moz-border-radius: 5px;
                border-radius: 5px;
                width: 190px;
            }
            body {
                background-image:url('https://th.bing.com/th/id/R.d1c799fc969449edee414c73eb2e5bc1?rik=5F1o7lNnPCqCIg&riu=http%3a%2f%2fdanpatrascu.com%2fwp-content%2fuploads%2f2019%2f03%2flaptop.jpg&ehk=VJ82Qh9OGFYjcN50cXtXyflU5s%2fuVgQQyWozX0vt2t8%3d&risl=&pid=ImgRaw&r=0');
                background-size:cover;
                background-repeat:no-repeat;
                background-attachment:fixed;
                }
       td {
           padding: 20px;
       }
       
            
        </style>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h3 align="center">USER REGISTRATION</h3><br />
                        
                                        <table align="center" class="auto-style1">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="cname" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="name"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Age</td>
            <td>
                <asp:TextBox ID="cage" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Age"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="cemail" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Email"></asp:TextBox></td>
        </tr>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="cuser" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="username"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="cpass" runat="server" TextMode="Password" Enabled="true" CssClass="form-control input-sm" placeholder="password"></asp:TextBox></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="ssub" runat="server" Text="Register" CssClass="btn btn=primary" Width="170px" OnClick="ssub_Click"   /></td>
        </tr>
    </table>
</asp:Content>
