<%@ Page Title="" Language="C#" MasterPageFile="~/admin/prod.Master" AutoEventWireup="true" CodeBehind="viewquery.aspx.cs" Inherits="complaintProject.admin.viewquery" %>
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
    <h1 align="center">view query </h1>
    <asp:GridView ID="GridView1" runat="server" align="center" AutoGenerateColumns="False"  DataKeyNames="query_id">
        <Columns>
            <asp:BoundField DataField="username" HeaderText="USERNAME" />
            <asp:BoundField DataField="Email" HeaderText="EMAIL" />
            <asp:BoundField DataField="product_name" HeaderText="PRODUCT" />
            <asp:BoundField DataField="query" HeaderText="QUERY" />
        </Columns>
    </asp:GridView>
</asp:Content>
