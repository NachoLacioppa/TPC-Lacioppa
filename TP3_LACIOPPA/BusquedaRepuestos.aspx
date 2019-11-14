<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BusquedaRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.BusquedaRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>LISTAR TODOS LOS REPUESTOS</h2>
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">CODIGO</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">CANTIDAD DISPONIBLE</th>
                <th scope="col">PRECIO</th>
                <%--<th scope="col">CATEGORIA</th>--%>
                
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listarRepuestos)
            { %>
            <tr>
             
              <td><% = item.codigo %></td>
              <td> <% = item.nombre %></td>
              <td> <% = item.cantidad %></td>
              <td> <% = item.precio %></td>
              <%--<td> <% = item.categoria%></td>--%>
              
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
