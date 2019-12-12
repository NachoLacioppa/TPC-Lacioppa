<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BusquedaTecnicos.aspx.cs" Inherits="TP3_LACIOPPA.BusquedaTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>LISTADO DE TODOS LOS TECNICOS</h2>
    </center>
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">USUARIO</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">APELLIDO</th>
                <th scope="col">DNI</th>
                <th scope="col">PERFIL</th>
            </tr>
        </thead>
        <tbody>
       <% foreach (var item in listarTecnicos)
            { %>
            <tr>
             
              <td><% = item.usuario %></td>
              <td><% = item.nombre %></td>
              <td> <% = item.apellido %></td>
              <td> <% = item.dni %></td>
              <td> <% = item.perfil.nombre %></td>
            </tr>
        <% } %>
    </tbody>
</table>            
</asp:Content>
