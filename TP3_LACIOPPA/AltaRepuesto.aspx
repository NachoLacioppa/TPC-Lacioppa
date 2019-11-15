<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaRepuesto.aspx.cs" Inherits="TP3_LACIOPPA.AltaRepuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>CARGAR NUEVO REPUESTO</h2>
    <form>
      <p>Codigo</p>
      <asp:TextBox ID="txtCodigo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Nombre</p>
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Cantidad</p>
      <asp:TextBox ID="txtCantidad" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Precio</p>
      <asp:TextBox ID="txtPrecio" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Categoria</p>
      <asp:DropDownList ID="dwCategorias" runat="server"></asp:DropDownList>
      <br />
      <asp:Button ID="btnAltaRepuesto" runat="server" class="btn btn-primary" Text="Cargar Repuesto" OnClick="btnAltaRepuesto_Click" />
  </form>
</asp:Content>
