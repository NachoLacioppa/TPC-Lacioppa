<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StockRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.StockRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>AGREGAR REPUESTOS</h2>
    <br />
    <p>Buscar repuesto: (beta: solo codigo)</p>
    <asp:TextBox ID="txtBuscarRepuesto" runat="server" class="form-control" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click"  />
    <br />
    <asp:GridView ID="dgvListarRepuestos" runat="server" cssclass="table table-stripped table-dark"></asp:GridView>
    <%--<table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">CODIGO</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">CANTIDAD DISPONIBLE</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listarRepuestoStock)
            { %>
            <tr>           
              <td><% = item.codigo %></td>
              <td> <% = item.nombre %></td>
              <td> <% = item.cantidad %></td>
            </tr>
        <% } %>
    </tbody>
</table>--%>
    <h3>Agregue la cantidad de repuestos deseado</h3>
    <asp:TextBox ID="txtAgregarStock" runat="server" class="form-control" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnAgregarStock" runat="server" Text="Agregar" class="btn btn-primary" />
</asp:Content>
