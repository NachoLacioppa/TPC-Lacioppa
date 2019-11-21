<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarStockRepuesto.aspx.cs" Inherits="TP3_LACIOPPA.AgregarStockRepuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>AGREGAR STOCK REPUESTOS</h2>
    <br />
    <p>Buscar Repuesto por codigo:</p>
    <asp:TextBox ID="txtBuscarRepuesto" runat="server" class="form-control"></asp:TextBox>
    <br />
    <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
    <br />
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">CODIGO</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">CANTIDAD DISPONIBLE</th>
                <th scope="col">PRECIO</th>
                <th scope="col">CATEGORIA</th>
                
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
              <td> <% = item.categoria.nombre%></td>
              
            </tr>
        <% } %>
    
    </tbody>
        <br />
        <p>Agregar stock</p>
        <asp:TextBox ID="txtAgrearStock" runat="server" class="form-control"></asp:TextBox>
        <asp:Button ID="btnAgregarStock" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregarStock_Click"/>
</asp:Content>
