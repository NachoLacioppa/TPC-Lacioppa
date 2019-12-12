<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EquiposCargados.aspx.cs" Inherits="TP3_LACIOPPA.EquiposCargados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>EQUIPOS CARGADOS</h2>
    </center>
    
     <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">S/N</th>
                <th scope="col">MARCA</th>
                <th scope="col">MODELO</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listaEquipos)
            { %>
            <tr>
              <td><% = item.numeroserie %></td>
              <td> <% = item.marca %></td>
              <td> <% = item.modelo %></td>
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
