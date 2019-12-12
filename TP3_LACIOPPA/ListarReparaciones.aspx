<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarReparaciones.aspx.cs" Inherits="TP3_LACIOPPA.ListarReparaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <h2>REPARACIONES</h2>
    </center>

    <br />
    <h3>EN REPARACION</h3>
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">ORDEN</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">APELLIDO</th>
                <th scope="col">TELEFONO</th>
                <th scope="col">MARCA</th>
                <th scope="col">MODELO</th>
                <th scope="col">PROBLEMA</th>
                <th scope="col">ENTRADA</th>
            </tr>
        </thead>
        <tbody>
       <% foreach (var item in lista1)
            { %>
            <tr>
              <td><% = item.orden %></td>
              <td><% = item.cliente.nombre %></td>
              <td><% = item.cliente.apellido %></td>
              <td><% = item.cliente.telefono %></td>
              <td><% = item.equipo.marca %></td>
              <td><% = item.equipo.modelo %></td>
              <td><% = item.problema %></td>
              <td><% = item.fecha_entrada %></td>
            
            </tr>
        <% } %>
    
    </tbody>
</table>            
    <br />
    <br />
    <h3>FINALIZADO</h3>
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">ORDEN</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">APELLIDO</th>
                <th scope="col">TELEFONO</th>
                <th scope="col">MARCA</th>
                <th scope="col">MODELO</th>
                <th scope="col">PROBLEMA</th>
                <th scope="col">INFORME</th>
                <th scope="col">ENTRADA</th>
                <th scope="col">SALIDA</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in lista2)
            { %>
            <tr>
              <td><% = item.orden %></td>
              <td><% = item.cliente.nombre %></td>
              <td><% = item.cliente.apellido %></td>
              <td><% = item.cliente.telefono %></td>
              <td><% = item.equipo.marca %></td>
              <td><% = item.equipo.modelo %></td>
              <td><% = item.problema %></td>
              <td><% = item.informe %></td>
              <td><% = item.fecha_entrada %></td>
              <td><% = item.fecha_salida %></td>
            
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
