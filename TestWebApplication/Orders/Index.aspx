<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestWebApplication.Orders.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView ID="OrdersList" runat="server" AutoGenerateColumns="False" ShowHeader="False">
    <Columns>
        <asp:BoundField DataField="OrderDate"/>
        <asp:BoundField DataField="CompanyName"/>
        <asp:BoundField DataField="FirstName"/>
        <asp:BoundField DataField="LastName"/>
    </Columns>
</asp:GridView>

</asp:Content>

