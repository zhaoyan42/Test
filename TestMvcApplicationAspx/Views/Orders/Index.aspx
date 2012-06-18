<%@ Page Title="Title" Language="C#" Inherits="ViewPage<IEnumerable<ExceptionTest.Model.OrdersDTO>>" MasterPageFile="~/Views/Shared/MasterPage.Master"%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">

<table>
<% foreach (var order in Model)
   {
       %>
       <tr>
           <td><%=order.OrderDate %></td>
           <td><%=order.CompanyName%></td>
           <td><%=order.FirstName%></td>
           <td><%=order.LastName%></td>
       </tr>
       <%
   } %>
</table>
</asp:Content>
