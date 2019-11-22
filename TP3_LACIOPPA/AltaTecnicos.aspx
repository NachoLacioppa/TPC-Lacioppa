<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaTecnicos.aspx.cs" Inherits="TP3_LACIOPPA.AltaTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>AGREGAR NUEVO TECNICO</h2>
  <form>
      <h3>CREDENCIALES PARA ENTRAR AL SISTEMA COMO TECNICO</h3>
      <p>USUARIO</p>
      <asp:TextBox ID="txtUSER" runat="server" class="form-control" type="text" Width="200px"></asp:TextBox>
      <p>CONTRASEÑA</p>
      <asp:TextBox ID="txtPASS" runat="server" class="form-control" type="text" Width="200px"></asp:TextBox>
      <br />
      <br />
      <h3>DATOS PERSONALES DEL TECNICO</h3>
      <p>Nombre</p>
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <p>Apellido</p>
      <asp:TextBox ID="txtapellido" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <p>DNI</p>
      <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <p>Sueldo</p>
      <asp:TextBox ID="txtsueldo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <br />
      <asp:Button ID="btnAgregarTecnico" runat="server" class="btn btn-primary" Text="Cargar Tecnico"  />
  </form>
</asp:Content>
