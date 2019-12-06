<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.ModificarRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>MODIFICAR REPUESTO</h2>
    <br />
    <p>Buscar repuesto: (beta: solo codigo)</p>
    <asp:TextBox ID="txtBuscarRepuesto" runat="server" class="form-control" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
    <br />
    <br />
    <form>
      <p>Codigo</p>
      <asp:TextBox ID="txtcod" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Nombre</p>
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="450px"></asp:TextBox>
     <%-- <p>Cantidad</p>
      <asp:TextBox ID="txtcantidad" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>--%>
      <p>Precio</p>
      <asp:TextBox ID="txtprecio" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Categoria</p>
      <asp:DropDownList ID="dwCategorias" runat="server"></asp:DropDownList>
      <br />
      <asp:Button ID="btnModificarRepuesto" runat="server" Text="Modificar" class="btn btn-warning" OnClick="btnModificarRepuesto_Click" />
    </form>
</asp:Content>
