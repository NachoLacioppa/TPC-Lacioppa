<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="TP3_LACIOPPA.ModificarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>MODIFICAR CLIENTE</h2>
    <br />
    <p>Buscar cliente: (beta: solo dni)</p>
    <asp:TextBox ID="txtBuscarMod" runat="server" class="form-control" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnBuscarClienteMod" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarClienteMod_Click"/>
    <br />
    <br />
    <form>
      <p>Nombre</p>
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Apellido</p>
      <asp:TextBox ID="txtApellido" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>DNI</p>
      <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Direccion</p>
      <asp:TextBox ID="txtDireccion" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <p>Localidad</p>
      <asp:TextBox ID="txtLocalidad" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <p>Telefono</p>
      <asp:TextBox ID="txtTelefono" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Mail</p>
      <asp:TextBox ID="txtMail" runat="server" class="form-control" type="text" Width="300px"></asp:TextBox>
      <br />
      <asp:Button ID="btnModificarCliente" runat="server" Text="Modificar" class="btn btn-warning"/>
    </form>

</asp:Content>
