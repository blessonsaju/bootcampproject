<%@ Page Title="" Language="C#" MasterPageFile="~/user/homeuser.Master" AutoEventWireup="true" CodeBehind="complaint.aspx.cs" Inherits="complaintProject.user.complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
         body {
                background-image:url('http://lawwallet.in/wp-content/uploads/2021/06/complaint.jpg');
                background-size:cover;
                background-repeat:no-repeat;
                background-attachment:fixed;
                }
         h3{
                font-size:25px;
            }
         
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />

    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <h3 align="center">COMPLAINT REGISTRATION</h3>
    <table align="center">
        <tr>
            <td>PRODUCT</td>
            <td>
                <asp:DropDownList ID="drop" runat="server" DataSourceID="SqlDataSource1" DataTextField="product_name" DataValueField="product_name"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:complaintConnectionString %>" SelectCommand="SELECT [product_name] FROM [tblproduct]"></asp:SqlDataSource>
            </td>
        </tr>

        <tr>
            <td>COMPLAINT</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"  Enabled="true" CssClass="form-control input-sm" placeholder="complaint"></asp:TextBox>
            </td><br />
            </tr>
        

        
        <tr>
            <td>
                <asp:Button ID="lbutton" runat="server" Text="SUBMIT COMPLAINT"   CssClass="btn btn=primary" Width="170px" OnClick="lbutton_Click"   /></td>
        </tr>
    </table>
    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
</asp:Content>
