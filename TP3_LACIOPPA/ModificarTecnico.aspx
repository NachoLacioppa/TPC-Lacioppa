<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarTecnico.aspx.cs" Inherits="TP3_LACIOPPA.ModificarTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>MODIFICAR TECNICO</h2>
    <br />
    <p>Buscar Tecnico: (beta: solo dni)</p>
    <asp:TextBox ID="txtBuscarUsuario" runat="server" class="form-control" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnBuscarTecn" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarTecn_Click" />
    <br />
    <br />
    <form>
        <p>USUARIO</p>
        <asp:TextBox ID="txtusuario" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <br />
        <br />
      <p>Nombre</p>
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Apellido</p>
      <asp:TextBox ID="txtApellido" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>DNI</p>
      <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Sueldo</p>
      <asp:TextBox ID="txtsueldo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <p>Perfil</p>
      <asp:DropDownList ID="dwPerfil" runat="server"></asp:DropDownList>
      <br />
        <br />
        <br />
      <asp:Button ID="btnModificarCliente" runat="server" Text="Modificar" class="btn btn-warning" OnClick="btnModificarCliente_Click" />
    </form>
</asp:Content>
