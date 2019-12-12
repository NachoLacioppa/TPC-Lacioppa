<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarCateogtiasRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.AgregarCateogtiasRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>AGREGAR CATEGORIA DE REPUESTO</h2>
    </center>
    <br />
    <p>Nombre de Categoria</p>
    <asp:TextBox ID="txtCategoriaRepuesto" runat="server" class="form-control" Width="150px" ></asp:TextBox>
    <br />
    <asp:Button ID="btnCategoriaRepuesto" runat="server" Text="Agregar Categoria"  class="btn btn-primary" OnClick="btnCategoriaRepuesto_Click" />
    <br />
    <br />
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">CATEGORIAS AGREGADAS</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listarCategorias)
            { %>
            <tr>
              <td><% = item.nombre %></td>
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
