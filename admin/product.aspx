<%@ Page Title="" Language="C#" MasterPageFile="~/admin/prod.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="complaintProject.admin.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
                background-image:url('https://static.videezy.com/system/resources/thumbnails/000/054/158/small_2x/whiteHexa4kbg.jpg');
                background-size:cover;
                background-repeat:no-repeat;
                background-attachment:fixed;
                }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h3 align="center">PRODUCT REGISTRATION</h3>
    <table align="center">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="pname" runat="server"  Enabled="true" CssClass="form-control input-sm" placeholder="product name"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ssub" runat="server" Text="REGISTER" CssClass="btn btn=primary" Width="170px" OnClick="ssub_Click"    /></td>
        </tr>
        
        
    </table>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" align="center" AutoGenerateColumns="False" DataKeyNames="product_id" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="product_name" HeaderText="PRODUCT NAME" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>

        </asp:GridView>
</asp:Content>
