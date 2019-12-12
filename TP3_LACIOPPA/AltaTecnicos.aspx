<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaTecnicos.aspx.cs" Inherits="TP3_LACIOPPA.AltaTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>AGREGAR NUEVO TECNICO</h2>
    </center>
<form>
  <div class="form-row">
    <div class="form-group col-md-6">
            <h3>CREDENCIALES PARA ENTRAR AL SISTEMA COMO TECNICO</h3>
      <asp:Label Text="USUARIO" runat="server" />
      <asp:TextBox ID="txtUSER" runat="server" class="form-control" type="text" Width="200px"></asp:TextBox>
        <asp:Label Text="CONTRASEÑA" runat="server" />
      <asp:TextBox ID="txtPASS" runat="server" class="form-control" type="text" Width="200px" TextMode="Password"></asp:TextBox>
        <asp:Label Text="PERFIL" runat="server" />
        <br />
      <asp:DropDownList ID="dwPerfil" runat="server" class="btn btn-secondary btn-sm dropdown-toggle"></asp:DropDownList>
    </div>
  </div>
  <div class="form-group">
   <h3>DATOS PERSONALES DEL TECNICO</h3>
      <asp:Label Text="Nombre" runat="server" />
      <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <asp:Label Text="Apellido" runat="server" />
      <asp:TextBox ID="txtapellido" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <asp:Label Text="DNI" runat="server" />
      <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
      <asp:Label Text="Sueldo $" runat="server" />
      <asp:TextBox ID="txtsueldo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
      <br />
      <asp:Button ID="btnAgregarTecnico" runat="server" class="btn btn-primary" Text="Cargar Tecnico" OnClick="btnAgregarTecnico_Click"  />
  </div>
</form>
</asp:Content>
