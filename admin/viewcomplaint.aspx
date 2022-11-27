<%@ Page Title="" Language="C#" MasterPageFile="~/admin/prod.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="complaintProject.admin.viewcomplaint" %>
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
    <h1 align="center">USER COMPLAINTS</h1>
    <asp:GridView ID="GridView2" runat="server" align="center" AutoGenerateColumns="False" DataKeyNames="copmaint_id" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
        <Columns>
            <asp:BoundField DataField="complaint" HeaderText="COMPLAINT" />
            <asp:BoundField DataField="product_name" HeaderText="PRODUCT" />
            <asp:BoundField DataField="name" HeaderText="USER" />
            <asp:BoundField DataField="date" HeaderText="DATE" />
            <asp:CommandField DeleteText="process" HeaderText="STATUS" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <h1 align="center">processing</h1>
    <asp:GridView ID="GridView1" runat="server" align="center" AutoGenerateColumns="False" DataKeyNames="copmaint_id" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="complaint" HeaderText="complaint" />
            <asp:BoundField DataField="product_name" HeaderText="product" />
            <asp:BoundField DataField="name" HeaderText="user" />
            <asp:BoundField DataField="date" HeaderText="date" />
            <asp:CommandField DeleteText="closed" HeaderText="status" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <h1 align="center">completed</h1>
    <br />
    <asp:GridView ID="GridView3" runat="server"  align="center" AutoGenerateColumns="False" DataKeyNames="copmaint_id">
        <Columns>
            <asp:BoundField DataField="complaint" HeaderText="COMPLAINT" />
            <asp:BoundField DataField="product_name" HeaderText="PRODUCT" />
            <asp:BoundField DataField="user_name" HeaderText="USER" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="status" HeaderText="Status" />
        </Columns>
    </asp:GridView>
</asp:Content>
