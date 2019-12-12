<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BusquedaCliente.aspx.cs" Inherits="TP3_LACIOPPA.BusquedaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>LISTADO DE TODOS LOS CLIENTES</h2>
    </center>
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">NOMBRE</th>
                <th scope="col">APELLIDO</th>
                <th scope="col">DNI</th>
                <th scope="col">DIRECCION</th>
                <th scope="col">LOCALIDAD</th>
                <th scope="col">TELEFONO</th>
                <th scope="col">MAIL</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listaClientes)
            { %>
            <tr>
             
              <td><% = item.nombre %></td>
              <td> <% = item.apellido %></td>
              <td> <% = item.dni %></td>
              <td> <% = item.direccion %></td>
              <td> <% = item.localidad%></td>
              <td> <% = item.telefono %></td>
              <td> <% = item.mail %></td>
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
