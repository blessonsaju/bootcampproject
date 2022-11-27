<%@ Page Title="" Language="C#" MasterPageFile="~/admin/prod.Master" AutoEventWireup="true" CodeBehind="replay.aspx.cs" Inherits="complaintProject.admin.replay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Reply" OnClick="Button1_Click" style="height: 29px" />
</asp:Content>
