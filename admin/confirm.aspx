<%@ Page Title="" Language="C#" MasterPageFile="~/admin/prod.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="complaintProject.admin.confirm" %>
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
     <h3 align="center">CONFIRMATION</h3>
    
<asp:GridView ID="GridView1" runat="server" align ="center" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="username" HeaderText="User_Name" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:BoundField DataField="usertype" HeaderText="User_Type" />
            
            <asp:CommandField EditText="confirm" HeaderText="confirmmation" DeleteText="confirm" ShowDeleteButton="True" />
            
        </Columns>

    </asp:GridView>
    <br />
    <asp:GridView ID="GridView2" runat="server"  align="center" AutoGenerateColumns="False" DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="username" HeaderText="User_name" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:BoundField DataField="usertype" HeaderText="User_type" />
        </Columns>
     </asp:GridView>
</asp:Content>
