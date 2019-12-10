<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.ModificarRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
    <h2>MODIFICAR REPUESTO</h2>
     <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Buscar repuesto (solo codigo)" runat="server" />
        <asp:TextBox ID="txtBuscarRepuesto" runat="server" class="form-control" Width="150px"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
    </div>
  </div>
  <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Codigo" runat="server" />
      <asp:TextBox ID="txtcod" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Nombre" runat="server" />
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="450px"></asp:TextBox>
        <asp:Label Text="Precio" runat="server" />
      <asp:TextBox ID="txtprecio" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Categoria" runat="server" />
        <br />
      <asp:DropDownList ID="dwCategorias" runat="server" class="btn btn-secondary btn-sm dropdown-toggle"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnModificarRepuesto" runat="server" Text="Modificar" class="btn btn-warning" OnClick="btnModificarRepuesto_Click" />
    </div>
  </div>
  
</form>
</asp:Content>
